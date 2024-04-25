using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_Project
    {
        DTO_Project p;

        public DAL_Project(string maphieumuon, string madocgia, string masach, string ngaymuon, string ngaytra)
        {
            p = new DTO_Project(maphieumuon, madocgia, masach, ngaymuon, ngaytra);
        }

        public void addQuery()
        {
            string query = "INSERT INTO MuonSach (maphieumuon, madocgia, ngaymuon) VALUES ('" + p._maphieumuon + "', '" + p._madocgia + "', '" + p._ngaymuon + "'); " +
                            "INSERT INTO CTPM (maphieumuon, masach, ngaytra) VALUES ('" + p._maphieumuon + "', '" + p._masach + "', '" + p._ngaytra + "');";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE MuonSach SET madocgia = '" + p._madocgia + "', ngaymuon = '" + p._ngaymuon + "' WHERE maphieumuon = '" + p._maphieumuon + "'; " +
                            "UPDATE CTPM SET masach = '" + p._masach + "', ngaytra = '" + p._ngaytra + "' WHERE maphieumuon = '" + p._maphieumuon + "';";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT MuonSach.maphieumuon AS 'Mã phiếu', MuonSach.madocgia AS 'Mã người mượn', CTPM.masach AS 'Mã sách', Book.tensach AS 'Tên sách', MuonSach.ngaymuon AS 'Ngày mượn', CTPM.ngaytra AS 'Ngày trả' FROM MuonSach JOIN CTPM ON MuonSach.maphieumuon = CTPM.maphieumuon JOIN Sach ON CTPM.masach = Sach.masach";
            return Connection.selectQuery(s);
        }

        //get Datatable desc order
        public DataTable getphieuDESC()
        {
            string s = "select top 1 maphieumuon from CTPM order by maphieumuon desc";
            return Connection.selectQuery(s);
        }
    }
}
