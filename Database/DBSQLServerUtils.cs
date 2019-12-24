using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class DBSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLK_CongTyNuocGiaiKhat;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }

    }
}
