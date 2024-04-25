using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_Student
    {
        DTO_Student s;

        public DAL_Student(string SID, string name, string hometown, string dateofbirth, float GPA)
        {
            s = new DTO_Student(SID, name, hometown, dateofbirth, GPA);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Students VALUES ('" + s._StudentID + "', N'" + s._fullname + "', N'" + s._hometown + "', '" + s._dateofbirth + "', '" + s._GPA + ")";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE FROM Students WHERE StudentID = '" + s._StudentID + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Students WHERE StudentID = '" + s._StudentID + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "select * from Students";
            return Connection.selectQuery(query);
        }

        //get database desc order
        public DataTable getStudentDesc()
        {
            string query = "SELECT TOP 1 StudentID FROM Students ORDER BY StudentID DESC";
            return Connection.selectQuery(query);   
        }
    }
}
