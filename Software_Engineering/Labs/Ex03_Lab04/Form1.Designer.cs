namespace Ex03_Lab04
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
            fileSystemWatcher1 = new FileSystemWatcher();
            groupBox1 = new GroupBox();
            bPDF = new Button();
            bAll = new Button();
            cbHT = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            grd = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(bPDF);
            groupBox1.Controls.Add(bAll);
            groupBox1.Controls.Add(cbHT);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 337);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm kết quả thực tập";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // bPDF
            // 
            bPDF.Location = new Point(785, 140);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(173, 45);
            bPDF.TabIndex = 3;
            bPDF.Text = "To PDF";
            bPDF.UseVisualStyleBackColor = true;
            // 
            // bAll
            // 
            bAll.Location = new Point(785, 61);
            bAll.Name = "bAll";
            bAll.Size = new Size(173, 54);
            bAll.TabIndex = 2;
            bAll.Text = "Show All";
            bAll.UseVisualStyleBackColor = true;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Location = new Point(284, 71);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(310, 44);
            cbHT.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 73);
            label1.Name = "label1";
            label1.Size = new Size(192, 36);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(22, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 565);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student List";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(-241, 41);
            grd.Name = "grd";
            grd.RowHeadersWidth = 82;
            grd.Size = new Size(1199, 515);
            grd.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(1070, 247);
            button3.Name = "button3";
            button3.Size = new Size(182, 45);
            button3.TabIndex = 12;
            button3.Text = "KP > 100tr";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1070, 183);
            button2.Name = "button2";
            button2.Size = new Size(182, 45);
            button2.TabIndex = 11;
            button2.Text = "KP < 100tr";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1070, 126);
            button1.Name = "button1";
            button1.Size = new Size(182, 45);
            button1.TabIndex = 9;
            button1.Text = "KP < 10tr";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(310, 44);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 140);
            label2.Name = "label2";
            label2.Size = new Size(82, 36);
            label2.TabIndex = 4;
            label2.Text = "Đề tài";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(284, 202);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(310, 44);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 204);
            label3.Name = "label3";
            label3.Size = new Size(211, 36);
            label3.TabIndex = 6;
            label3.Text = "Chủ nhiệm đề tài";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 1065);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private GroupBox groupBox1;
        private Button bPDF;
        private Button bAll;
        private ComboBox cbHT;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView grd;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
    }
}
