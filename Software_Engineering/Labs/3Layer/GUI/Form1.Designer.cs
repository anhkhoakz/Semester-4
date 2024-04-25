namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.txtSup = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.grd = new System.Windows.Forms.DataGridView();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.txtSup);
            this.groupBox1.Controls.Add(this.S);
            this.groupBox1.Controls.Add(this.txtPID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(1104, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Information";
            // 
            // txtFun
            // 
            this.txtFun.Location = new System.Drawing.Point(640, 88);
            this.txtFun.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFun.Name = "txtFun";
            this.txtFun.Size = new System.Drawing.Size(430, 31);
            this.txtFun.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Funding";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(640, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(430, 31);
            this.txtName.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(510, 42);
            this.Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(68, 25);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // txtSup
            // 
            this.txtSup.Location = new System.Drawing.Point(152, 85);
            this.txtSup.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSup.Name = "txtSup";
            this.txtSup.Size = new System.Drawing.Size(306, 31);
            this.txtSup.TabIndex = 1;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(22, 88);
            this.S.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(115, 25);
            this.S.TabIndex = 0;
            this.S.Text = "Supervisor";
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(152, 35);
            this.txtPID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(306, 31);
            this.txtPID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bCancel);
            this.groupBox2.Controls.Add(this.bPrint);
            this.groupBox2.Controls.Add(this.bSave);
            this.groupBox2.Controls.Add(this.bEdit);
            this.groupBox2.Controls.Add(this.bDel);
            this.groupBox2.Controls.Add(this.bAdd);
            this.groupBox2.Location = new System.Drawing.Point(32, 187);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(1108, 92);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(706, 31);
            this.bCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(154, 50);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.button5_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(872, 31);
            this.bPrint.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(154, 50);
            this.bPrint.TabIndex = 0;
            this.bPrint.Text = "Print Preview";
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(540, 31);
            this.bSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(154, 50);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(374, 31);
            this.bEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(154, 50);
            this.bEdit.TabIndex = 0;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(208, 31);
            this.bDel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(154, 50);
            this.bDel.TabIndex = 0;
            this.bDel.Text = "Delete";
            this.bDel.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(42, 31);
            this.bAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(154, 50);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Location = new System.Drawing.Point(36, 296);
            this.grd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grd.Name = "grd";
            this.grd.RowHeadersWidth = 82;
            this.grd.Size = new System.Drawing.Size(1098, 479);
            this.grd.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 796);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtSup;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.DataGridView grd;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
    }
}

