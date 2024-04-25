namespace GUI
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
            ngayTRA = new DateTimePicker();
            label7 = new Label();
            ngayMuon = new DateTimePicker();
            txtBID = new TextBox();
            txtRD = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            bTICKET = new Button();
            bSHOW = new Button();
            bBORROW = new Button();
            bADD = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ngayTRA);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ngayMuon);
            groupBox1.Controls.Add(txtBID);
            groupBox1.Controls.Add(txtRD);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(546, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Phiếu mượn";
            // 
            // ngayTRA
            // 
            ngayTRA.Location = new Point(196, 135);
            ngayTRA.Name = "ngayTRA";
            ngayTRA.Size = new Size(242, 27);
            ngayTRA.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 140);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 15;
            label7.Text = "Ngày trả";
            // 
            // ngayMuon
            // 
            ngayMuon.Location = new Point(196, 89);
            ngayMuon.Name = "ngayMuon";
            ngayMuon.Size = new Size(242, 27);
            ngayMuon.TabIndex = 14;
            // 
            // txtBID
            // 
            txtBID.Location = new Point(327, 30);
            txtBID.Name = "txtBID";
            txtBID.Size = new Size(111, 27);
            txtBID.TabIndex = 13;
            // 
            // txtRD
            // 
            txtRD.Location = new Point(113, 29);
            txtRD.Name = "txtRD";
            txtRD.Size = new Size(111, 27);
            txtRD.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 94);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày mượn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 32);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 10;
            label5.Text = "Mã sách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 33);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Mã độc giả";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bADD);
            groupBox2.Controls.Add(bBORROW);
            groupBox2.Controls.Add(bTICKET);
            groupBox2.Controls.Add(bSHOW);
            groupBox2.Location = new Point(564, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(254, 208);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(12, 219);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(806, 323);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 26);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.RowTemplate.Height = 29;
            grd.Size = new Size(794, 295);
            grd.TabIndex = 0;
            // 
            // bTICKET
            // 
            bTICKET.Location = new Point(62, 157);
            bTICKET.Name = "bTICKET";
            bTICKET.Size = new Size(138, 39);
            bTICKET.TabIndex = 13;
            bTICKET.Text = "Danh sách Phiếu";
            bTICKET.UseVisualStyleBackColor = true;
            // 
            // bSHOW
            // 
            bSHOW.Location = new Point(62, 112);
            bSHOW.Name = "bSHOW";
            bSHOW.Size = new Size(138, 39);
            bSHOW.TabIndex = 12;
            bSHOW.Text = "DS Mượn";
            bSHOW.UseVisualStyleBackColor = true;
            // 
            // bBORROW
            // 
            bBORROW.Location = new Point(62, 67);
            bBORROW.Name = "bBORROW";
            bBORROW.Size = new Size(138, 39);
            bBORROW.TabIndex = 11;
            bBORROW.Text = "Mượn";
            bBORROW.UseVisualStyleBackColor = true;
            // 
            // bADD
            // 
            bADD.Location = new Point(62, 25);
            bADD.Name = "bADD";
            bADD.Size = new Size(138, 39);
            bADD.TabIndex = 14;
            bADD.Text = "Tạo phiếu";
            bADD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 550);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView grd;
        private DateTimePicker ngayTRA;
        private Label label7;
        private DateTimePicker ngayMuon;
        private TextBox txtBID;
        private TextBox txtRD;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button bTICKET;
        private Button bSHOW;
        private Button bBORROW;
        private Button bADD;
    }
}