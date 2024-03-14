using System.Data;
using System.Data.SqlClient;

namespace Lab02
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "server = 192.168.1.135; database = InternshipManagement; uid = sa; pwd = Gt24AUzfUpJZ2PKh6eZx";

            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        void formload()
        {
            showGRD();
            enable(grp1, false);
            bDEL.Enabled = false;
            bEDIT.Enabled = false;
            bSAVE.Enabled = false;
            dk = 0;
        }
        public void showGRD()
        {
            string sql = "select * from Students";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtSID.Clear();
            txtFN.Clear();
            txtGPA.Clear();
            cbHT.Text = "";
            dpDOB.Text = "";

            txtSID.Focus();
            bSAVE.Enabled = true;
            dk = 1;
        }

        private void bDEL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Students where sid = '" + txtSID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from Students where StudentID = '" + txtSID.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Student exists");
                    txtSID.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Students values ('" + txtSID.Text + "', N'" + txtFN.Text + "', N'" + cbHT.Text + "', '" + dpDOB.Value.ToShortDateString() + "', '" + txtGPA.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Students set name = N'" + txtFN.Text + "', hometown = N'" + cbHT.Text + "', date_of_birth = '" + dpDOB.Value.ToShortDateString() + "', GPA = " + txtGPA.Text + " where StudentID = '" + txtSID.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            enable(grp1, true);
            txtSID.Enabled = false;
            txtFN.Focus();
            bSAVE.Enabled = true;
            dk = 2;
        }
    }
}
