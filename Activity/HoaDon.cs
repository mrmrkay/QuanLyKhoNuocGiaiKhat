using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public DateTime Ngay { get; set; }
        public int MaNhanVien { get; set; }
        public string GhiChu { get; set; }

        public HoaDon(string maHD, string ngay, string maNV, string gc)
        {
            MaHoaDon = Convert.ToInt32(maHD);
            Ngay = Convert.ToDateTime(ngay);
            MaNhanVien = Convert.ToInt32(maNV);
            GhiChu = gc;
        }
    }
}
