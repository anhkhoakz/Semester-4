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

        public BUS_Project(string maphieumuon, string madocgia, string masach, string ngaymuon, string ngaytra)
        {
            p = new DAL_Project(maphieumuon, madocgia, masach, ngaymuon, ngaytra);
            
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }

        public string phieumuonID()
        {
            string currentDate = DateTime.Now.ToString("ddMMyyyy");

               DataTable tb = p.getphieuDESC();

            if (tb.Rows.Count > 0)
            {
                string phieuCuoi = tb.Rows[tb.Rows.Count - 1][0].ToString();

                string ngayCuoi = phieuCuoi.Split('-')[0];

                if (ngayCuoi != currentDate)
                {
                    return currentDate + "-001";
                }
                else
                {
                    int stt = int.Parse(lastSlipID.Split('-')[1]) + 1;
                    return currentDate + "-" + stt.ToString("D3");
                }
            }
            else
            {
                return currentDate + "-001";
            }
        }
    }
}
