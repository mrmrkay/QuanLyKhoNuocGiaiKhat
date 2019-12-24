using Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class ChiTietHoaDonXuat
    {
        public int MaHoaDonXuat { get; set; }
        public int MaHangHoa { get; set; }
        public int DonGia { get; set; }
        public int MaLo { get; set; }
        public int SoLuongXuat { get; set; }

        public ChiTietHoaDonXuat(string maHD, string maHH, string dg, string maLo, string sln)
        {
            MaHoaDonXuat = Convert.ToInt32(maHD);
            MaHangHoa = Convert.ToInt32(maHH);
            DonGia = Convert.ToInt32(dg);
            MaLo = Convert.ToInt32(maLo);
            SoLuongXuat = Convert.ToInt32(sln);
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO CT_HoaDonXuat(MaHoaDonXuat, MaHangHoa, DonGia, MaLo, SoLuongXuat) " +
                "VALUES (" + MaHoaDonXuat + ", " + MaHangHoa + ", " + DonGia + ", " + MaLo + ", " + SoLuongXuat + ")";
            DBUtils.InsertToDB(conn, query);
        }
    }
}
