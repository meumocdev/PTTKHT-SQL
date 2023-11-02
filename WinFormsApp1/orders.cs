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
    public partial class orders : Form
    {
        public orders()
        {
            InitializeComponent();
            load();
        }

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Storage1;Integrated Security=True");
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

        private void load()
        {
            DataTable dt = Red("Select * from Orders");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querydetail = "INSERT INTO Orders(ShippmentID,SupplierID) VALUES ('" + ShippmentID.Text + "','" + suppliID.Text + "')";
            Exe(querydetail);
            load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Reset()
        {
            ShippmentID.Text = "ShippmentID";
            suppliID.Text = "SupplierID";
            load();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            ShippmentID.Text = Convert.ToString(row.Cells["ShippmentID"].Value);
            suppliID.Text = Convert.ToString(row.Cells["SupplierID"].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Orders SET ShippmentID = " + ShippmentID.Text + "  WHERE SupplierID = '" + suppliID.Text + "'";
            Exe(query);
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "DELETE Orders  WHERE ShippmentID = '" + ShippmentID.Text + "' AND SupplierID = '" + suppliID.Text + "'";
            Exe(query);
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "SupplierID", "*" + textBox1.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
    }
}
