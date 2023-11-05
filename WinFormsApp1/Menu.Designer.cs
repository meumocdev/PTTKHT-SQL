namespace WinFormsApp1
{
    partial class Menu
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
            lbl_Role = new Label();
            button4 = new Button();
            label2 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(lbl_Role);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-79, -56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 712);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Role.Location = new Point(110, 81);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new Size(62, 25);
            lbl_Role.TabIndex = 33;
            lbl_Role.Text = "label3";
            lbl_Role.Click += lbl_Role_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(371, 160);
            button4.Name = "button4";
            button4.Size = new Size(123, 35);
            button4.TabIndex = 31;
            button4.Text = "AddPr";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightCyan;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkMagenta;
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(371, 68);
            label2.Name = "label2";
            label2.Size = new Size(128, 42);
            label2.TabIndex = 30;
            label2.Text = "MENU";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button9
            // 
            button9.BackColor = Color.Lavender;
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.DarkMagenta;
            button9.Location = new Point(371, 337);
            button9.Name = "button9";
            button9.Size = new Size(123, 35);
            button9.TabIndex = 29;
            button9.Text = "EXIT";
            button9.TextAlign = ContentAlignment.TopCenter;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Lavender;
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkMagenta;
            button8.Location = new Point(566, 241);
            button8.Name = "button8";
            button8.Size = new Size(123, 35);
            button8.TabIndex = 28;
            button8.Text = "DetailExport";
            button8.TextAlign = ContentAlignment.TopCenter;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(566, 160);
            button7.Name = "button7";
            button7.Size = new Size(123, 35);
            button7.TabIndex = 27;
            button7.Text = "Export";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(371, 241);
            button5.Name = "button5";
            button5.Size = new Size(123, 35);
            button5.TabIndex = 25;
            button5.Text = "LOGIN";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(176, 337);
            button2.Name = "button2";
            button2.Size = new Size(123, 35);
            button2.TabIndex = 23;
            button2.Text = "Depot";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(176, 241);
            button1.Name = "button1";
            button1.Size = new Size(123, 35);
            button1.TabIndex = 22;
            button1.Text = "DetailImport";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(176, 160);
            button3.Name = "button3";
            button3.Size = new Size(123, 35);
            button3.TabIndex = 21;
            button3.Text = "Import";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(411, 27);
            label1.Name = "label1";
            label1.Size = new Size(196, 29);
            label1.TabIndex = 0;
            label1.Text = "ĐƠN BÁN HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 425);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Label label1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button5;
        private Button button2;
        private Button button1;
        private Label label2;
        private Button button4;
        private Label lbl_Role;
    }
}