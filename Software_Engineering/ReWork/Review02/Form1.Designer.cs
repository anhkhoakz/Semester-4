namespace Review02
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
            grp1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            grp2 = new GroupBox();
            grd = new DataGridView();
            grp1.SuspendLayout();
            grp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(button2);
            grp1.Controls.Add(button1);
            grp1.Location = new Point(14, 14);
            grp1.Margin = new Padding(5);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(5);
            grp1.Size = new Size(1037, 117);
            grp1.TabIndex = 2;
            grp1.TabStop = false;
            grp1.Text = "Chức năng";
            // 
            // button2
            // 
            button2.Location = new Point(626, 42);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(223, 46);
            button2.TabIndex = 1;
            button2.Text = "Mã phiếu mượn";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(102, 42);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(327, 46);
            button1.TabIndex = 0;
            button1.Text = "Ngày mượn <= Ngày trả";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // grp2
            // 
            grp2.Controls.Add(grd);
            grp2.Location = new Point(14, 160);
            grp2.Margin = new Padding(5);
            grp2.Name = "grp2";
            grp2.Padding = new Padding(5);
            grp2.Size = new Size(1037, 494);
            grp2.TabIndex = 3;
            grp2.TabStop = false;
            grp2.Text = "Danh sách";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(10, 42);
            grd.Margin = new Padding(5);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.Size = new Size(1017, 443);
            grd.TabIndex = 0;
            grd.CellContentClick += grd_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 664);
            Controls.Add(grp1);
            Controls.Add(grp2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grp1.ResumeLayout(false);
            grp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp1;
        private Button button2;
        private Button button1;
        private GroupBox grp2;
        private DataGridView grd;
    }
}
