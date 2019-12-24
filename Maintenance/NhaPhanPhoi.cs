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
    public class NhaPhanPhoi
    {
        public int MaNhaPhanPhoi { get; set; }
        public string TenNhaPhanPhoi { get; set; }
        public string LoaiNhaPhanPhoi { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public NhaPhanPhoi(string ma, string ten, string loai, string dc, string sdt)
        {
            MaNhaPhanPhoi = Convert.ToInt32(ma);
            TenNhaPhanPhoi = ten;
            SoDienThoai = sdt;
            DiaChi = dc;
            LoaiNhaPhanPhoi = loai;
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO NhaPhanPhoi(MaNhaPhanPhoi, TenNhaPhanPhoi, LoaiNhaPhanPhoi, DiaChi, SoDienThoai) " +
                "VALUES (" + MaNhaPhanPhoi + ", N'" + TenNhaPhanPhoi + "', N'" + LoaiNhaPhanPhoi + "', N'" + DiaChi + "', " + SoDienThoai + ")";
            DBUtils.InsertToDB(conn, query);
        }

        public void UpdateNPPToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "update NhaPhanPhoi set " +
                "TenNhaPhanPhoi = N'" + TenNhaPhanPhoi + "', " +
                "LoaiNhaPhanPhoi = N'" + LoaiNhaPhanPhoi + "', " +
                "DiaChi = N'" + DiaChi + "', " +
                "SoDienThoai = " + SoDienThoai +
                "where MaNhaPhanPhoi = " + MaNhaPhanPhoi;
            DBUtils.UpdateToDatabase(conn, query);
        }

        public static DataRow GetNPPFromDB(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "select * from NhaPhanPhoi where MaNhaPhanPhoi = " + Convert.ToInt32(id);
            DataRow dr = DBUtils.GetByID(conn, query);
            return dr;
        }

        public static void DeleteNPP(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "delete from NhaPhanPhoi where MaNhaPhanPhoi = " + Convert.ToInt32(id);
            DBUtils.Delete(conn, query);
        }

        public static List<KeyValuePair<string, int>> GetListNPP()
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            string sql = "SELECT * FROM NhaPhanPhoi";
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dataadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                KeyValuePair<string, int> item = new KeyValuePair<string, int>(dr["TenNhaPhanPhoi"].ToString(), Convert.ToInt32(dr["MaNhaPhanPhoi"]));
                list.Add(item);
            }
            conn.Close();
            return list;
        }
    }
}
