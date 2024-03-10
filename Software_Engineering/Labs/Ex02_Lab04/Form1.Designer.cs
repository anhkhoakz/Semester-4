namespace Ex02_Lab04
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            groupBox1.Controls.Add(bPDF);
            groupBox1.Controls.Add(bAll);
            groupBox1.Controls.Add(cbHT);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(47, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 182);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm in ấn đề tài";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // bPDF
            // 
            bPDF.Location = new Point(806, 66);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(182, 45);
            bPDF.TabIndex = 3;
            bPDF.Text = "To PDF";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click;
            // 
            // bAll
            // 
            bAll.Location = new Point(627, 61);
            bAll.Name = "bAll";
            bAll.Size = new Size(173, 54);
            bAll.TabIndex = 2;
            bAll.Text = "Show All";
            bAll.UseVisualStyleBackColor = true;
            bAll.Click += bAll_Click;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Location = new Point(284, 71);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(310, 44);
            cbHT.TabIndex = 1;
            cbHT.SelectedIndexChanged += cbHT_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 73);
            label1.Name = "label1";
            label1.Size = new Size(211, 36);
            label1.TabIndex = 0;
            label1.Text = "Chủ nhiệm đề tài";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(47, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1004, 565);
            groupBox2.TabIndex = 5;
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
            grd.CellContentClick += grd_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(1095, 126);
            button1.Name = "button1";
            button1.Size = new Size(182, 45);
            button1.TabIndex = 4;
            button1.Text = "KP < 10tr";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1095, 183);
            button2.Name = "button2";
            button2.Size = new Size(182, 45);
            button2.TabIndex = 6;
            button2.Text = "KP < 100tr";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1095, 247);
            button3.Name = "button3";
            button3.Size = new Size(182, 45);
            button3.TabIndex = 7;
            button3.Text = "KP > 100tr";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 1065);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
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
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView grd;
        private ComboBox cbHT;
        private Button button1;
        private Button button3;
        private Button button2;
    }
}
