namespace Review
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
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            bPDF = new Button();
            bTim = new Button();
            bLuu = new Button();
            bSua = new Button();
            bXoa = new Button();
            bThem = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1142, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(738, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 39);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(738, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(334, 39);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(398, 39);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(619, 96);
            label4.Name = "label4";
            label4.Size = new Size(110, 32);
            label4.TabIndex = 5;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(619, 38);
            label3.Name = "label3";
            label3.Size = new Size(86, 32);
            label3.TabIndex = 4;
            label3.Text = "Tác giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 96);
            label2.Name = "label2";
            label2.Size = new Size(106, 32);
            label2.TabIndex = 3;
            label2.Text = "Tên sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 2;
            label1.Text = "Mã sách";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bPDF);
            groupBox2.Controls.Add(bTim);
            groupBox2.Controls.Add(bLuu);
            groupBox2.Controls.Add(bSua);
            groupBox2.Controls.Add(bXoa);
            groupBox2.Controls.Add(bThem);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1142, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bPDF
            // 
            bPDF.Location = new Point(881, 78);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(150, 46);
            bPDF.TabIndex = 8;
            bPDF.Text = "Xuất PDF";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click;
            // 
            // bTim
            // 
            bTim.Location = new Point(725, 78);
            bTim.Name = "bTim";
            bTim.Size = new Size(150, 46);
            bTim.TabIndex = 7;
            bTim.Text = "Tìm kiếm";
            bTim.UseVisualStyleBackColor = true;
            bTim.Click += bTim_Click;
            // 
            // bLuu
            // 
            bLuu.Location = new Point(569, 78);
            bLuu.Name = "bLuu";
            bLuu.Size = new Size(150, 46);
            bLuu.TabIndex = 6;
            bLuu.Text = "Lưu";
            bLuu.UseVisualStyleBackColor = true;
            bLuu.Click += bLuu_Click;
            // 
            // bSua
            // 
            bSua.Location = new Point(413, 78);
            bSua.Name = "bSua";
            bSua.Size = new Size(150, 46);
            bSua.TabIndex = 5;
            bSua.Text = "Sửa";
            bSua.UseVisualStyleBackColor = true;
            bSua.Click += bSua_Click;
            // 
            // bXoa
            // 
            bXoa.Location = new Point(257, 78);
            bXoa.Name = "bXoa";
            bXoa.Size = new Size(150, 46);
            bXoa.TabIndex = 4;
            bXoa.Text = "Xoá";
            bXoa.UseVisualStyleBackColor = true;
            bXoa.Click += bXoa_Click;
            // 
            // bThem
            // 
            bThem.Location = new Point(101, 78);
            bThem.Name = "bThem";
            bThem.Size = new Size(150, 46);
            bThem.TabIndex = 3;
            bThem.Text = "Thêm";
            bThem.UseVisualStyleBackColor = true;
            bThem.Click += bThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 403);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1142, 473);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 888);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Button bPDF;
        private Button bTim;
        private Button bLuu;
        private Button bSua;
        private Button bXoa;
        private Button bThem;
    }
}
