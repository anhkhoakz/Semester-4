using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Connection
    {
        private static SqlConnection cn;

        public static void connect()
        {
            string s = "server = 172.16.98.79; database = QuanLyThuVien; uid = SA; pwd = Gv.BTqpg2mC6qCa8uikg";
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
        public static DataTable selectQuery(string sql, SqlParameter[] parameters)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        

    }
}
