using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AddPr : Form
    {
        public AddPr()
        {
            InitializeComponent();
            load();
        }
        ConnectData c = new ConnectData();
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
            DataTable dt = Red("Select * from PRODUCT");
            if (dt != null)
            {
                dataGridView2.DataSource = dt;
            }
        }
        private void loadDetailBillImport(string madon)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Depot Dp = new Depot();
            Dp.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Menu ad = new Menu();
            ad.Show();
            this.Hide();
        }
        int tat = 0;
        private void DetailIp_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu biến tat bằng 0, tức là người dùng không nhấn nút thoát mà nhấn nút X trên thanh tiêu đề
            if (tat == 0)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult DR = MessageBox.Show("Bạn có muốn FormClosing không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn No thì hủy việc đóng form
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Gán biến tat bằng 1
            tat = 1;

            // Hiển thị hộp thoại xác nhận
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn Yes thì thoát chương trình
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }



        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }



        private void button8_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "INSERT INTO PRODUCT(ProductID,ProductName,Currency,ImportPriceItem, ExportPriceItem) VALUES (@ProductID, @ProductName,@Currency, @ImportPriceItem, @ExportPriceItem)";
            string productID = ProductID.Text;
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            cmd.CommandText = "Insert_PRODUCT";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", productID);
            cmd.Parameters.AddWithValue("@ProductName", ProductName.Text);
            cmd.Parameters.AddWithValue("@Currency", Currency.Text);
            cmd.Parameters.AddWithValue("@ImportPriceItem", decimal.Parse(ImportPriceItem.Text));
            cmd.Parameters.AddWithValue("@ExportPriceItem", decimal.Parse(ExportPriceItem.Text));
            cmd.ExecuteNonQuery();


            load();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            ProductID.Text = Convert.ToString(row.Cells["ProductID"].Value);
            ProductName.Text = Convert.ToString(row.Cells["ProductName"].Value);
            Currency.Text = Convert.ToString(row.Cells["Currency"].Value);
            ImportPriceItem.Text = Convert.ToString(row.Cells["ImportPriceItem"].Value);
            ExportPriceItem.Text = Convert.ToString(row.Cells["ExportPriceItem"].Value);
        }



        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        /* public bool KTThongTin()
         {
             *//*            if (comboimport.Text == "")
                         {
                             MessageBox.Show("Vui lòng chọn ImportBillID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             comboimport.Focus();
                             return false;
                         }
                         if (comboproduct.Text == "")
                         {
                             MessageBox.Show("Vui lòng chọn ProductID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             comboproduct.Focus();
                             return false;
                         }
                         if (textAMOUNT.Text == "")
                         {
                             MessageBox.Show("Vui lòng nhập AmountImport", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             textAMOUNT.Focus();
                             return false;
                         }
                         if (texprice.Text == "")
                         {
                             MessageBox.Show("Vui lòng nhập PriceImport", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             texprice.Focus();
                             return false;
                         }
                         return true;*//*
         }
 */


        private void update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE PRODUCT SET ImportPriceItem = " + ImportPriceItem.Text + " , ExportPriceItem = '" + ExportPriceItem.Text + "' WHERE ProductID = '" + ProductID.Text + "' AND ProductName = '" + ProductName.Text + "'";
            Exe(query);
            load();
        }
        private void reset_Click(object sender, EventArgs e)
        {
            ProductID.Text = "";
            ProductName.Text = "";
            Currency.Text = "";
            ImportPriceItem.Text = "";
            ExportPriceItem.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sử dụng thuộc tính RowFilter để tìm kiếm theo tên "Name"
            string rowFilter = string.Format("{0} like '{1}'", "ProductID", "*" + textBox1.Text + "*");
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void ProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExportPriceItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
