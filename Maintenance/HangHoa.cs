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
    public class HangHoa
    {
        public int MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public int MaLoHangHoa { get; set; }
        public int MaLoaiHangHoa { get; set; }
        public int Gia { get; set; }
        public int DungTich { get; set; }
        public string QuyCach { get; set; }
        public int SoLuongTon { get; set; }

        public HangHoa(string ma, string ten, int maLoai, string dt, string qc)
        {
            MaHangHoa = Convert.ToInt32(ma);
            TenHangHoa = ten;
            MaLoaiHangHoa = maLoai;
            DungTich = Convert.ToInt32(dt);
            QuyCach = qc;
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO HangHoa(MaHangHoa, TenHangHoa, MaLoaiHangHoa, DungTich, QuyCach, SoLuongTon, SoLuongHetHan, MaKho) " +
                "VALUES (" + MaHangHoa + ", N'" + TenHangHoa + "', " + MaLoaiHangHoa + ", " + DungTich + ", N'" + QuyCach + "', " + 0 + ", " + 0 + ", 1)";
            DBUtils.InsertToDB(conn, query);
        }

        public void UpdateHangHoaToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "update HangHoa set " +
                "TenHangHoa = N'" + TenHangHoa + "', " +
                "MaLoaiHangHoa = " + MaLoaiHangHoa + ", " +
                "DungTich = " + DungTich + ", " +
                "QuyCach = N'" + QuyCach + "', " +
                "where MaHangHoa = " + MaHangHoa;
            DBUtils.UpdateToDatabase(conn, query);
        }

        public static DataRow GetHangHoaFromDB(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "select * from HangHoa where MaHangHoa = " + Convert.ToInt32(id);
            DataRow dr = DBUtils.GetByID(conn, query);
            return dr;
        }

        public static void DeleteHangHoa(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "delete from HangHoa where MaHangHoa = " + Convert.ToInt32(id);
            DBUtils.Delete(conn, query);
        }

        public static List<KeyValuePair<string, int>> GetListHangHoa()
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            string sql = "SELECT * FROM HangHoa";
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dataadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                KeyValuePair<string, int> item = new KeyValuePair<string, int>(dr["TenHangHoa"].ToString(), Convert.ToInt32(dr["MaHangHoa"]));
                list.Add(item);
            }
            conn.Close();
            return list;
        }

        public static void UpdateAmount(int id, int sl)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "update HangHoa set SoLuongTon = SoLuongTon + " + sl + "where MaHangHoa = " + id;
            DBUtils.UpdateToDatabase(conn, query);
        }
    }
}
