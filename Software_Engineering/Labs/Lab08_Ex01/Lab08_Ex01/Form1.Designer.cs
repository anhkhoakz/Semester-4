namespace Lab08_Ex01
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
            groupBox2 = new GroupBox();
            label1 = new Label();
            cbQQ = new ComboBox();
            bTATCA = new Button();
            bXEMIN = new Button();
            grd = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bXEMIN);
            groupBox1.Controls.Add(bTATCA);
            groupBox1.Controls.Add(cbQQ);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 94);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(grd);
            groupBox2.Location = new Point(12, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 326);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sinh viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Quê quán";
            // 
            // cbQQ
            // 
            cbQQ.FormattingEnabled = true;
            cbQQ.Location = new Point(89, 41);
            cbQQ.Name = "cbQQ";
            cbQQ.Size = new Size(383, 28);
            cbQQ.TabIndex = 1;
            // 
            // bTATCA
            // 
            bTATCA.Location = new Point(478, 41);
            bTATCA.Name = "bTATCA";
            bTATCA.Size = new Size(143, 28);
            bTATCA.TabIndex = 2;
            bTATCA.Text = "Tất cả";
            bTATCA.UseVisualStyleBackColor = true;
            // 
            // bXEMIN
            // 
            bXEMIN.Location = new Point(627, 41);
            bXEMIN.Name = "bXEMIN";
            bXEMIN.Size = new Size(143, 28);
            bXEMIN.TabIndex = 3;
            bXEMIN.Text = "Xem in";
            bXEMIN.UseVisualStyleBackColor = true;
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(764, 300);
            grd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button bXEMIN;
        private Button bTATCA;
        private ComboBox cbQQ;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView grd;
    }
}
