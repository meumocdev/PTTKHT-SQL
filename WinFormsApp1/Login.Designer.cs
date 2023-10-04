namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-8, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 364);
            panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.DarkMagenta;
            checkBox1.Location = new Point(262, 204);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 33;
            checkBox1.Text = "Hiển thị mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 94);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 23);
            textBox1.TabIndex = 31;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(122, 249);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(137, 38);
            button3.TabIndex = 24;
            button3.Text = "Đăng nhập";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(358, 249);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(137, 38);
            button2.TabIndex = 23;
            button2.Text = "Thoát";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.Leave += button2_Leave;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = Color.DarkMagenta;
            textBox4.Location = new Point(200, 159);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(318, 21);
            textBox4.TabIndex = 22;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.Location = new Point(57, 90);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 30;
            label3.Text = "Tên đăng nhập";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.Location = new Point(57, 158);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 19;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(203, 22);
            label1.Name = "label1";
            label1.Size = new Size(187, 33);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 319);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button3;
        private Button button2;
        private TextBox textBox4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}