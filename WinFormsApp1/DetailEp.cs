using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
