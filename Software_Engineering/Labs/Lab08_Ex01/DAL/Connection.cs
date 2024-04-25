using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection cn;

        public static void connect()
        {
            // string s = "initial catalog = StudentManagement; data source = DESKTOP-44OH4C4\\SQLEXPRESS; integrated security = true";
            string s = "server = 172.16.98.154; database = InternshipManagement; uid = SA; pwd = Gv.BTqpg2mC6qCa8uikg";
            cn = new SqlConnection(s);
            cn.Open();
        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);

            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
    }
}
