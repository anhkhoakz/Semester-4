namespace Lab01
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
            txtHL = new MaskedTextBox();
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            label1 = new Label();
            bHUY = new Button();
            groupBox2 = new GroupBox();
            bXEMIN = new Button();
            bLUU = new Button();
            bSUA = new Button();
            bXOA = new Button();
            bTHEM = new Button();
            label3 = new Label();
            grp1 = new GroupBox();
            dpNS = new DateTimePicker();
            cbQQ = new ComboBox();
            txtHT = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtMSSV = new TextBox();
            label5 = new Label();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHL
            // 
            txtHL.Location = new Point(192, 132);
            txtHL.Margin = new Padding(4);
            txtHL.Name = "txtHL";
            txtHL.Size = new Size(296, 39);
            txtHL.TabIndex = 4;
            txtHL.MaskInputRejected += txtHL_MaskInputRejected;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(9, 295);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(1169, 457);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách sinh viên";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(14, 35);
            grd.Margin = new Padding(4);
            grd.Name = "grd";
            grd.RowHeadersWidth = 62;
            grd.RowTemplate.Height = 33;
            grd.Size = new Size(1144, 413);
            grd.TabIndex = 0;
            grd.Click += grd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "Mã số sinh viên";
            // 
            // bHUY
            // 
            bHUY.Location = new Point(772, 20);
            bHUY.Margin = new Padding(4);
            bHUY.Name = "bHUY";
            bHUY.Size = new Size(129, 46);
            bHUY.TabIndex = 0;
            bHUY.Text = "Hủy";
            bHUY.UseVisualStyleBackColor = true;
            bHUY.Click += bHUY_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bXEMIN);
            groupBox2.Controls.Add(bHUY);
            groupBox2.Controls.Add(bLUU);
            groupBox2.Controls.Add(bSUA);
            groupBox2.Controls.Add(bXOA);
            groupBox2.Controls.Add(bTHEM);
            groupBox2.Location = new Point(11, 217);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(1165, 67);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // bXEMIN
            // 
            bXEMIN.Location = new Point(909, 20);
            bXEMIN.Margin = new Padding(4);
            bXEMIN.Name = "bXEMIN";
            bXEMIN.Size = new Size(129, 46);
            bXEMIN.TabIndex = 0;
            bXEMIN.Text = "Xem in";
            bXEMIN.UseVisualStyleBackColor = true;
            // 
            // bLUU
            // 
            bLUU.Location = new Point(636, 20);
            bLUU.Margin = new Padding(4);
            bLUU.Name = "bLUU";
            bLUU.Size = new Size(129, 46);
            bLUU.TabIndex = 0;
            bLUU.Text = "Lưu";
            bLUU.UseVisualStyleBackColor = true;
            bLUU.Click += bLUU_Click;
            // 
            // bSUA
            // 
            bSUA.Location = new Point(499, 20);
            bSUA.Margin = new Padding(4);
            bSUA.Name = "bSUA";
            bSUA.Size = new Size(129, 46);
            bSUA.TabIndex = 0;
            bSUA.Text = "Sửa";
            bSUA.UseVisualStyleBackColor = true;
            bSUA.Click += bSUA_Click;
            // 
            // bXOA
            // 
            bXOA.Location = new Point(363, 20);
            bXOA.Margin = new Padding(4);
            bXOA.Name = "bXOA";
            bXOA.Size = new Size(129, 46);
            bXOA.TabIndex = 0;
            bXOA.Text = "Xóa";
            bXOA.UseVisualStyleBackColor = true;
            bXOA.Click += bXOA_Click;
            // 
            // bTHEM
            // 
            bTHEM.Location = new Point(226, 19);
            bTHEM.Margin = new Padding(4);
            bTHEM.Name = "bTHEM";
            bTHEM.Size = new Size(129, 46);
            bTHEM.TabIndex = 0;
            bTHEM.Text = "Thêm";
            bTHEM.UseVisualStyleBackColor = true;
            bTHEM.Click += bTHEM_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 82);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 0;
            label3.Text = "Quê quán";
            // 
            // grp1
            // 
            grp1.Controls.Add(txtHL);
            grp1.Controls.Add(dpNS);
            grp1.Controls.Add(cbQQ);
            grp1.Controls.Add(txtHT);
            grp1.Controls.Add(label4);
            grp1.Controls.Add(label2);
            grp1.Controls.Add(txtMSSV);
            grp1.Controls.Add(label5);
            grp1.Controls.Add(label3);
            grp1.Controls.Add(label1);
            grp1.Location = new Point(13, 13);
            grp1.Margin = new Padding(4);
            grp1.Name = "grp1";
            grp1.Padding = new Padding(4);
            grp1.Size = new Size(1165, 184);
            grp1.TabIndex = 6;
            grp1.TabStop = false;
            grp1.Text = "Thông tin sinh viên";
            // 
            // dpNS
            // 
            dpNS.Location = new Point(649, 78);
            dpNS.Margin = new Padding(4);
            dpNS.Name = "dpNS";
            dpNS.Size = new Size(506, 39);
            dpNS.TabIndex = 3;
            // 
            // cbQQ
            // 
            cbQQ.FormattingEnabled = true;
            cbQQ.Items.AddRange(new object[] { "Saigon", "Thanh Hoa", "Nghe An", "Long An", "Quang Ngai" });
            cbQQ.Location = new Point(191, 81);
            cbQQ.Margin = new Padding(4);
            cbQQ.Name = "cbQQ";
            cbQQ.Size = new Size(298, 40);
            cbQQ.TabIndex = 2;
            // 
            // txtHT
            // 
            txtHT.Location = new Point(649, 31);
            txtHT.Margin = new Padding(4);
            txtHT.Name = "txtHT";
            txtHT.Size = new Size(507, 39);
            txtHT.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(513, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 32);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(191, 31);
            txtMSSV.Margin = new Padding(4);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(298, 39);
            txtMSSV.TabIndex = 1;
            txtMSSV.TextChanged += txtMSSV_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 0;
            label5.Text = "Học lực";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 765);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(grp1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox txtHL;
        private GroupBox groupBox3;
        private DataGridView grd;
        private Label label1;
        private Button bHUY;
        private GroupBox groupBox2;
        private Button bXEMIN;
        private Button bLUU;
        private Button bSUA;
        private Button bXOA;
        private Button bTHEM;
        private Label label3;
        private GroupBox grp1;
        private DateTimePicker dpNS;
        private ComboBox cbQQ;
        private TextBox txtHT;
        private Label label4;
        private Label label2;
        private TextBox txtMSSV;
        private Label label5;
    }
}
