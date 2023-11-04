using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Import : Form
    {
        public Import()
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
            DataTable dt = Red("SELECT E.ShippmentID,E.SupplierID, E.OrderDate, SUM(D.PriceOrder) AS TotalPriceOrder FROM Import AS E INNER JOIN DetailImport AS D ON E.ShippmentID = D.ShippmentID GROUP BY E.ShippmentID, E.SupplierID, E.OrderDate");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT E.ShippmentID,E.SupplierID, E.OrderDate, SUM(D.PriceOrder) AS TotalPriceOrder FROM Import AS E INNER JOIN DetailImport AS D ON E.ShippmentID = D.ShippmentID GROUP BY E.ShippmentID, E.SupplierID, E.OrderDate");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            string sql = "Select distinct ShippmentID From DetailImport";
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sql, con);
            da2.Fill(dt2);
            ShippmentID.DataSource = dt2;
            ShippmentID.DisplayMember = "ShippmentID";
            ShippmentID.ValueMember = "ShippmentID";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*            DataGridViewRow row = new DataGridViewRow();
                        row = dataGridView1.Rows[e.RowIndex];
                        ShippmentID.Text = Convert.ToString(row.Cells["ShippmentID"].Value);
                        suppliID.Text = Convert.ToString(row.Cells["SupplierID"].Value);*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*            string query = "UPDATE Import SET ShippmentID = " + ShippmentID.Text + "  WHERE SupplierID = '" + suppliID.Text + "'";
                        Exe(query);
                        load();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa!");
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string shippmentID = dataGridView1.SelectedRows[0].Cells["ShippmentID"].Value.ToString();
                using (SqlConnection conn = new SqlConnection())
                {
                    try
                    {
                        c.connect();
                        string sql = "DELETE FROM Import WHERE ShippmentID = @ShippmentID";
                        SqlCommand cmd = new SqlCommand(sql, c.conn);
                        cmd.Parameters.AddWithValue("@ShippmentID", shippmentID);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            load();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "ShippmentID", "*" + textBox1.Text + "*");
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu chg = new Menu();
            chg.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Menu chg = new Menu();
            chg.Show();
            this.Hide();
        }
        int tat = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            tat = 1;
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string shippmentID = ShippmentID.Text;
            if (string.IsNullOrEmpty(shippmentID))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập mã hóa đơn xuất!");
                return;
            }
            using (SqlConnection conn = new SqlConnection())
            {
                try
                {
                    c.connect();
                    string sql = "SELECT * FROM DetailImport WHERE ShippmentID = @ShippmentID";
                    SqlCommand cmd2 = new SqlCommand(sql, c.conn);
                    cmd2.Parameters.AddWithValue("@ShippmentID", shippmentID);
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

        private void orders_Load(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT E.ShippmentID,E.SupplierID, E.OrderDate, SUM(D.PriceOrder) AS TotalPriceOrder FROM Import AS E INNER JOIN DetailImport AS D ON E.ShippmentID = D.ShippmentID GROUP BY E.ShippmentID, E.SupplierID, E.OrderDate");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }


            string sql = "Select distinct ShippmentID From DetailImport";
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sql, con);
            da2.Fill(dt2);
            ShippmentID.DataSource = dt2;
            ShippmentID.DisplayMember = "ShippmentID";
            ShippmentID.ValueMember = "ShippmentID";
        }
    }
}
