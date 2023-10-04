namespace WinFormsApp1
{
    partial class Depot
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            button3 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Nhacungcap = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Mahang = new DataGridViewTextBoxColumn();
            Tenhang = new DataGridViewTextBoxColumn();
            soluong = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Tongtien = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 521);
            panel1.TabIndex = 1;
            // 
            // button7
            // 
            button7.BackColor = Color.Lavender;
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkMagenta;
            button7.Location = new Point(585, 457);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(123, 30);
            button7.TabIndex = 31;
            button7.Text = "IN";
            button7.TextAlign = ContentAlignment.TopCenter;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkMagenta;
            button6.Location = new Point(757, 457);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(123, 29);
            button6.TabIndex = 30;
            button6.Text = "XÓA";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(757, 339);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(123, 29);
            button4.TabIndex = 29;
            button4.Text = "ĐẶT HÀNG";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(757, 400);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(123, 28);
            button2.TabIndex = 27;
            button2.Text = "THÊM";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(585, 400);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(123, 28);
            button1.TabIndex = 26;
            button1.Text = "SỬA";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(38, 339);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 153);
            panel2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 81);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 32;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(147, 116);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 23);
            comboBox2.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(147, 46);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 23);
            comboBox1.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(147, 7);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 29;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkMagenta;
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(18, 116);
            label6.Name = "label6";
            label6.Size = new Size(90, 16);
            label6.TabIndex = 4;
            label6.Text = "Nhà cung cấp";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Lavender;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkMagenta;
            button3.Location = new Point(402, 73);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(98, 26);
            button3.TabIndex = 28;
            button3.Text = "TÌM KIẾM";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCyan;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkMagenta;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(18, 81);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 3;
            label5.Text = "Tên hàng";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(18, 46);
            label4.Name = "label4";
            label4.Size = new Size(59, 16);
            label4.TabIndex = 2;
            label4.Text = "Mã hàng";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(18, 7);
            label3.Name = "label3";
            label3.Size = new Size(106, 16);
            label3.TabIndex = 1;
            label3.Text = "Ngày nhập hàng";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(585, 339);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(123, 28);
            button5.TabIndex = 23;
            button5.Text = "BÁN HÀNG";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle5.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nhacungcap, Column3, Mahang, Tenhang, soluong, Column1, Tongtien, Column2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle6.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(38, 68);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle7.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle7.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle8.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = Color.DarkMagenta;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(843, 251);
            dataGridView1.TabIndex = 11;
            // 
            // Nhacungcap
            // 
            Nhacungcap.FillWeight = 80F;
            Nhacungcap.HeaderText = "Nhà cung cấp";
            Nhacungcap.MinimumWidth = 6;
            Nhacungcap.Name = "Nhacungcap";
            Nhacungcap.Width = 78;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ngày nhập hàng";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Mahang
            // 
            Mahang.DataPropertyName = "Mahang";
            Mahang.FillWeight = 80F;
            Mahang.HeaderText = "Mã hàng";
            Mahang.MinimumWidth = 6;
            Mahang.Name = "Mahang";
            Mahang.Width = 78;
            // 
            // Tenhang
            // 
            Tenhang.DataPropertyName = "Tenhang";
            Tenhang.FillWeight = 80F;
            Tenhang.HeaderText = "Tên hàng";
            Tenhang.MinimumWidth = 6;
            Tenhang.Name = "Tenhang";
            Tenhang.Width = 78;
            // 
            // soluong
            // 
            soluong.DataPropertyName = "soluong";
            soluong.FillWeight = 80F;
            soluong.HeaderText = "Số lượng nhập";
            soluong.MinimumWidth = 6;
            soluong.Name = "soluong";
            soluong.Width = 78;
            // 
            // Column1
            // 
            Column1.HeaderText = "Số lượng tồn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Tongtien
            // 
            Tongtien.DataPropertyName = "Tongtien";
            Tongtien.FillWeight = 80F;
            Tongtien.HeaderText = "Đơn giá nhập";
            Tongtien.MinimumWidth = 6;
            Tongtien.Name = "Tongtien";
            Tongtien.Width = 78;
            // 
            // Column2
            // 
            Column2.HeaderText = "Đơn giá bán";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCyan;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(402, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 24);
            label1.TabIndex = 0;
            label1.Text = "KHO HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Depot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Depot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button5;
        private DataGridViewTextBoxColumn Nhacungcap;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Mahang;
        private DataGridViewTextBoxColumn Tenhang;
        private DataGridViewTextBoxColumn soluong;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Tongtien;
        private DataGridViewTextBoxColumn Column2;
        private Button button7;
        private Button button6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}