using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection? cn;
        public static void connect()
        {
            // string s = "initial catalog = InternshipManage; data source = 602-GV\\SQLEXPRESS; integrated security = true";
            string s = "server = 172.16.97.130; database = InternshipManagement; uid = SA; pwd = Gv.BTqpg2mC6qCa8uikg";
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
