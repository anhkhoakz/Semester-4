namespace Lab01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initGRD();
            readFile("student.txt");
            enable(grp1, false);
            bSUA.Enabled = false;
            bXOA.Enabled = false;
            bLUU.Enabled = false;

        }

        public void formload()
        {
            initGRD();
            readFile("student.txt");
            enable(grp1, false);
            bSUA.Enabled = false;
            bXOA.Enabled = false;
            bLUU.Enabled = false;
        }


        public void initGRD()
        {
            //clear grd
            grd.Columns.Clear();
            grd.Rows.Clear();

            //grdDSUV - tạo header
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Student ID";
            grd.Columns.Add(c1);

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Full name";
            grd.Columns.Add(c2);

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Hometown";
            grd.Columns.Add(c3);

            DataGridViewTextBoxColumn c4 = new DataGridViewTextBoxColumn();
            c4.HeaderText = "DOB";
            grd.Columns.Add(c4);

            DataGridViewTextBoxColumn c5 = new DataGridViewTextBoxColumn();
            c5.HeaderText = "GPA";
            grd.Columns.Add(c5);
        }

        public void readFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string s;
            string[] t;
            int i = 0;
            while (true)
            {
                s = sr.ReadLine();
                if (s is null)
                {
                    break;
                }
                //
                t = s.Split('\t');

                grd.Rows.Add();
                for (int j = 0; j < t.Length; ++j)
                {
                    grd.Rows[i].Cells[j].Value = t[j];

                }
                ++i;

            }

            sr.Close();
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {
            if (grd.CurrentRow != grd.Rows[grd.Rows.Count - 1])
            {
                txtMSSV.Text = grd.CurrentRow.Cells[0].Value.ToString();
                txtHT.Text = grd.CurrentRow.Cells[1].Value.ToString();
                cbQQ.Text = grd.CurrentRow.Cells[2].Value.ToString();
                // dpNS.Text = General.convertDMY2YMD(grd.CurrentRow.Cells[3].Value.ToString());
                txtHL.Text = grd.CurrentRow.Cells[4].Value.ToString();

                bXOA.Enabled = true;
                bSUA.Enabled = true;
            }

        }

        private void bTHEM_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMSSV.Clear();
            txtHT.Clear();
            txtHL.Clear();
            cbQQ.Text = "";
            dpNS.Text = "";
            txtMSSV.Focus();
            bLUU.Enabled = true;
        }

        private void bXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this student?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                grd.Rows.Remove(grd.CurrentRow);
                StreamWriter sw = new StreamWriter("student.txt");
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    sw.WriteLine(grd.Rows[i].Cells[0].Value.ToString() + "\t" + grd.Rows[i].Cells[1].Value.ToString() + "\t" + grd.Rows[i].Cells[2].Value.ToString() + "\t" + grd.Rows[i].Cells[3].Value.ToString() + "\t" + grd.Rows[i].Cells[4].Value.ToString());
                }
                sw.Close();
            }

        }

        private void bSUA_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMSSV.Enabled = false;

            bLUU.Enabled = true;
            txtHT.Focus();
        }

        private void bLUU_Click(object sender, EventArgs e)
        {
            // If all required fields are filled
            if (!string.IsNullOrEmpty(txtMSSV.Text) && !string.IsNullOrEmpty(txtHT.Text) && !string.IsNullOrEmpty(cbQQ.Text) && !string.IsNullOrEmpty(dpNS.Text))
            {
                // Check if the student ID already exists in the grid
                bool isNewEntry = true;
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    if (grd.Rows[i].Cells[0].Value.ToString() == txtMSSV.Text)
                    {
                        isNewEntry = false;
                        // Update existing entry with new information
                        grd.Rows[i].Cells[1].Value = txtHT.Text;
                        grd.Rows[i].Cells[2].Value = cbQQ.Text;
                        grd.Rows[i].Cells[3].Value = dpNS.Text;
                        // You might want to add validation for GPA here
                        break;
                    }
                }

                // If it's a new entry, add it to the grid
                if (isNewEntry)
                {
                    grd.Rows.Add(txtMSSV.Text, txtHT.Text, cbQQ.Text, dpNS.Text, ""); // Assuming GPA is left empty for now
                }

                // Save the updated information to the file
                StreamWriter sw = new StreamWriter("student.txt");
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    sw.WriteLine(grd.Rows[i].Cells[0].Value.ToString() + "\t" + grd.Rows[i].Cells[1].Value.ToString() + "\t" + grd.Rows[i].Cells[2].Value.ToString() + "\t" + grd.Rows[i].Cells[3].Value.ToString() + "\t" + grd.Rows[i].Cells[4].Value.ToString());
                }
                sw.Close();

                // Reset form and disable group box after saving
                formload();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private void bHUY_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void txtHL_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
