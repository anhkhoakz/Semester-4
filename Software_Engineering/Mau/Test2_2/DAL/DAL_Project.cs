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

        public DAL_Project(string phieuID, string docgiaID, string sachID, string ngaymuon, string ngaytra)
        {
            p = new DTO_Project(phieuID, docgiaID, sachID, ngaymuon, ngaytra);
        }

        public void addQuery()
        {
            string query = "INSERT INTO MuonSach (phieuID, docgiaID, ngaymuon) VALUES ('" + p._phieuID + "', '" + p._docgiaID + "', '" + p._ngaymuon + "'); " +
                            "INSERT INTO CTPM (phieuID, sachID, ngaytra) VALUES ('" + p._phieuID + "', '" + p._sachID + "', '" + p._ngaytra + "');";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE MuonSach SET docgiaID = '" + p._docgiaID + "', ngaymuon = '" + p._ngaymuon + "' WHERE phieuID = '" + p._phieuID + "'; " +
                            "UPDATE CTPM SET sachID = '" + p._sachID + "', ngaytra = '" + p._ngaytra + "' WHERE phieuID = '" + p._phieuID + "';";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT MuonSach.phieuID AS 'Mã phiếu', MuonSach.docgiaID AS 'Mã người mượn', CTPM.sachID AS 'Mã sách', Book.tensach AS 'Tên sách', MuonSach.ngaymuon AS 'Ngày mượn', CTPM.ngaytra AS 'Ngày trả' FROM MuonSach JOIN CTPM ON MuonSach.phieuID = CTPM.phieuID JOIN Sach ON CTPM.sachID = Sach.sachID";
            return Connection.selectQuery(s);
        }

        //get Datatable desc order
        public DataTable getphieuDESC()
        {
            string s = "select top 1 phieuID from CTPM order by phieuID desc";
            return Connection.selectQuery(s);
        }
    }
}