namespace Lab1_F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grd = new System.Windows.Forms.DataGridView();
            this.dpNS = new System.Windows.Forms.DateTimePicker();
            this.cbQQ = new System.Windows.Forms.ComboBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bLUU = new System.Windows.Forms.Button();
            this.bSUA = new System.Windows.Forms.Button();
            this.bXOA = new System.Windows.Forms.Button();
            this.bTHEM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bXEMIN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bHUY = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.txtHL = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(11, 27);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 33;
            this.grd.Size = new System.Drawing.Size(880, 323);
            this.grd.TabIndex = 0;
            this.grd.Click += new System.EventHandler(this.grd_Click);
            // 
            // dpNS
            // 
            this.dpNS.Location = new System.Drawing.Point(499, 61);
            this.dpNS.Name = "dpNS";
            this.dpNS.Size = new System.Drawing.Size(390, 31);
            this.dpNS.TabIndex = 3;
            // 
            // cbQQ
            // 
            this.cbQQ.FormattingEnabled = true;
            this.cbQQ.Items.AddRange(new object[] {
            "Saigon",
            "Thanh Hoa",
            "Nghe An",
            "Long An",
            "Quang Ngai"});
            this.cbQQ.Location = new System.Drawing.Point(147, 63);
            this.cbQQ.Name = "cbQQ";
            this.cbQQ.Size = new System.Drawing.Size(230, 33);
            this.cbQQ.TabIndex = 2;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(499, 24);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(391, 31);
            this.txtHT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(147, 24);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(230, 31);
            this.txtMSSV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Học lực";
            // 
            // bLUU
            // 
            this.bLUU.Location = new System.Drawing.Point(489, 16);
            this.bLUU.Name = "bLUU";
            this.bLUU.Size = new System.Drawing.Size(99, 36);
            this.bLUU.TabIndex = 0;
            this.bLUU.Text = "Lưu";
            this.bLUU.UseVisualStyleBackColor = true;
            // 
            // bSUA
            // 
            this.bSUA.Location = new System.Drawing.Point(384, 16);
            this.bSUA.Name = "bSUA";
            this.bSUA.Size = new System.Drawing.Size(99, 36);
            this.bSUA.TabIndex = 0;
            this.bSUA.Text = "Sửa";
            this.bSUA.UseVisualStyleBackColor = true;
            this.bSUA.Click += new System.EventHandler(this.bSUA_Click);
            // 
            // bXOA
            // 
            this.bXOA.Location = new System.Drawing.Point(279, 16);
            this.bXOA.Name = "bXOA";
            this.bXOA.Size = new System.Drawing.Size(99, 36);
            this.bXOA.TabIndex = 0;
            this.bXOA.Text = "Xóa";
            this.bXOA.UseVisualStyleBackColor = true;
            this.bXOA.Click += new System.EventHandler(this.bXOA_Click);
            // 
            // bTHEM
            // 
            this.bTHEM.Location = new System.Drawing.Point(174, 15);
            this.bTHEM.Name = "bTHEM";
            this.bTHEM.Size = new System.Drawing.Size(99, 36);
            this.bTHEM.TabIndex = 0;
            this.bTHEM.Text = "Thêm";
            this.bTHEM.UseVisualStyleBackColor = true;
            this.bTHEM.Click += new System.EventHandler(this.bTHEM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quê quán";
            // 
            // bXEMIN
            // 
            this.bXEMIN.Location = new System.Drawing.Point(699, 16);
            this.bXEMIN.Name = "bXEMIN";
            this.bXEMIN.Size = new System.Drawing.Size(99, 36);
            this.bXEMIN.TabIndex = 0;
            this.bXEMIN.Text = "Xem in";
            this.bXEMIN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bXEMIN);
            this.groupBox2.Controls.Add(this.bHUY);
            this.groupBox2.Controls.Add(this.bLUU);
            this.groupBox2.Controls.Add(this.bSUA);
            this.groupBox2.Controls.Add(this.bXOA);
            this.groupBox2.Controls.Add(this.bTHEM);
            this.groupBox2.Location = new System.Drawing.Point(11, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 52);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bHUY
            // 
            this.bHUY.Location = new System.Drawing.Point(594, 16);
            this.bHUY.Name = "bHUY";
            this.bHUY.Size = new System.Drawing.Size(99, 36);
            this.bHUY.TabIndex = 0;
            this.bHUY.Text = "Hủy";
            this.bHUY.UseVisualStyleBackColor = true;
            this.bHUY.Click += new System.EventHandler(this.bHUY_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grd);
            this.groupBox3.Location = new System.Drawing.Point(9, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(899, 357);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sinh viên";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.txtHL);
            this.grp1.Controls.Add(this.dpNS);
            this.grp1.Controls.Add(this.cbQQ);
            this.grp1.Controls.Add(this.txtHT);
            this.grp1.Controls.Add(this.label4);
            this.grp1.Controls.Add(this.label2);
            this.grp1.Controls.Add(this.txtMSSV);
            this.grp1.Controls.Add(this.label5);
            this.grp1.Controls.Add(this.label3);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Location = new System.Drawing.Point(12, 12);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(896, 144);
            this.grp1.TabIndex = 3;
            this.grp1.TabStop = false;
            this.grp1.Text = "Thông tin sinh viên";
            // 
            // txtHL
            // 
            this.txtHL.Location = new System.Drawing.Point(148, 103);
            this.txtHL.Name = "txtHL";
            this.txtHL.Size = new System.Drawing.Size(229, 31);
            this.txtHL.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 595);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grd;
        private DateTimePicker dpNS;
        private ComboBox cbQQ;
        private TextBox txtHT;
        private Label label4;
        private Label label2;
        private TextBox txtMSSV;
        private Label label5;
        private Button bLUU;
        private Button bSUA;
        private Button bXOA;
        private Button bTHEM;
        private Label label3;
        private Button bXEMIN;
        private GroupBox groupBox2;
        private Button bHUY;
        private Label label1;
        private GroupBox groupBox3;
        private GroupBox grp1;
        private MaskedTextBox txtHL;
    }
}