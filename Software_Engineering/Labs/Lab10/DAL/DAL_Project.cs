using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Project
    {
        DTO_Project p;

        public DAL_Project(string masach, string tenSach, string tacGia, int soLuong)
        {
            p = new DTO_Project(masach, tenSach, tacGia, soLuong);
        }

        public void addQuery()
        {
            string query = "insert into Sach values ('" + p._masach + "', N'" + p._tensach + "', N'" + p._tacgia + "', " + p._soluong + ")";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "update Sach set tensach = N'" + p._tensach + "', tacgia = N'" + p._tacgia + "', soluong = " + p._soluong + ")";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "delete from Sach where masach = '" + p._masach + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string s = "select * from Sach";
            return Connection.selectQuery(s);
        }

        //get ASC masach
        public DataTable getSachDESC()
        {
            string s = "select top 1 masach from Sach order by masach desc";
            return Connection.selectQuery(s);
        }
    }
}
