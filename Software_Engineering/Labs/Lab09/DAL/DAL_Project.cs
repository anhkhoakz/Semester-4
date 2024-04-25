using DTO;
using System.Data;

namespace DAL
{
    public class DAL_Project
    {
        DTO_Project s;

        public DAL_Project(string SID, string PID, string internshipPlace, int distance, float result)
        {
            s = new DTO_Project(SID, PID, internshipPlace, distance, result);
        }

        public void addQuery()
        {
            string query = "INSERT INTO StudentProject values ('" + s._SID + "', " + s._PID + ", N'" + s._INTERNSHIPPLACE + ", " + s._DISTANCE + ", " + s._RESULT + ")";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE StudentProject SET internshipPlace = N'" + s._INTERNSHIPPLACE + ", " + s._DISTANCE + ", " + s._RESULT + " WHERE studentID = '" + s._SID + "' AND projectID = '" + s._PID + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM StudentProject WHERE studentID = '" + s._SID + "' AND projectID = '" + s._PID + "'";
            Connection.actionQuery(query);
        }
        public DataTable selectQuery()
        {
            string s = "SELECT * FROM StudentProject";
            return Connection.selectQuery(s);
        }
    }
}
