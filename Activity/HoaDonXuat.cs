using Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class HoaDonXuat : HoaDon
    {
        public int MaNhaPhanPhoi { get; set; }
        public List<ChiTietHoaDonXuat> chiTietHoaDonXuats { get; set; }

        public HoaDonXuat(string maHD, string ngay, string maNV, string gc, string maNPP) : base(maHD, ngay, maNV, gc)
        {
            MaNhaPhanPhoi = Convert.ToInt32(maNPP);
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO HoaDonXuat(MaHoaDonXuat, NgayXuat, MaNhanVienXuat, MaNhaPhanPhoi, GhiChu) " +
                "VALUES (" + MaHoaDon + ", '" + Ngay.ToString() + "', " + MaNhanVien + ", " + MaNhaPhanPhoi + ", N'" + GhiChu + "')";
            DBUtils.InsertToDB(conn, query);
        }
    }
}
