using Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class HoaDonNhap : HoaDon
    {
        public int MaPhanXuong { get; set; }
        public List<ChiTietHoaDonNhap> chiTietHoaDonNhaps { get; set; }
        
        public HoaDonNhap(string maHD, string ngay, string maNV, string gc, string maPX) : base(maHD, ngay, maNV, gc)
        {
            MaPhanXuong = Convert.ToInt32(maPX);
        }
        
        public static DataRow GetHoaDonNhapFromDB(string id)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "select * from HoaDonNhap where MaHangHoa = " + Convert.ToInt32(id);
            DataRow dr = DBUtils.GetByID(conn, query);
            return dr;
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO HoaDonNhap(MaHoaDonNhap, NgayNhap, MaPhanXuong, MaNhanVienNhap, GhiChu) " +
                "VALUES (" + MaHoaDon + ", '" + Ngay.ToString() + "', " + MaPhanXuong + ", " + MaNhanVien + ", N'" + GhiChu + "')";
            DBUtils.InsertToDB(conn, query);
        }
    }
}
