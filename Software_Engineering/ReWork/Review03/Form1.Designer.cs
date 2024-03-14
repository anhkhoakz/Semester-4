namespace Review03
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
            grd2 = new DataGridView();
            grp4 = new GroupBox();
            ngayTRA = new DateTimePicker();
            label7 = new Label();
            ngayMuon = new DateTimePicker();
            maSachMuon = new TextBox();
            maDGMuon = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            GroupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd2).BeginInit();
            grp4.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(grd2);
            groupBox1.Location = new Point(14, 386);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(808, 432);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mượn sách";
            // 
            // grd2
            // 
            grd2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd2.Location = new Point(10, 42);
            grd2.Margin = new Padding(5);
            grd2.Name = "grd2";
            grd2.RowHeadersWidth = 51;
            grd2.RowTemplate.Height = 29;
            grd2.Size = new Size(788, 380);
            grd2.TabIndex = 0;
            // 
            // grp4
            // 
            grp4.Controls.Add(ngayTRA);
            grp4.Controls.Add(label7);
            grp4.Controls.Add(ngayMuon);
            grp4.Controls.Add(maSachMuon);
            grp4.Controls.Add(maDGMuon);
            grp4.Controls.Add(label6);
            grp4.Controls.Add(label5);
            grp4.Controls.Add(label4);
            grp4.Location = new Point(14, 14);
            grp4.Margin = new Padding(5);
            grp4.Name = "grp4";
            grp4.Padding = new Padding(5);
            grp4.Size = new Size(808, 233);
            grp4.TabIndex = 12;
            grp4.TabStop = false;
            grp4.Text = "Mượn sách";
            // 
            // ngayTRA
            // 
            ngayTRA.Location = new Point(198, 166);
            ngayTRA.Margin = new Padding(5);
            ngayTRA.Name = "ngayTRA";
            ngayTRA.Size = new Size(391, 39);
            ngayTRA.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 180);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(105, 32);
            label7.TabIndex = 7;
            label7.Text = "Ngày trả";
            // 
            // ngayMuon
            // 
            ngayMuon.Location = new Point(198, 99);
            ngayMuon.Margin = new Padding(5);
            ngayMuon.Name = "ngayMuon";
            ngayMuon.Size = new Size(391, 39);
            ngayMuon.TabIndex = 5;
            // 
            // maSachMuon
            // 
            maSachMuon.Location = new Point(620, 39);
            maSachMuon.Margin = new Padding(5);
            maSachMuon.Name = "maSachMuon";
            maSachMuon.Size = new Size(178, 39);
            maSachMuon.TabIndex = 4;
            // 
            // maDGMuon
            // 
            maDGMuon.Location = new Point(168, 39);
            maDGMuon.Margin = new Padding(5);
            maDGMuon.Name = "maDGMuon";
            maDGMuon.Size = new Size(211, 39);
            maDGMuon.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 112);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(140, 32);
            label6.TabIndex = 2;
            label6.Text = "Ngày mượn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 42);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 1;
            label5.Text = "Mã sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 42);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 0;
            label4.Text = "Mã độc giả";
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(button3);
            GroupBox2.Controls.Add(button2);
            GroupBox2.Controls.Add(button1);
            GroupBox2.Location = new Point(14, 255);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(808, 123);
            GroupBox2.TabIndex = 11;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Chức năng";
            // 
            // button3
            // 
            button3.Location = new Point(487, 38);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 2;
            button3.Text = "CTPM";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(331, 38);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "DS mượn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(175, 38);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "Mượn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 825);
            Controls.Add(GroupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grp4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd2).EndInit();
            grp4.ResumeLayout(false);
            grp4.PerformLayout();
            GroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView grd2;
        private GroupBox grp4;
        private DateTimePicker ngayTRA;
        private Label label7;
        private DateTimePicker ngayMuon;
        private TextBox maSachMuon;
        private TextBox maDGMuon;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox GroupBox2;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}
