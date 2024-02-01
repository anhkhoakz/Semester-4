namespace Lab1_F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public void formload()
        {
            initGRD();
            readFile("student.txt");
            enable(grp1, false);
            bSUA.Enabled = false;
            bXOA.Enabled = false;
            bLUU.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formload();
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

        private void bHUY_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void grd_Click(object sender, EventArgs e)
        {
            if(grd.CurrentRow  != grd.Rows[grd.Rows.Count-1])
            {
                txtMSSV.Text = grd.CurrentRow.Cells[0].Value.ToString();
                txtHT.Text = grd.CurrentRow.Cells[1].Value.ToString();
                cbQQ.Text = grd.CurrentRow.Cells[2].Value.ToString();
                dpNS.Text = General.convertDMY2YMD(grd.CurrentRow.Cells[3].Value.ToString());
                txtHL.Text = grd.CurrentRow.Cells[4].Value.ToString();

                bXOA.Enabled = true;
                bSUA.Enabled = true;
            }

        }

        private void bSUA_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtMSSV.Enabled = false;

            bLUU.Enabled = true;
            txtHT.Focus();
        }

        private void bXOA_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete this student?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                grd.Rows.Remove(grd.CurrentRow);
                StreamWriter sw = new StreamWriter("student.txt");
                for(int i = 0; i<grd.Rows.Count - 1; i++)
                {
                    sw.WriteLine(grd.Rows[i].Cells[0].Value.ToString() + "\t" + grd.Rows[i].Cells[1].Value.ToString() + "\t" + grd.Rows[i].Cells[2].Value.ToString() + "\t" + grd.Rows[i].Cells[3].Value.ToString() + "\t" + grd.Rows[i].Cells[4 ].Value.ToString());
                }
                sw.Close();
            }
        }
    }
}