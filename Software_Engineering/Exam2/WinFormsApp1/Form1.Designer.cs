namespace WinFormsApp1
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
            bADD = new Button();
            bBORROW = new Button();
            bTICKET = new Button();
            bSHOW = new Button();
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox4.SuspendLayout();
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
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(950, 261);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // ngayTRA
            // 
            ngayTRA.Location = new Point(331, 195);
            ngayTRA.Margin = new Padding(5);
            ngayTRA.Name = "ngayTRA";
            ngayTRA.Size = new Size(391, 39);
            ngayTRA.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 200);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 32);
            label7.TabIndex = 15;
            label7.Text = "Return date";
            // 
            // ngayMuon
            // 
            ngayMuon.Location = new Point(331, 121);
            ngayMuon.Margin = new Padding(5);
            ngayMuon.Name = "ngayMuon";
            ngayMuon.Size = new Size(391, 39);
            ngayMuon.TabIndex = 14;
            // 
            // txtBID
            // 
            txtBID.Location = new Point(611, 42);
            txtBID.Margin = new Padding(5);
            txtBID.Name = "txtBID";
            txtBID.Size = new Size(178, 39);
            txtBID.TabIndex = 13;
            // 
            // txtRD
            // 
            txtRD.Location = new Point(264, 40);
            txtRD.Margin = new Padding(5);
            txtRD.Name = "txtRD";
            txtRD.Size = new Size(178, 39);
            txtRD.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 128);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 32);
            label6.TabIndex = 11;
            label6.Text = "Borrow date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 47);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 10;
            label5.Text = "Book ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 49);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 9;
            label4.Text = "Reader ID";
            // 
            // bADD
            // 
            bADD.Location = new Point(10, 40);
            bADD.Margin = new Padding(5);
            bADD.Name = "bADD";
            bADD.Size = new Size(224, 62);
            bADD.TabIndex = 14;
            bADD.Text = "Create ticket";
            bADD.UseVisualStyleBackColor = true;
            bADD.Click += bADD_Click;
            // 
            // bBORROW
            // 
            bBORROW.Location = new Point(244, 40);
            bBORROW.Margin = new Padding(5);
            bBORROW.Name = "bBORROW";
            bBORROW.Size = new Size(224, 62);
            bBORROW.TabIndex = 11;
            bBORROW.Text = "Borrow";
            bBORROW.UseVisualStyleBackColor = true;
            bBORROW.Click += bBORROW_Click;
            // 
            // bTICKET
            // 
            bTICKET.Location = new Point(712, 40);
            bTICKET.Margin = new Padding(5);
            bTICKET.Name = "bTICKET";
            bTICKET.Size = new Size(224, 62);
            bTICKET.TabIndex = 13;
            bTICKET.Text = "Ticket list";
            bTICKET.UseVisualStyleBackColor = true;
            bTICKET.Click += bTICKET_Click;
            // 
            // bSHOW
            // 
            bSHOW.Location = new Point(478, 40);
            bSHOW.Margin = new Padding(5);
            bSHOW.Name = "bSHOW";
            bSHOW.Size = new Size(224, 62);
            bSHOW.TabIndex = 12;
            bSHOW.Text = "Borrow list";
            bSHOW.UseVisualStyleBackColor = true;
            bSHOW.Click += bSHOW_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(14, 413);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(950, 534);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "List";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(10, 42);
            grd.Margin = new Padding(5);
            grd.Name = "grd";
            grd.RowHeadersWidth = 51;
            grd.RowTemplate.Height = 29;
            grd.Size = new Size(926, 472);
            grd.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(bTICKET);
            groupBox4.Controls.Add(bBORROW);
            groupBox4.Controls.Add(bSHOW);
            groupBox4.Controls.Add(bADD);
            groupBox4.Location = new Point(14, 285);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(950, 120);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Functions";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 958);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker ngayTRA;
        private Label label7;
        private DateTimePicker ngayMuon;
        private TextBox txtBID;
        private TextBox txtRD;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button bADD;
        private Button bBORROW;
        private Button bTICKET;
        private Button bSHOW;
        private GroupBox groupBox3;
        private DataGridView grd;
        private GroupBox groupBox4;
    }
}
