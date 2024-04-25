using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Student
    {
        DAL_Student s;

        public BUS_Student(string SID, string name, string hometown, string dateofbirth, float GPA)
        {
            s = new DAL_Student(SID, name, hometown, dateofbirth, GPA);
        }

        public void addQuery()
        {
            s.addQuery();
        }

        public void updateQuery()
        {
            s.updateQuery();
        }

        public void deleteQuery() {
            s.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return s.selectQuery();
        }

        public string getSID()
        {
            DataTable tb = s.getStudentDesc();
            if (tb.Rows.Count > 0)
            {
                string res = tb.Rows[0][0].ToString();
                int stt = int.Parse(res.Substring(2, 3)) + 1;
                if (stt < 10)
                    res = "SO00" + stt.ToString();
                else if (stt < 100)
                    res = "SO0" + stt.ToString();
                else
                    res = "SO" + stt.ToString();
                return res;
            }
            else
            {
                return "SO001";
            }
        }
    }
}
