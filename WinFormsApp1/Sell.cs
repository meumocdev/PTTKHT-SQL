using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Menu Dp = new Menu();
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
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);
            comboBox1.DataSource = data;
            comboBox2.DataSource = data;
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductID";
            comboBox2.DisplayMember = "ProductID";
            comboBox2.ValueMember = "ProductName";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                Double ExportPriceItem = Convert.ToDouble(((DataRowView)comboBox2.SelectedItem)["ExportPriceItem"]);
                string ExportPriceItemString = ExportPriceItem.ToString("F2");
                textBox2.Text = ExportPriceItemString;
                string productName = ((DataRowView)comboBox1.SelectedItem)["ProductName"].ToString();
                int index = comboBox2.FindStringExact(productName);
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
            string query = "INSERT INTO DetailBillExport (ExportBillID, ProductID, AmountExport, ExportPriceItem, PriceExport) VALUES (@ExportBillID, @ProductID, @AmountExport, @ExportPriceItem)";
            string exportBillID = textBox3.Text;
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            cmd.CommandText = "Insert_DetailBillExport";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ExportBillID", exportBillID);
            cmd.Parameters.AddWithValue("@ProductID", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@AmountExport", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@ExportPriceItem", decimal.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();

            DataTable data2 = new DataTable();
            string query2 = "SELECT * FROM DetailBillExport";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            dataGridView1.DataSource = data2;

            BindingSource bs = new BindingSource();
            bs.DataSource = data2;
            bs.Filter = "ExportBillID LIKE '" + textBox3.Text + "'";
            dataGridView1.DataSource = bs;
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
            DataTable data4 = new DataTable();
            string id = dataGridView1.CurrentRow.Cells["ProductID"].Value.ToString();
            string exportBillID = textBox3.Text;
            string query4 = "DELETE FROM DetailBillExport WHERE ProductID = @id AND ExportBillID = @ExportBillID";
            SqlCommand cmd4 = new SqlCommand(query4, c.conn);
            cmd4.Parameters.AddWithValue("@id", id);
            cmd4.Parameters.AddWithValue("@ExportBillID", exportBillID);
            cmd4.Connection = c.conn;
            SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
            cmd4.ExecuteNonQuery();
            dataGridView1.Refresh();



            DataTable data2 = new DataTable();
            string query2 = "SELECT * FROM DetailBillExport";
            SqlCommand cmd2 = new SqlCommand(query2, c.conn);
            cmd2.Connection = c.conn;
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            adp2.Fill(data2);
            dataGridView1.DataSource = data2;

            BindingSource bs = new BindingSource();
            bs.DataSource = data2;
            bs.Filter = "ExportBillID LIKE '" + textBox3.Text + "'";
            dataGridView1.DataSource = bs;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            c.connect();
            DataTable data = new DataTable();
            string query = "SELECT e.ExportBillID, e.ExportDate, d.ProductID, d.AmountExport, d.ExportPriceItem, d.PriceExport FROM ExportBill e INNER JOIN DetailBillExport d ON e.ExportBillID = d.ExportBillID";
            SqlCommand cmd = new SqlCommand(query, c.conn);
            cmd.Connection = c.conn;
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(data);

            string exportBillID = textBox3.Text;
            StringBuilder orderContent = new StringBuilder();
            orderContent.AppendLine("ĐƠN BÁN HÀNG");
            orderContent.AppendLine();
            cmd.CommandText = "SELECT ExportBillID, ExportDate FROM ExportBill WHERE ExportBillID = @ExportBillID";
            cmd.Parameters.AddWithValue("@ExportBillID", exportBillID);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    orderContent.AppendLine($"Mã đơn hàng: {reader["ExportBillID"]}");
                    orderContent.AppendLine($"Ngày bán: {reader["ExportDate"]}");
                }
            }
            orderContent.AppendLine();
            orderContent.AppendLine("BẢNG CHI TIẾT ĐƠN HÀNG");
            orderContent.AppendLine("Mã sản phẩm\tSố lượng\tĐơn giá\tThành tiền");
            cmd.CommandText = "SELECT ProductID, AmountExport, ExportPriceItem, PriceExport FROM DetailBillExport WHERE ExportBillID = @ExportBillID";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                decimal totalPriceExport = 0;
                while (reader.Read())
                {
                    orderContent.AppendLine($"{reader["ProductID"]}\t{reader["AmountExport"]}\t{reader["ExportPriceItem"]}\t{reader["PriceExport"]}");
                    totalPriceExport += (decimal)reader["PriceExport"];
                }
                orderContent.AppendLine();
                orderContent.AppendLine($"Tổng tiền: {totalPriceExport}");
            }
            Console.WriteLine(orderContent.ToString());
            using (StreamWriter writer = new StreamWriter(@"D:\HoaDon.txt"))
            {
                writer.Write(orderContent.ToString());
            }
            Process proc = new Process();
            proc.StartInfo.FileName = "notepad.exe";
            proc.StartInfo.Arguments = @"D:\HoaDon.txt";
            proc.Start();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
