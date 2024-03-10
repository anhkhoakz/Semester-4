namespace Ex01_Lab04
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
            groupBox1.Location = new Point(34, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1205, 182);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // bPDF
            // 
            bPDF.Location = new Point(955, 69);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(182, 45);
            bPDF.TabIndex = 3;
            bPDF.Text = "To PDF";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click_1;
            // 
            // bAll
            // 
            bAll.Location = new Point(652, 61);
            bAll.Name = "bAll";
            bAll.Size = new Size(173, 54);
            bAll.TabIndex = 2;
            bAll.Text = "Show All";
            bAll.UseVisualStyleBackColor = true;
            bAll.Click += bAll_Click_1;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Location = new Point(240, 70);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(310, 44);
            cbHT.TabIndex = 1;
            cbHT.SelectedIndexChanged += cbHT_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 73);
            label1.Name = "label1";
            label1.Size = new Size(144, 36);
            label1.TabIndex = 0;
            label1.Text = "HomeTown";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(34, 390);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1217, 565);
            groupBox2.TabIndex = 3;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 1066);
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
        private ComboBox cbHT;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView grd;
    }
}
