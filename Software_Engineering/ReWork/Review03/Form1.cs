using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace Review03
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
            string s = "server = 172.16.97.108; database = InternshipManagement; uid = SA; pwd = Gt24AUzfUpJZ2PKh6eZx";


            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        void formload()
        {
            showGRD();
            enable(GroupBox2, false);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            dk = 0;
        }

        public void enable(GroupBox grp, bool b)
        {
            GroupBox2.Enabled = b;
        }

        public void showGRD()
        {
            string sql = "select * from CTPM";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd2.DataSource = tb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maSachMuon.Text) || string.IsNullOrWhiteSpace(maDGMuon.Text) ||
                string.IsNullOrWhiteSpace(ngayMuon.Text) || string.IsNullOrWhiteSpace(ngayTRA.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin mượn sách!");
                return;
            }

            if (ngayTRA.Value < ngayMuon.Value)
            {
                MessageBox.Show("Ngày trả phải lớn hơn hoặc bằng ngày mượn!");
                return;
            }

            DateTime a = ngayMuon.Value;
            string aAsString = a.ToString("yyyyMMdd");
            // string maPhieuMuon = TaoMaPhieuMoi(aAsString);

            string insertMuonSachSql = "INSERT INTO MuonSach (MaPhieuMuon, MaDocGia, NgayMuon) " +
                                       "VALUES (@MaPhieuMuon, @MaDocGia, @NgayMuon)";
            cm = new SqlCommand(insertMuonSachSql, cn);
            cm.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
            cm.Parameters.AddWithValue("@MaDocGia", maDGMuon.Text);
            cm.Parameters.AddWithValue("@NgayMuon", ngayMuon.Value);

            cm.ExecuteNonQuery();

            string insertChiTietPhieuMuonSql = "INSERT INTO ChiTietPhieuMuon (MaPhieuMuon, MaSach, NgayTra) " +
                                       "VALUES (@MaPhieuMuon, @MaSach, @NgayTra)";
            cm = new SqlCommand(insertChiTietPhieuMuonSql, cn);
            cm.Parameters.AddWithValue("@MaPhieuMuon", maPhieuMuon);
            cm.Parameters.AddWithValue("@MaSach", maSachMuon.Text);
            cm.Parameters.AddWithValue("@NgayTra", ngayTRA.Value);

            cm.ExecuteNonQuery();

            MessageBox.Show("Thêm thông tin mượn sách thành công!");
            formload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from MuonSach";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd2.DataSource = tb;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from CTPM";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            grd2.DataSource = tb;
        }
    }


}
