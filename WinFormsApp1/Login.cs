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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.PasswordChar = '\0';
            }
            // Nếu không, che khuất chúng bằng ký tự *
            else
            {
                textBox4.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sell sll = new Sell();
            sll.Show();
            this.Hide();
        }



        private void button2_Leave(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Nếu người dùng chọn Yes, thoát ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        int tat = 0;
        private void button2_Click(object sender, EventArgs e)
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
