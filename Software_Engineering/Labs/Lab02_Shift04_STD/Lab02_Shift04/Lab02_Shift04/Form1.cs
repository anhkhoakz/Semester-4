using System.Data;
using System.Data.SqlClient;

namespace Lab02_Shift04
{
    public partial class Form1 : Form
    {
        private string s;
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
            // string s = "initial catalog = Internship_Management; data source = localhost; integrated security = true";
            String s = "server = 172.20.10.2; database = Internship_Management; uid = sa; pwd = Gt24AUzfUpJZ2PKh6eZx";

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

    }


}
