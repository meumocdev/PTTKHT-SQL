using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class DetailEp : Form
    {
        public DetailEp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string exportBillID = dataGridView1.SelectedRows[0].Cells["ExportBillID"].Value.ToString();
                using (SqlConnection conn = new SqlConnection())
                {
                    try
                    {
                        c.connect();
                        string sql = "DELETE FROM DetailBillExport WHERE ExportBillID = @ExportBillID";
                        SqlCommand cmd = new SqlCommand(sql, c.conn);
                        cmd.Parameters.AddWithValue("@ExportBillID", exportBillID);
                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            DataSet data = new DataSet();
                            string query = "Select * From DetailBillExport";
                            SqlCommand cmd2 = new SqlCommand(query, c.conn);
                            cmd2.Connection = c.conn;
                            SqlDataAdapter adp = new SqlDataAdapter(cmd2);
                            adp.Fill(data);
                            dataGridView1.DataSource = data.Tables[0];
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

        private void button1_Click(object sender, EventArgs e)
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
            Sell sl = new Sell();
            sl.Show();
            this.Hide();
        }
        int tat = 0;
        private void DetailEp_FormClosing(object sender, FormClosingEventArgs e)
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
        ConnectData c = new ConnectData();
        private void DetailEp_Load(object sender, EventArgs e)
        {
            c.connect();
            DataSet data = new DataSet();
            string query = "SELECT ExportBillID, ExportDate, SUM (price) AS total_price FROM ExportBill GROUP BY ExportBillID, ExportDate";
            // Tạo một đối tượng SqlConnection
            // Tạo một đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand(query, c.conn);
            // Gán giá trị cho thuộc tính Connection của SqlCommand
            cmd.Connection = c.conn;
            // Tạo một đối tượng SqlDataAdapter bằng cách truyền vào đối tượng SqlCommand
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            DataTable data2 = new DataTable();
            string query2 = "SELECT ExportBillID From ExportBill";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            comboBox1.DataSource = data2;
            comboBox1.DisplayMember = "ExportBillID";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của comboBox1
            string exportBillID = comboBox1.Text;
            // Kiểm tra giá trị có rỗng hay không
            if (string.IsNullOrEmpty(exportBillID))
            {
                // Hiển thị thông báo yêu cầu nhập giá trị
                MessageBox.Show("Vui lòng chọn hoặc nhập mã hóa đơn xuất!");
                return;
            }
            // Khởi tạo đối tượng SqlConnection
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    c.connect();
                    string sql = "SELECT * FROM ExportBill WHERE ExportBillID = @ExportBillID";
                    SqlCommand cmd2 = new SqlCommand(sql, c.conn);
                    cmd2.Parameters.AddWithValue("@ExportBillID", exportBillID);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            c.connect();
            DataSet data = new DataSet();
            string query = "SELECT ExportBillID, ExportDate, SUM (price) AS total_price FROM ExportBill GROUP BY ExportBillID, ExportDate";
            // Tạo một đối tượng SqlConnection
            // Tạo một đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand(query, c.conn);
            // Gán giá trị cho thuộc tính Connection của SqlCommand
            cmd.Connection = c.conn;
            // Tạo một đối tượng SqlDataAdapter bằng cách truyền vào đối tượng SqlCommand
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }
    }
}
