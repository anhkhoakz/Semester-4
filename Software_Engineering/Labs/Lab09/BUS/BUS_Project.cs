using System.Data;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_Project
    {
        DAL_Project s;

        public BUS_Project(string SID, string PID, string internshipPlace, int distance, float result)
        {
            s = new DAL_Project(SID, PID, internshipPlace, distance, result);
        }

        public void addQuery()
        {
            s.addQuery();
        }

        public void updateQuere()
        {
            s.updateQuery();
        }

        public void deleteQuery()
        {
            s.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return s.selectQuery();
        }
    }
}
