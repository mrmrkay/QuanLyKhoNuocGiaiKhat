using Activity;
using Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoNuocGiaiKhat.ActivityForm
{
    public partial class MaintainHoaDonXuat : Form
    {
        private static List<KeyValuePair<string, int>> listHangHoa = HangHoa.GetListHangHoa();
        private static List<KeyValuePair<string, int>> listNPP = NhaPhanPhoi.GetListNPP();
        private MainForm mainForm = null;
        public MaintainHoaDonXuat(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            foreach (KeyValuePair<string, int> item in listHangHoa)
            {
                cbHangHoa.Items.Add(item.Key);
            }
            foreach (KeyValuePair<string, int> item in listNPP)
            {
                cbNPP.Items.Add(item.Key);
            }
            lsvChiTiet.Columns.Add("Mã hàng hóa", 100);
            lsvChiTiet.Columns.Add("Tên hàng hóa", 150);
            lsvChiTiet.Columns.Add("Số lượng", 100);
            lsvChiTiet.Columns.Add("Đơn giá", 100);
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            int id = listHangHoa.Where(x => x.Key == cbHangHoa.Text).SingleOrDefault().Value;
            ListViewItem item = new ListViewItem(id.ToString());
            item.SubItems.Add(cbHangHoa.Text);
            item.SubItems.Add(txtSoLuong.Text);
            item.SubItems.Add(txtDonGia.Text);
            lsvChiTiet.Items.Add(item);
        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            int idNPP = listNPP.Where(x => x.Key == cbNPP.Text).SingleOrDefault().Value;
            HoaDonXuat hoaDonXuat = new HoaDonXuat(txtMaHoaDonXuat.Text, DateTime.Now.ToString(), txtMaNhanVien
                
                
                
         .Text, "ghi", idNPP.ToString());
            hoaDonXuat.SaveToDatabase();
            foreach (ListViewItem item in lsvChiTiet.Items)
            {
                ChiTietHoaDonXuat chiTietHoaDonXuat = new ChiTietHoaDonXuat(txtMaHoaDonXuat.Text, item.SubItems[0].Text, item.SubItems[3].Text, txtMaLo.Text, item.SubItems[2].Text);
                chiTietHoaDonXuat.SaveToDatabase();
                HangHoa.UpdateAmount(Convert.ToInt32(item.SubItems[0].Text), Convert.ToInt32(item.SubItems[2].Text)*-1);
            }
            this.Close();
            mainForm.LoadToDataGridView();
        }
        
    }
}
