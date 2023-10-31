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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            textId = new TextBox();
            button6 = new Button();
            button2 = new Button();
            textphantram = new TextBox();
            textName = new TextBox();
            button1 = new Button();
            texrdonvi = new ComboBox();
            label4 = new Label();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1063, 695);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkMagenta;
            button4.Location = new Point(884, 552);
            button4.Name = "button4";
            button4.Size = new Size(122, 37);
            button4.TabIndex = 29;
            button4.Text = "ORDER PAGE";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textId);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textphantram);
            panel2.Controls.Add(textName);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(texrdonvi);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(43, 461);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 167);
            panel2.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkMagenta;
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(449, 71);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 38;
            label6.Text = "Percents";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCyan;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkMagenta;
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(448, 16);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 37;
            label5.Text = "Currency";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightCyan;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkMagenta;
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(17, 71);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 36;
            label3.Text = "ProductName";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textId
            // 
            textId.Location = new Point(146, 13);
            textId.Margin = new Padding(5);
            textId.Name = "textId";
            textId.Size = new Size(253, 27);
            textId.TabIndex = 35;
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkMagenta;
            button6.Location = new Point(399, 121);
            button6.Name = "button6";
            button6.Size = new Size(89, 31);
            button6.TabIndex = 30;
            button6.Text = "UPDATE";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkMagenta;
            button2.Location = new Point(241, 121);
            button2.Name = "button2";
            button2.Size = new Size(89, 31);
            button2.TabIndex = 27;
            button2.Text = "INSERT";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textphantram
            // 
            textphantram.Location = new Point(543, 68);
            textphantram.Margin = new Padding(5);
            textphantram.Name = "textphantram";
            textphantram.Size = new Size(253, 27);
            textphantram.TabIndex = 34;
            // 
            // textName
            // 
            textName.Location = new Point(146, 68);
            textName.Margin = new Padding(5);
            textName.Name = "textName";
            textName.Size = new Size(253, 27);
            textName.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.Lavender;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkMagenta;
            button1.Location = new Point(566, 121);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 26;
            button1.Text = "DELETE";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // texrdonvi
            // 
            texrdonvi.FormattingEnabled = true;
            texrdonvi.Items.AddRange(new object[] { "Bo", "Cai" });
            texrdonvi.Location = new Point(543, 13);
            texrdonvi.Margin = new Padding(5);
            texrdonvi.Name = "texrdonvi";
            texrdonvi.Size = new Size(253, 28);
            texrdonvi.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkMagenta;
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(17, 16);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 2;
            label4.Text = "ProductID";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lavender;
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkMagenta;
            button5.Location = new Point(884, 475);
            button5.Name = "button5";
            button5.Size = new Size(122, 37);
            button5.TabIndex = 23;
            button5.Text = "SALE PAGE";
            button5.TextAlign = ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Thistle;
            dataGridView1.Location = new Point(43, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = Color.DarkMagenta;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.DarkMagenta;
            dataGridViewCellStyle4.SelectionBackColor = Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = Color.DarkMagenta;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(963, 335);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.BackColor = Color.LightCyan;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkMagenta;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1063, 39);
            label1.TabIndex = 0;
            label1.Text = "INSTORAGE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Depot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(panel1);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Depot";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
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
        private Button button2;
        private Button button1;
        private Label label4;
        private Button button5;
        private Button button6;
        private ComboBox texrdonvi;
        private ComboBox comboBox1;
        private TextBox textName;
        private TextBox textphantram;
        private TextBox textId;
        private Label label3;
        private Label label6;
        private Label label5;
    }
}