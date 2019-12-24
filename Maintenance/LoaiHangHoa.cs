using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance
{
    public class LoaiHangHoa
    {
        public int MaLoaiHangHoa { get; set; }
        public string TenLoaiHangHoa { get; set; }

        public LoaiHangHoa(string ma, string ten)
        {
            MaLoaiHangHoa = Convert.ToInt32(ma);
            TenLoaiHangHoa = ten;
        }

        public static List<KeyValuePair<string, int>> GetListLoaiHangHoa()
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            string sql = "SELECT * FROM LoaiHangHoa";
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dataadapter.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                KeyValuePair<string, int> item = new KeyValuePair<string, int>(dr["TenLoaiHangHoa"].ToString(), Convert.ToInt32(dr["MaLoaiHangHoa"]));
                list.Add(item);
            }
            conn.Close();
            return list;
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO LoaiHangHoa(MaLoaiHangHoa, TenLoaiHangHoa) " +
                "VALUES (" + MaLoaiHangHoa + ", N'" + TenLoaiHangHoa + "')";
            DBUtils.InsertToDB(conn, query);
        }

        public void UpdateLoaiHangHoaToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "update LoaiHangHoa set " +
                "TenLoaiHangHoa = N'" + TenLoaiHangHoa + "', " +
                "where MaLoaiHangHoa = " + MaLoaiHangHoa;
            DBUtils.UpdateToDatabase(conn, query);
        }

        public static DataRow GetLoaiHangHoaFromDB(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "select * from LoaiHangHoa where MaLoaiHangHoa = " + Convert.ToInt32(id);
            DataRow dr = DBUtils.GetByID(conn, query);
            return dr;
        }
    }
}
