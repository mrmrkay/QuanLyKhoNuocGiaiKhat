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
    public class PhanXuong
    {
        public int MaPhanXuong { get; set; }
        public string TenPhanXuong { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public PhanXuong(string ma, string ten, string sdt, string email)
        {
            MaPhanXuong = Convert.ToInt32(ma);
            TenPhanXuong = ten;
            SoDienThoai = sdt;
            Email = email;
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO PhanXuong(MaPhanXuong, TenPhanXuong, SoDienThoai, Email) " +
                "VALUES (" + MaPhanXuong + ", N'" + TenPhanXuong + "', " + SoDienThoai + ", '" + Email + "')";
            DBUtils.InsertToDB(conn, query);
        }

        public void UpdatePhanXuongToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "update PhanXuong set " +
                "TenPhanXuong = N'" + TenPhanXuong + "', " +
                "SoDienThoai = " + SoDienThoai + ", " +
                "Email = '" + Email + "'" +
                "where MaPhanXuong = " + MaPhanXuong;
            DBUtils.UpdateToDatabase(conn, query);
        }

        public static DataRow GetPhanXuongFromDB(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "select * from PhanXuong where MaPhanXuong = " + Convert.ToInt32(id);
            DataRow dr = DBUtils.GetByID(conn, query);
            return dr;
        }

        public static void DeletePhanXuong(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "delete from PhanXuong where MaPhanXuong = " + Convert.ToInt32(id);
            DBUtils.Delete(conn, query);
        }

        public static List<KeyValuePair<string, int>> GetListPhanXuong()
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            string sql = "SELECT * FROM PhanXuong";
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dataadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                KeyValuePair<string, int> item = new KeyValuePair<string, int>(dr["TenPhanXuong"].ToString(), Convert.ToInt32(dr["MaPhanXuong"]));
                list.Add(item);
            }
            conn.Close();
            return list;
        }
    }
}
