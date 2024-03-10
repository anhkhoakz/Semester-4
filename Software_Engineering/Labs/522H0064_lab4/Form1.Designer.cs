namespace _522H0064_lab4
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
            groupBox1.Location = new Point(44, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1119, 162);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // bPDF
            // 
            bPDF.Location = new Point(887, 61);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(169, 40);
            bPDF.TabIndex = 3;
            bPDF.Text = "To PDF";
            bPDF.UseVisualStyleBackColor = true;
            bPDF.Click += bPDF_Click;
            // 
            // bAll
            // 
            bAll.Location = new Point(605, 54);
            bAll.Name = "bAll";
            bAll.Size = new Size(161, 48);
            bAll.TabIndex = 2;
            bAll.Text = "Show All";
            bAll.UseVisualStyleBackColor = true;
            bAll.Click += bAll_Click;
            // 
            // cbHT
            // 
            cbHT.FormattingEnabled = true;
            cbHT.Location = new Point(223, 62);
            cbHT.Name = "cbHT";
            cbHT.Size = new Size(288, 40);
            cbHT.TabIndex = 1;
            cbHT.SelectedIndexChanged += cbHT_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 65);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 0;
            label1.Text = "HomeTown";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(44, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1130, 502);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student List";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 38);
            grd.Name = "grd";
            grd.RowHeadersWidth = 82;
            grd.Size = new Size(1113, 458);
            grd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 789);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
        private Label label1;
        private Button bPDF;
        private Button bAll;
        private ComboBox cbHT;
        private GroupBox groupBox2;
        private DataGridView grd;
    }
}
