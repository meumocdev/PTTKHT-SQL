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
                        string sql2 = "DELETE FROM ExportBill WHERE ExportBillID = @ExportBillID";
                        SqlCommand cmd = new SqlCommand(sql, c.conn);
                        SqlCommand cmd12 = new SqlCommand(sql2, c.conn);
                        cmd.Parameters.AddWithValue("@ExportBillID", exportBillID);
                        cmd12.Parameters.AddWithValue("@ExportBillID", exportBillID);
                        int affectedRows = cmd.ExecuteNonQuery();
                        int affectedRows2 = cmd12.ExecuteNonQuery();
                        if (affectedRows > 0 && affectedRows2 > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            DataSet data = new DataSet();
                            string query = "SELECT D.ExportBillID, E.ExportDate, SUM(D.PriceExport) AS TotalPriceExport FROM DetailBillExport AS D LEFT JOIN ExportBill AS E ON D.ExportBillID = E.ExportBillID GROUP BY D.ExportBillID, E.ExportDate";
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
            if (tat == 0)
            {
                DialogResult DR = MessageBox.Show("Bạn có muốn FormClosing không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DR == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tat = 1;
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
        ConnectData c = new ConnectData();
        private void DetailEp_Load(object sender, EventArgs e)
        {
            c.connect();
            DataSet data = new DataSet();
            string query = "SELECT D.ExportBillID, E.ExportDate, SUM(D.PriceExport) AS TotalPriceExport FROM DetailBillExport AS D LEFT JOIN ExportBill AS E ON D.ExportBillID = E.ExportBillID GROUP BY D.ExportBillID, E.ExportDate";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];

            DataTable data2 = new DataTable();
            string query2 = "SELECT DISTINCT ExportBillID From ExportBill";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            comboBox1.DataSource = data2;
            comboBox1.DisplayMember = "ExportBillID";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string exportBillID = comboBox1.Text;
            if (string.IsNullOrEmpty(exportBillID))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã hóa đơn xuất!");
                return;
            }
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    c.connect();
                    string sql = "SELECT * FROM DetailBillExport WHERE ExportBillID = @ExportBillID";
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
            string query = "SELECT D.ExportBillID, E.ExportDate, SUM(D.PriceExport) AS TotalPriceExport FROM DetailBillExport AS D LEFT JOIN ExportBill AS E ON D.ExportBillID = E.ExportBillID GROUP BY D.ExportBillID, E.ExportDate";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data4 = new DataTable();
            string qt = dataGridView1.CurrentRow.Cells["AmountExport"].Value.ToString();
            string id = dataGridView1.CurrentRow.Cells["ExportBillID"].Value.ToString();
            string pr = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            string query4 = "UPDATE DetailBillExport SET AmountExport = @qt WHERE ExportBillID = @id AND ProductID = @pr";
            SqlCommand cmd4 = new SqlCommand(query4, c.conn);
            cmd4.Parameters.AddWithValue("@qt", qt);
            cmd4.Parameters.AddWithValue("@id", id);
            cmd4.Parameters.AddWithValue("@pr", pr);
            cmd4.Connection = c.conn;
            SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
            cmd4.ExecuteNonQuery();
            dataGridView1.Refresh();
        }
    }
}
