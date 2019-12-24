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
using QuanLyKhoNuocGiaiKhat.MaitainForm;
using Activity;

namespace QuanLyKhoNuocGiaiKhat.ActivityForm
{
    public partial class MaintainHoaDonNhap : Form
    {
        private static List<KeyValuePair<string, int>> listHangHoa = HangHoa.GetListHangHoa();
        private static List<KeyValuePair<string, int>> listPhanXuong = PhanXuong.GetListPhanXuong();
        private MainForm mainForm = null;
        public MaintainHoaDonNhap(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            foreach (KeyValuePair<string, int> item in listHangHoa)
            {
                cbHangHoa.Items.Add(item.Key);
            }
            foreach (KeyValuePair<string, int> item in listPhanXuong)
            {
                cbPhanXuong.Items.Add(item.Key);
            }
            lsvChiTiet.Columns.Add("Mã hàng hóa", 100);
            lsvChiTiet.Columns.Add("Tên hàng hóa", 150);
            lsvChiTiet.Columns.Add("Số lượng", 100);
            lsvChiTiet.Columns.Add("Đơn giá", 100);
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            MaintainHangHoa maintainHangHoa = new MaintainHangHoa(mainForm);
            maintainHangHoa.Show();
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
            Lo lo = new Lo(txtMaLo.Text, dtNSX.Value.ToString(), dtHSD.Value.ToString());
            lo.SaveToDatabase();
            int idPX = listPhanXuong.Where(x => x.Key == cbPhanXuong.Text).SingleOrDefault().Value;
            HoaDonNhap hoaDonNhap = new HoaDonNhap(txtMaHoaDonNhap.Text, DateTime.Now.ToString(), txtMaNhanVien.Text, "ghi", idPX.ToString());
            hoaDonNhap.SaveToDatabase();
            foreach(ListViewItem item in lsvChiTiet.Items)
            {
                ChiTietHoaDonNhap chiTietHoaDonNhap = new ChiTietHoaDonNhap(txtMaHoaDonNhap.Text, item.SubItems[0].Text, item.SubItems[3].Text, txtMaLo.Text, item.SubItems[2].Text);
                chiTietHoaDonNhap.SaveToDatabase();
                HangHoa.UpdateAmount(Convert.ToInt32(item.SubItems[0].Text), Convert.ToInt32(item.SubItems[2].Text));
            }
            this.Close();
            mainForm.LoadToDataGridView();
        }
    }
}
