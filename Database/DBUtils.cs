using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = @"MRMRKAY\SQLEXPRESS";
            string database = "QLK_CongTyNuocGiaiKhat";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }

        public static void InsertToDB(SqlConnection conn, string query)
        {
            conn.Open();
            SqlCommand myCommand = new SqlCommand(query, conn);
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static DataRow GetByID(SqlConnection conn, string query)
        {
            SqlDataAdapter dataadapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dataadapter.Fill(dt);
            conn.Close();
            return dt.Rows[0];
        }

        public static void UpdateToDatabase(SqlConnection conn, string query)
        {
            conn.Open();
            SqlCommand myCommand = new SqlCommand(query, conn);
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static void Delete(SqlConnection conn, string query)
        {
            conn.Open();
            SqlCommand myCommand = new SqlCommand(query, conn);
            myCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
