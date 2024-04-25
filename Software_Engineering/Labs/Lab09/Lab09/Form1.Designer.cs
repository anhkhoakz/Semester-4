namespace Lab09
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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbSID = new ComboBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            grd = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbSID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1148, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Information";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(817, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 39);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(694, 99);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 8;
            label4.Text = "GPA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(817, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 39);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(176, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 39);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 46);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 4;
            label3.Text = "Project ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 99);
            label2.Name = "label2";
            label2.Size = new Size(164, 32);
            label2.TabIndex = 3;
            label2.Text = "Student name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 1;
            label1.Text = "Student ID";
            // 
            // cbSID
            // 
            cbSID.FormattingEnabled = true;
            cbSID.Location = new Point(176, 46);
            cbSID.Name = "cbSID";
            cbSID.Size = new Size(240, 40);
            cbSID.TabIndex = 0;
            cbSID.SelectedIndexChanged += cbSID_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(18, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1142, 99);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Functions";
            // 
            // button2
            // 
            button2.Location = new Point(621, 38);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "Print PDF";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(395, 38);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Show all";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(grd);
            groupBox3.Location = new Point(18, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1142, 467);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // grd
            // 
            grd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd.Location = new Point(6, 38);
            grd.Name = "grd";
            grd.RowHeadersWidth = 82;
            grd.RowTemplate.Height = 41;
            grd.Size = new Size(1130, 423);
            grd.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 754);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbSID;
        private Label label3;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private GroupBox groupBox3;
        private DataGridView grd;
    }
}
