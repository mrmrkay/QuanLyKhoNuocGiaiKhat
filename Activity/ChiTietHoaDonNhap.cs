using Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class ChiTietHoaDonNhap
    {
        public int MaHoaDonNhap { get; set; }
        public int MaHangHoa { get; set; }
        public int DonGia { get; set; }
        public int MaLo { get; set; }
        public int SoLuongNhap { get; set; }

        public ChiTietHoaDonNhap(string maHD, string maHH, string dg, string maLo, string sln)
        {
            MaHoaDonNhap = Convert.ToInt32(maHD);
            MaHangHoa = Convert.ToInt32(maHH);
            DonGia = Convert.ToInt32(dg);
            MaLo = Convert.ToInt32(maLo);
            SoLuongNhap = Convert.ToInt32(sln);
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO CT_HoaDonNhap(MaHoaDonNhap, MaHangHoa, DonGia, MaLo, SoLuongNhap) " +
                "VALUES (" + MaHoaDonNhap + ", " + MaHangHoa + ", " + DonGia + ", " + MaLo + ", " + SoLuongNhap + ")";
            DBUtils.InsertToDB(conn, query);
        }
    }
}
