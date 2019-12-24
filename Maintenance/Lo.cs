using Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance
{
    public class Lo
    {
        public int MaLo { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        //public int SoLuong { get; set; }

        public Lo(string ma, string nsx, string hsd)
        {
            MaLo = Convert.ToInt32(ma);
            NgaySanXuat = Convert.ToDateTime(nsx);
            HanSuDung = Convert.ToDateTime(hsd);
        }

        public void SaveToDatabase()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            string query = "INSERT INTO Lo(MaLo, NgaySanXuat, HanSuDung, SoLuong) " +
                "VALUES (" + MaLo + ", '" + NgaySanXuat.ToString() + "', '" + HanSuDung.ToString() + "', 1)";
            DBUtils.InsertToDB(conn, query);
        }
    }
}
