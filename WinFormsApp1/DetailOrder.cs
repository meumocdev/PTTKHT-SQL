﻿using System;
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
    public partial class DetailOrder : Form
    {
        public DetailOrder()
        {
            InitializeComponent();
            load();

        }
        string supplierID;

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
            DataTable dt = Red("Select * from DetailOrder");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void loadOrderDetail(string ma)
        {
            // Sử dụng biến toàn cục supplierID trong câu lệnh SQL
            DataTable dt = Red("Select * from DetailOrder where DetailOrder.ShippmentID='" + ma + "' AND DetailOrder.SupplierID='" + supplierID + "'");
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
        }




        //mở kết nối với database

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            DetailIp Detail = new DetailIp();
            Detail.Show();
            this.Hide();
        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Depot Dp = new Depot();
            Dp.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            supplierID = SupplierID.Text;
            string querydetail = "INSERT INTO DetailOrder(ShippmentID,SupplierID,ProductID,AmountOrder) VALUES('" + ShippmentID.Text + "','" + SupplierID.Text + "','" + productid.Text + "'," + Convert.ToInt32(AmountOrder.Text) + ")";
            Exe(querydetail);
            loadOrderDetail(ShippmentID.Text);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            orders o = new orders();
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "UPDATE DetailOrder SET AmountOrder = " + Convert.ToInt32(AmountOrder.Text) + "  WHERE ShippmentID = '" + ShippmentID.Text + "' AND SupplierID = '" + SupplierID.Text + "' AND ProductID = '" + productid.Text + "'";
            Exe(query);
            load();
        }
        ConnectData c = new ConnectData();
        private void button5_Click_1(object sender, EventArgs e)
        {
            string query = "DELETE FROM DetailOrder WHERE ShippmentID = '" + ShippmentID.Text + "' AND SupplierID = '" + SupplierID.Text + "' AND ProductID = '" + productid.Text + "'";
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
    }
}

