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
    public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int GioiTinh { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string DiaChi { get; set; }
        public decimal SoDienThoai { get; set; }
        public string Email { get; set; }
        public int Luong { get; set; }
        public DateTime NgayBatDauLamViec { get; set; }

        public NhanVien()
        {

        }

        public NhanVien(string ma, string ten, int gt, string ns, string dc, string sdt, string email, string ngayBatDau)
        {
            MaNhanVien = Convert.ToInt32(ma);
            TenNhanVien = ten;
            GioiTinh = gt;
            Ngaysinh = Convert.ToDateTime(ns);
            DiaChi = dc;
            SoDienThoai = decimal.Parse(sdt);
            Email = email;
            Luong = 0;
            NgayBatDauLamViec = Convert.ToDateTime(ngayBatDau);
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO NhanVien(MaNhanVien, TenNhanVien, GioiTinh, Ngaysinh, DiaChi, SoDienThoai, Email, Luong, NgayBatDauLamViec) " +
                "VALUES (" + MaNhanVien + ", N'" + TenNhanVien + "', " + GioiTinh + ", '" + Ngaysinh.ToString() + "', N'" + DiaChi + "', " + SoDienThoai + ", '" + Email + "', " + Luong + ", '" + NgayBatDauLamViec.ToString() + "')";
            DBUtils.InsertToDB(conn, query);
        }

        public static List<KeyValuePair<string, int>> GetListNhanVien()
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            string sql = "SELECT * FROM NhanVien";
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Open();
            dataadapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                KeyValuePair<string, int> item = new KeyValuePair<string, int>(dr["TenNhanVien"].ToString(), Convert.ToInt32(dr["MaNhanVien"]));
                list.Add(item);
            }
            conn.Close();
            return list;
        }

        public void UpdateNhanVienToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "update NhanVien set " +
                "TenNhanVien = N'" + TenNhanVien + "', " +
                "GioiTinh = " + GioiTinh + ", " +
                "Ngaysinh = '" + Ngaysinh.ToString() + "', " +
                "DiaChi = N'" + DiaChi + "', " +
                "SoDienThoai = " + SoDienThoai + ", " +
                "Email = '" + Email + "', " +
                "Luong = "+ Luong + " " +
                "where MaNhanVien = " + MaNhanVien;
            DBUtils.UpdateToDatabase(conn, query);
        }

        public static DataRow GetNhanVienFromDB(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "select * from NhanVien where MaNhanVien = " + Convert.ToInt32(id);
            DataRow dr = DBUtils.GetByID(conn, query);
            return dr;
        }

        public static void DeleteNhanVien(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "delete from NhanVien where MaNhanVien = " + Convert.ToInt32(id);
            DBUtils.Delete(conn, query);
        }
    }
}
