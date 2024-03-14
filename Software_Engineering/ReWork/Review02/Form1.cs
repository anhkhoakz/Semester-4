using System.Data;
using System.Data.SqlClient;

namespace Review02
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
            showGRD();
            enable(grp1, true);
            button1.Enabled = true;
            button2.Enabled = true;
            dk = 0;
        }

        void formload()
        {
            showGRD();
            enable(grp1, true);
            button1.Enabled = true;
            button2.Enabled = true;
            dk = 0;

        }

        public void showGRD()
        {
            string sql = "select * from CTPM";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {
            grp.Enabled = b;
        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select distinct MuonSach.* from CTPM, MuonSach where ngaymuon <= ngaytra";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
