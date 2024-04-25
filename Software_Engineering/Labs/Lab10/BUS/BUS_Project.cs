using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Project
    {
        DAL_Project p;

        public BUS_Project(string sachID, string tenSach, string tacGia, int soLuong)
        {
            p = new DAL_Project(sachID, tenSach, tacGia, soLuong);
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

        public string getSachID()
        {
            DataTable dt = p.getSachDESC();

            if (dt.Rows.Count > 0)
            {
                string res = dt.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(1)) + 1;
                if (stt < 10)
                    res = "S00" + stt.ToString();
                else if (stt < 100)
                    res = "S0" + stt.ToString();
                else
                    res = "S" + stt.ToString();
                return res;
            }
            else
            {
                return "S001";
            }
        }
    }
}
