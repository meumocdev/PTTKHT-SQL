namespace WinFormsApp1
{
    partial class Form2
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
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            radioButton1 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 43);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 8;
            label1.Text = "Tài khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 131);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(274, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleName = "";
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(227, 169);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hiển thị mật khẩu";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(141, 206);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 12;
            button1.Text = "Quay về";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(306, 206);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 13;
            button2.Text = "Đăng kí";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 86);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(274, 23);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 131);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 15;
            label3.Text = "Nhập lại mật khẩu";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 276);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private TextBox textBox3;
        private Label label3;
    }
}