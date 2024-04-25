namespace Lab10
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
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            groupBox2 = new GroupBox();
            txtSEARCH = new TextBox();
            label1 = new Label();
            bSEARCH = new Button();
            bPDF = new Button();
            bCANCEL = new Button();
            bSAVE = new Button();
            bEDIT = new Button();
            bDELETE = new Button();
            bAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtAN = new TextBox();
            txtQT = new TextBox();
            txtBN = new TextBox();
            txtBID = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(10, 467);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(1264, 386);
            groupBox3.TabIndex = 6;
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
            grd.Size = new Size(1245, 350);
            grd.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSEARCH);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(bSEARCH);
            groupBox2.Controls.Add(bPDF);
            groupBox2.Controls.Add(bCANCEL);
            groupBox2.Controls.Add(bSAVE);
            groupBox2.Controls.Add(bEDIT);
            groupBox2.Controls.Add(bDELETE);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(14, 211);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(1261, 246);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Functions";
            // 
            // txtSEARCH
            // 
            txtSEARCH.Location = new Point(448, 67);
            txtSEARCH.Margin = new Padding(5);
            txtSEARCH.Name = "txtSEARCH";
            txtSEARCH.Size = new Size(311, 39);
            txtSEARCH.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 74);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 7;
            label1.Text = "Find by book name";
            // 
            // bSEARCH
            // 
            bSEARCH.Location = new Point(785, 56);
            bSEARCH.Margin = new Padding(5);
            bSEARCH.Name = "bSEARCH";
            bSEARCH.Size = new Size(156, 64);
            bSEARCH.TabIndex = 6;
            bSEARCH.Text = "Find";
            bSEARCH.UseVisualStyleBackColor = true;
            // 
            // bPDF
            // 
            bPDF.Location = new Point(965, 155);
            bPDF.Margin = new Padding(5);
            bPDF.Name = "bPDF";
            bPDF.Size = new Size(156, 64);
            bPDF.TabIndex = 5;
            bPDF.Text = "Print PDF";
            bPDF.UseVisualStyleBackColor = true;
            // 
            // bCANCEL
            // 
            bCANCEL.Location = new Point(800, 155);
            bCANCEL.Margin = new Padding(5);
            bCANCEL.Name = "bCANCEL";
            bCANCEL.Size = new Size(156, 64);
            bCANCEL.TabIndex = 4;
            bCANCEL.Text = "Cancel";
            bCANCEL.UseVisualStyleBackColor = true;
            // 
            // bSAVE
            // 
            bSAVE.Location = new Point(634, 155);
            bSAVE.Margin = new Padding(5);
            bSAVE.Name = "bSAVE";
            bSAVE.Size = new Size(156, 64);
            bSAVE.TabIndex = 3;
            bSAVE.Text = "Save";
            bSAVE.UseVisualStyleBackColor = true;
            // 
            // bEDIT
            // 
            bEDIT.Location = new Point(468, 155);
            bEDIT.Margin = new Padding(5);
            bEDIT.Name = "bEDIT";
            bEDIT.Size = new Size(156, 64);
            bEDIT.TabIndex = 2;
            bEDIT.Text = "Edit";
            bEDIT.UseVisualStyleBackColor = true;
            // 
            // bDELETE
            // 
            bDELETE.Location = new Point(302, 155);
            bDELETE.Margin = new Padding(5);
            bDELETE.Name = "bDELETE";
            bDELETE.Size = new Size(156, 64);
            bDELETE.TabIndex = 1;
            bDELETE.Text = "Delete";
            bDELETE.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(136, 155);
            bAdd.Margin = new Padding(5);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(156, 64);
            bAdd.TabIndex = 0;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(659, 58);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 10;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 124);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 9;
            label2.Text = "Book name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 58);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 8;
            label5.Text = "Book ID";
            // 
            // txtAN
            // 
            txtAN.Location = new Point(756, 56);
            txtAN.Margin = new Padding(5);
            txtAN.Name = "txtAN";
            txtAN.Size = new Size(272, 39);
            txtAN.TabIndex = 15;
            // 
            // txtQT
            // 
            txtQT.Location = new Point(756, 117);
            txtQT.Margin = new Padding(5);
            txtQT.Name = "txtQT";
            txtQT.Size = new Size(272, 39);
            txtQT.TabIndex = 14;
            // 
            // txtBN
            // 
            txtBN.Location = new Point(232, 122);
            txtBN.Margin = new Padding(5);
            txtBN.Name = "txtBN";
            txtBN.Size = new Size(269, 39);
            txtBN.TabIndex = 13;
            // 
            // txtBID
            // 
            txtBID.Location = new Point(232, 56);
            txtBID.Margin = new Padding(5);
            txtBID.Name = "txtBID";
            txtBID.Size = new Size(269, 39);
            txtBID.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 125);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 11;
            label4.Text = "Quantity";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAN);
            groupBox1.Controls.Add(txtQT);
            groupBox1.Controls.Add(txtBN);
            groupBox1.Controls.Add(txtBID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(1261, 197);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 869);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private DataGridView grd;
        private GroupBox groupBox2;
        private TextBox txtSEARCH;
        private Label label1;
        private Button bSEARCH;
        private Button bPDF;
        private Button bCANCEL;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDELETE;
        private Button bAdd;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtAN;
        private TextBox txtQT;
        private TextBox txtBN;
        private TextBox txtBID;
        private Label label4;
        private GroupBox groupBox1;
    }
}
