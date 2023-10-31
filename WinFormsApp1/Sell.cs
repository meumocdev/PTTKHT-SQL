using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }
        DataTable data2 = new DataTable();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetailEp Detail = new DetailEp();
            Detail.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Depot Dp = new Depot();
            Dp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        ConnectData c = new ConnectData();
        private void Sell_Load(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "Select * From PRODUCT";
            // Tạo một đối tượng SqlConnection
            // Tạo một đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            comboBox1.DataSource = data;
            comboBox2.DataSource = data;
            // Thiết lập cột hiển thị và cột giá trị cho comboBox1 và comboBox2
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
            comboBox2.DisplayMember = "ProductID";
            comboBox2.ValueMember = "ProductName";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                Double u_price = Convert.ToDouble(((DataRowView)comboBox2.SelectedItem)["u_price"]);
                // Định dạng giá trị thành chuỗi có hai chữ số thập phân
                string u_priceString = u_price.ToString("F2");
                textBox2.Text = u_priceString;
                string productName = ((DataRowView)comboBox1.SelectedItem)["ProductName"].ToString();
                // Tìm vị trí của productName trong danh sách các giá trị của comboBox2
                int index = comboBox2.FindStringExact(productName);
                // Chọn vị trí đó ở comboBox2
                if (index > -1)
                {
                    comboBox2.SelectedIndex = index;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "INSERT INTO ExportBill (ExportBillID,ExportDate, ProductID, ProductName, quantity, u_price, price) VALUES (@ExportBillID,@ExportDate, @ProductID, @ProductName, @quantity, @u_price)";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            // Tạo đối tượng lệnh SqlCommand command = new SqlCommand (sql, connection);
            cmd.CommandText = "Insert_ExportBill";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ExportBillID", textBox3.Text);
            cmd.Parameters.AddWithValue("@ExportDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@ProductName", comboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("@ProductID", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@quantity", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@u_price", decimal.Parse(textBox2.Text));
           // cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();

            DataTable data2 = new DataTable();
            string query2 = "SELECT ExportBillID, ProductName, quantity, u_price FROM ExportBill";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            dataGridView1.DataSource = data2;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "DELETE FROM ExportBill";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }

        /*        private void GetData() {
                    c.connect();
                    DataTable data = new DataTable();
                    string query = "SELECT ExportBillID,ExportDate,ProductID, ProductName, quantity, u_price FROM ExportBill";
                    SqlCommand cmd = new SqlCommand(query, c.conn);
                    cmd.Connection = c.conn;
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(data); }
        */
        private void button5_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "SELECT ExportBillID,ExportDate,ProductID, ProductName, quantity, u_price, price FROM ExportBill";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            StreamWriter sw = new StreamWriter(@"D:\HoaDon.txt");
            sw.WriteLine("ExportBillID\tExportDate\tProductID\tProductName\tquantity\tu_price\tprice");

            string prevExportBillID = "";
            string prevExportDate = "";


            foreach (DataRow row in data.Rows)
            {
                // Lấy giá trị của các cột
                string exportBillID = row["ExportBillID"].ToString();

                string exportDate = row["ExportDate"].ToString();

                string productID = row["ProductID"].ToString();

                string productName = row["ProductName"].ToString();

                string quantity = row["quantity"].ToString();

                string u_price = row["u_price"].ToString();

                string price = row["price"].ToString();

                // Kiểm tra xem giá trị ExportBillID và ExportDate có trùng với hàng trước không
                if (exportBillID == prevExportBillID && exportDate == prevExportDate)
                {
                    // Nếu trùng, chỉ ghi các cột ProductName, quantity, u_price và price
                    sw.Write("\t" + "\t" + productID + "\t" + productName + "\t" + quantity + "\t" + u_price + "\t" + price);
                }
                else
                {
                    // Nếu không trùng, ghi tất cả các cột
                    sw.Write(exportBillID + "\t" + exportDate + "\t" + productID + "\t" + productName + "\t" + quantity + "\t" + u_price + "\t" + price);
                    // Cập nhật lại giá trị của biến prevExportBillID và prevExportDate
                    prevExportBillID = exportBillID;
                    prevExportDate = exportDate;
                }
                // Ghi một dòng mới vào file txt
                sw.WriteLine();
            }
            sw.Close();
            Process proc = new Process();
            proc.StartInfo.FileName = "notepad.exe";
            proc.StartInfo.Arguments = @"D:\HoaDon.txt";
            proc.Start();
        }

    }
}
