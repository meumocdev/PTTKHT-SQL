namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleName = "";
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(204, 132);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(120, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hiển thị mật khẩu";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 85);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(274, 23);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(135, 167);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(275, 167);
            button2.Name = "button2";
            button2.Size = new Size(123, 34);
            button2.TabIndex = 6;
            button2.Text = "Đăng kí";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 42);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 88);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 272);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
    }
}