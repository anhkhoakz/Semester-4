using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Project
    {
        DAL_Project p;

        public BUS_Project(string masach, string tenSach, string tacGia, int soLuong)
        {
            p = new DAL_Project(masach, tenSach, tacGia, soLuong);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

        public string getmasach()
        {
            DataTable dt = p.getSachDESC();

            if (dt.Rows.Count > 0)
            {
                string lastID = dt.Rows[0][0].ToString();
                int serialNumber = int.Parse(lastID.Substring(1)) + 1;
                string newID = $"S{serialNumber:D3}";
                return newID;
            }
            else
            {
                return "S001";
            }
        }

    }
}
