namespace Lab2_Ca4
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
            this.grd = new System.Windows.Forms.DataGridView();
            this.dpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbHT = new System.Windows.Forms.ComboBox();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSAVE = new System.Windows.Forms.Button();
            this.bEDIT = new System.Windows.Forms.Button();
            this.bDEL = new System.Windows.Forms.Button();
            this.bADD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bPRINT = new System.Windows.Forms.Button();
            this.grp2 = new System.Windows.Forms.GroupBox();
            this.bCANCEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp3 = new System.Windows.Forms.GroupBox();
            this.grp1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.grp2.SuspendLayout();
            this.grp3.SuspendLayout();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(11, 33);
            this.grd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 62;
            this.grd.RowTemplate.Height = 25;
            this.grd.Size = new System.Drawing.Size(734, 363);
            this.grd.TabIndex = 0;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellContentClick);
            this.grd.Click += new System.EventHandler(this.grd_Click);
            // 
            // dpDOB
            // 
            this.dpDOB.Location = new System.Drawing.Point(449, 70);
            this.dpDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpDOB.Name = "dpDOB";
            this.dpDOB.Size = new System.Drawing.Size(290, 31);
            this.dpDOB.TabIndex = 3;
            // 
            // cbHT
            // 
            this.cbHT.FormattingEnabled = true;
            this.cbHT.Items.AddRange(new object[] {
            "Hà Nội",
            "Sài Gòn"});
            this.cbHT.Location = new System.Drawing.Point(127, 75);
            this.cbHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHT.Name = "cbHT";
            this.cbHT.Size = new System.Drawing.Size(221, 33);
            this.cbHT.TabIndex = 2;
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(514, 27);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(221, 31);
            this.txtFN.TabIndex = 1;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(127, 123);
            this.txtGPA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(221, 31);
            this.txtGPA.TabIndex = 4;
            // 
            // txtSID
            // 
            this.txtSID.AcceptsReturn = true;
            this.txtSID.Location = new System.Drawing.Point(127, 27);
            this.txtSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(221, 31);
            this.txtSID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fullname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "GPA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "DOB";
            // 
            // bSAVE
            // 
            this.bSAVE.Location = new System.Drawing.Point(383, 27);
            this.bSAVE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSAVE.Name = "bSAVE";
            this.bSAVE.Size = new System.Drawing.Size(97, 50);
            this.bSAVE.TabIndex = 1;
            this.bSAVE.Text = "Save";
            this.bSAVE.UseVisualStyleBackColor = true;
            this.bSAVE.Click += new System.EventHandler(this.bSAVE_Click);
            // 
            // bEDIT
            // 
            this.bEDIT.Location = new System.Drawing.Point(277, 27);
            this.bEDIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bEDIT.Name = "bEDIT";
            this.bEDIT.Size = new System.Drawing.Size(97, 50);
            this.bEDIT.TabIndex = 3;
            this.bEDIT.Text = "Edit";
            this.bEDIT.UseVisualStyleBackColor = true;
            this.bEDIT.Click += new System.EventHandler(this.bEDIT_Click);
            // 
            // bDEL
            // 
            this.bDEL.Location = new System.Drawing.Point(171, 27);
            this.bDEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDEL.Name = "bDEL";
            this.bDEL.Size = new System.Drawing.Size(97, 50);
            this.bDEL.TabIndex = 2;
            this.bDEL.Text = "Delete";
            this.bDEL.UseVisualStyleBackColor = true;
            this.bDEL.Click += new System.EventHandler(this.bDEL_Click);
            // 
            // bADD
            // 
            this.bADD.Location = new System.Drawing.Point(66, 27);
            this.bADD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bADD.Name = "bADD";
            this.bADD.Size = new System.Drawing.Size(97, 50);
            this.bADD.TabIndex = 0;
            this.bADD.Text = "Add";
            this.bADD.UseVisualStyleBackColor = true;
            this.bADD.Click += new System.EventHandler(this.bADD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hometown";
            // 
            // bPRINT
            // 
            this.bPRINT.Location = new System.Drawing.Point(594, 27);
            this.bPRINT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bPRINT.Name = "bPRINT";
            this.bPRINT.Size = new System.Drawing.Size(97, 50);
            this.bPRINT.TabIndex = 5;
            this.bPRINT.Text = "Print";
            this.bPRINT.UseVisualStyleBackColor = true;
            // 
            // grp2
            // 
            this.grp2.Controls.Add(this.bPRINT);
            this.grp2.Controls.Add(this.bCANCEL);
            this.grp2.Controls.Add(this.bSAVE);
            this.grp2.Controls.Add(this.bEDIT);
            this.grp2.Controls.Add(this.bDEL);
            this.grp2.Controls.Add(this.bADD);
            this.grp2.Location = new System.Drawing.Point(24, 200);
            this.grp2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp2.Name = "grp2";
            this.grp2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp2.Size = new System.Drawing.Size(756, 95);
            this.grp2.TabIndex = 4;
            this.grp2.TabStop = false;
            this.grp2.Text = "Functions";
            // 
            // bCANCEL
            // 
            this.bCANCEL.Location = new System.Drawing.Point(489, 27);
            this.bCANCEL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCANCEL.Name = "bCANCEL";
            this.bCANCEL.Size = new System.Drawing.Size(97, 50);
            this.bCANCEL.TabIndex = 4;
            this.bCANCEL.Text = "Cancel";
            this.bCANCEL.UseVisualStyleBackColor = true;
            this.bCANCEL.Click += new System.EventHandler(this.bCANCEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // grp3
            // 
            this.grp3.Controls.Add(this.grd);
            this.grp3.Location = new System.Drawing.Point(20, 309);
            this.grp3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp3.Name = "grp3";
            this.grp3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp3.Size = new System.Drawing.Size(759, 412);
            this.grp3.TabIndex = 5;
            this.grp3.TabStop = false;
            this.grp3.Text = "Student\'s list";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.dpDOB);
            this.grp1.Controls.Add(this.cbHT);
            this.grp1.Controls.Add(this.txtFN);
            this.grp1.Controls.Add(this.txtGPA);
            this.grp1.Controls.Add(this.txtSID);
            this.grp1.Controls.Add(this.label2);
            this.grp1.Controls.Add(this.label5);
            this.grp1.Controls.Add(this.label4);
            this.grp1.Controls.Add(this.label3);
            this.grp1.Controls.Add(this.label1);
            this.grp1.Location = new System.Drawing.Point(24, 14);
            this.grp1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1.Name = "grp1";
            this.grp1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp1.Size = new System.Drawing.Size(753, 180);
            this.grp1.TabIndex = 3;
            this.grp1.TabStop = false;
            this.grp1.Text = "Student information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 745);
            this.Controls.Add(this.grp2);
            this.Controls.Add(this.grp3);
            this.Controls.Add(this.grp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.grp2.ResumeLayout(false);
            this.grp3.ResumeLayout(false);
            this.grp1.ResumeLayout(false);
            this.grp1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grd;
        private DateTimePicker dpDOB;
        private ComboBox cbHT;
        private TextBox txtFN;
        private TextBox txtGPA;
        private TextBox txtSID;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button bSAVE;
        private Button bEDIT;
        private Button bDEL;
        private Button bADD;
        private Label label3;
        private Button bPRINT;
        private GroupBox grp2;
        private Button bCANCEL;
        private Label label1;
        private GroupBox grp3;
        private GroupBox grp1;
    }
}