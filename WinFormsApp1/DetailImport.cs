using System;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class DetailImport : Form
    {
        public DetailImport()
        {
            InitializeComponent();
            // load();

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
            DataTable dt = Red("Select * from DetailImport");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void loadOrderDetail(string ma)
        {
            // Sử dụng biến toàn cục supplierID trong câu lệnh SQL
            DataTable dt = Red("Select * from DetailImport");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }




        //mở kết nối với database
        int tat = 0;
        private void label2_Click(object sender, EventArgs e)
        {
/*            if (tat == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn FormClosing không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Double ImportPriceItem = Convert.ToDouble(((DataRowView)productid.SelectedItem)["ImportPriceItem"]);
            string ImportPriceItemString = ImportPriceItem.ToString("F2");
            importPriceItem.Text = ImportPriceItemString;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPr Detail = new AddPr();
            Detail.Show();
            this.Hide();
        }

        private void ADD_Load(object sender, EventArgs e)
        {
            string sql = "Select * From PRODUCT";
            string sql2 = "Select * From Supplier";
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sql, con);
            SqlDataAdapter da3 = new SqlDataAdapter(sql2, con);
            da2.Fill(dt2);
            da3.Fill(dt3);
            productid.DataSource = dt2;
            productid.DisplayMember = "ProductID";
            productid.ValueMember = "ProductID";
            SupplierID.DataSource = dt3;
            SupplierID.DisplayMember = "SupplierID";
            SupplierID.ValueMember = "SupplierID";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Depot Dp = new Depot();
            Dp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "INSERT INTO DetailImport(ShippmentID,SupplierID,ProductID,AmountOrder, ImportPriceItem, PriceOrder) VALUES (@ShippmentID, @SupplierID,@ProductID, @AmountOrder, @ImportPriceItem)";
            string exportBillID = ShippmentID.Text;
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            cmd.CommandText = "Insert_DetailImport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ShippmentID", exportBillID);
            cmd.Parameters.AddWithValue("@SupplierID", SupplierID.SelectedValue);
            cmd.Parameters.AddWithValue("@ProductID", productid.SelectedValue);
            cmd.Parameters.AddWithValue("@AmountOrder", int.Parse(AmountOrder.Text));
            cmd.Parameters.AddWithValue("@ImportPriceItem", decimal.Parse(importPriceItem.Text));
            cmd.ExecuteNonQuery();
            loadOrderDetail(ShippmentID.Text);

            DataTable data2 = new DataTable();
            string query2 = "SELECT * FROM DetailImport";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            dataGridView1.DataSource = data2;

            BindingSource bs = new BindingSource();
            bs.DataSource = data2;
            bs.Filter = "ShippmentID LIKE '" + ShippmentID.Text + "'";
            dataGridView1.DataSource = bs;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Import o = new Import();
            o.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            ShippmentID.Text = "ShippmentID";
            SupplierID.Text = "SupplierID";
            productid.Text = "ProductID";
            AmountOrder.Text = "";
            load();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            ShippmentID.Text = Convert.ToString(row.Cells["ShippmentID"].Value);
            SupplierID.Text = Convert.ToString(row.Cells["SupplierID"].Value);
            productid.Text = Convert.ToString(row.Cells["ProductID"].Value);
            AmountOrder.Text = Convert.ToString(row.Cells["AmountOrder"].Value);
            importPriceItem.Text = Convert.ToString(row.Cells["ImportPriceItem"].Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "UPDATE DetailImport SET AmountOrder = " + Convert.ToInt32(AmountOrder.Text) + "  WHERE ShippmentID = '" + ShippmentID.Text + "' AND SupplierID = '" + SupplierID.Text + "' AND ProductID = '" + productid.Text + "'";
            Exe(query);
            load();
        }
        ConnectData c = new ConnectData();
        private void button5_Click_1(object sender, EventArgs e)
        {
            string query = "DELETE FROM DetailImport WHERE ShippmentID = '" + ShippmentID.Text + "' AND SupplierID = '" + SupplierID.Text + "' AND ProductID = '" + productid.Text + "'";
            Exe(query);
            load();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "ShippmentID", "*" + textBox1.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShippmentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Menu o = new Menu();
            o.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void DetailImport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tat == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn FormClosing không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}

