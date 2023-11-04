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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Depot : Form
    {
        public Depot()
        {
            InitializeComponent();
        }
        ConnectData c = new ConnectData();


        private void button4_Click(object sender, EventArgs e)
        {
            Menu ad = new Menu();
            ad.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Depot_Load(object sender, EventArgs e)
        {

            c.connect();
            DataTable data = new DataTable();
            string query = "SELECT DISTINCT ProductID From InStorage";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "ProductID";

            DataTable data2 = new DataTable();
            string query2 = "SELECT ID,ProductID,InStorageAfter FROM InStorage";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            dataGridView1.DataSource = data2;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string productID = comboBox1.Text;
            if (string.IsNullOrEmpty(productID))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã hóa đơn xuất!");
                return;
            }
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    c.connect();
                    string sql = "SELECT * FROM InStorage WHERE ProductID = @ProductID";
                    SqlCommand cmd2 = new SqlCommand(sql, c.conn);
                    cmd2.Parameters.AddWithValue("@ProductID", productID);
                    SqlDataReader reader = cmd2.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu nào trùng khớp với mã hóa đơn xuất!");
                    }
                    // conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        int tat = 0;
        private void Depot_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tat == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "SELECT DISTINCT ProductID From InStorage";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            comboBox1.DataSource = data;
            comboBox1.ValueMember = "ProductID";

            DataTable data2 = new DataTable();
            string query2 = "SELECT ID,ProductID,InStorageAfter FROM InStorage";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            dataGridView1.DataSource = data2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string exportBillID = dataGridView1.SelectedRows[0].Cells["ProductID"].Value.ToString();
                using (SqlConnection conn = new SqlConnection())
                {
                    try
                    {
                        c.connect();
                        string sql = "DELETE FROM InStorage WHERE ProductID = @ProductID";
                        SqlCommand cmd = new SqlCommand(sql, c.conn);
                        cmd.Parameters.AddWithValue("@ProductID", exportBillID);
                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            DataTable data2 = new DataTable();
                            string query2 = "SELECT ID,ProductID,InStorageAfter FROM InStorage";
                            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
                            cmd2.Connection = c.conn;
                            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                            adp2.Fill(data2);
                            dataGridView1.DataSource = data2;
                        }
                        else
                        {
                            MessageBox.Show("Xóa dữ liệu thất bại!");
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                return;
            }
        }
    }
}
