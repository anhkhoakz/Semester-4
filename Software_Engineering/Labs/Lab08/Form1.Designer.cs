namespace Lab08
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
            label4 = new Label();
            txtFun = new TextBox();
            Name = new Label();
            txtName = new TextBox();
            S = new Label();
            txtSup = new TextBox();
            label1 = new Label();
            txtPID = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            bPrint = new Button();
            bCancel = new Button();
            bSave = new Button();
            bEdit = new Button();
            bDel = new Button();
            bAdd = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFun);
            groupBox1.Controls.Add(Name);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(S);
            groupBox1.Controls.Add(txtSup);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1194, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Project Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 114);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 7;
            label4.Text = "Funding";
            // 
            // txtFun
            // 
            txtFun.Location = new Point(765, 111);
            txtFun.Name = "txtFun";
            txtFun.Size = new Size(389, 39);
            txtFun.TabIndex = 6;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(633, 50);
            Name.Name = "Name";
            Name.Size = new Size(78, 32);
            Name.TabIndex = 5;
            Name.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(765, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 39);
            txtName.TabIndex = 4;
            // 
            // S
            // 
            S.AutoSize = true;
            S.Location = new Point(33, 114);
            S.Name = "S";
            S.Size = new Size(126, 32);
            S.TabIndex = 3;
            S.Text = "Supervisor";
            // 
            // txtSup
            // 
            txtSup.Location = new Point(165, 107);
            txtSup.Name = "txtSup";
            txtSup.Size = new Size(368, 39);
            txtSup.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 50);
            label1.Name = "label1";
            label1.Size = new Size(117, 32);
            label1.TabIndex = 1;
            label1.Text = "Project ID";
            // 
            // txtPID
            // 
            txtPID.Location = new Point(165, 43);
            txtPID.Name = "txtPID";
            txtPID.Size = new Size(368, 39);
            txtPID.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bPrint);
            groupBox2.Controls.Add(bCancel);
            groupBox2.Controls.Add(bSave);
            groupBox2.Controls.Add(bEdit);
            groupBox2.Controls.Add(bDel);
            groupBox2.Controls.Add(bAdd);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1194, 111);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Functions";
            // 
            // bPrint
            // 
            bPrint.Location = new Point(873, 47);
            bPrint.Name = "bPrint";
            bPrint.Size = new Size(183, 46);
            bPrint.TabIndex = 8;
            bPrint.Text = "Print Preview";
            bPrint.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(717, 47);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(150, 46);
            bCancel.TabIndex = 7;
            bCancel.Text = "Cancel";
            bCancel.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            bSave.Location = new Point(561, 47);
            bSave.Name = "bSave";
            bSave.Size = new Size(150, 46);
            bSave.TabIndex = 6;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            bEdit.Location = new Point(405, 47);
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(150, 46);
            bEdit.TabIndex = 5;
            bEdit.Text = "Edit";
            bEdit.UseVisualStyleBackColor = true;
            // 
            // bDel
            // 
            bDel.Location = new Point(249, 47);
            bDel.Name = "bDel";
            bDel.Size = new Size(150, 46);
            bDel.TabIndex = 4;
            bDel.Text = "Delete";
            bDel.UseVisualStyleBackColor = true;
            // 
            // bAdd
            // 
            bAdd.Location = new Point(93, 47);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(150, 46);
            bAdd.TabIndex = 3;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 335);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1194, 578);
            dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 925);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtPID;
        private Label S;
        private TextBox txtSup;
        private Label label4;
        private TextBox txtFun;
        private Label Name;
        private TextBox txtName;
        private Button bSave;
        private Button bEdit;
        private Button bDel;
        private Button bAdd;
        private Button bPrint;
        private Button bCancel;
    }
}
