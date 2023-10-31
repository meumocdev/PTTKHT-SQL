using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class importBill : Form
    {
        public importBill()
        {
            InitializeComponent();
            load();

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-S7G583VS\SQLEXPRESS;Initial Catalog=Storage;Integrated Security=True");
        private void openCon()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }
        private void closeCon()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        private Boolean Exe(string cmd)
        {
            openCon();
            Boolean check;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(cmd, con);

                sqlCommand.ExecuteNonQuery();
                check = true;

            }
            catch (Exception ex)
            {
                check = false;
            }
            closeCon();
            return check;
        }
        private DataTable Red(string cmd)
        {
            openCon();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sqlCommand = new SqlCommand(cmd, con);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw;

            }
            closeCon();
            return dt;

        }

        /*private void loadImportBill()
        {
            DataTable dt = Red("Select * from ImportBill ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }*/
        private void load()
        {
            DataTable dt = Red("Select * from ImportBill ");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DetailIp sl = new DetailIp();
            sl.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Depot sl = new Depot();
            sl.Show();
            this.Hide();
        }

        private void madon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            comboimportid.Text = "ImportBillID";
            shippmentid.Text = "ShippmentID";
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO ImportBill(ImportBillID,ShippmentID) VALUES ('" + comboimportid.Text + "','" + shippmentid.Text + "')";
            Exe(query);
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string rowFilter = string.Format("{0} like '{1}'", "ImportBillID", "*" + textBox1.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            comboimportid.Text = Convert.ToString(row.Cells["ImportBillID"].Value);
            shippmentid.Text = Convert.ToString(row.Cells["ShippmentID"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE ImportBill  WHERE ImportBillID = '" + comboimportid.Text + "'";
            Exe(query);
            load();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
