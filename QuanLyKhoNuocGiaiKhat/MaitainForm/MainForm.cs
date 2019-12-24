using Database;
using Maintenance;
using QuanLyKhoNuocGiaiKhat.MaitainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhoNuocGiaiKhat.ActivityForm;

namespace QuanLyKhoNuocGiaiKhat
{
    public partial class MainForm : Form
    {
        private static SqlConnection conn = DBUtils.GetDBConnection();
        private string content = "HangHoa";

        private static List<KeyValuePair<string, int>> listNhanVien = NhanVien.GetListNhanVien();

        public MainForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(37, 46, 59);
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblDanhMuc.ForeColor = Color.White;
            lblDanhMuc.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbMenu.Width = 200;
            gbMenu.TabIndex = 0;
            gbMenu.TabStop = true;
            
            LoadToDataGridView();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            if(gbMenu.Width == 50)
            {
                gbMenu.Width = 200;
            } else
            {
                gbMenu.Width = 50;
            }
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            content = "HangHoa";
            LoadToDataGridView();
            dgvData.Columns["SoLuongHetHan"].Visible = false;
            dgvData.Columns["MaKho"].Visible = false;
            lblDanhMuc.Text = "Danh mục hàng hóa";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            content = "NhanVien";
            LoadToDataGridView();
            dgvData.Columns["GioiTinh"].Visible = false;
            dgvData.Columns["NgayBatDauLamViec"].Visible = false;
            dgvData.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dgvData.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            dgvData.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvData.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvData.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dgvData.Columns["Luong"].HeaderText = "Lương";
            lblDanhMuc.Text = "Danh mục nhân viên";
        }

        private void btnPhanXuong_Click(object sender, EventArgs e)
        {
            content = "PhanXuong";
            LoadToDataGridView();
            lblDanhMuc.Text = "Danh mục phân xưởng";
        }

        private void btnNPP_Click(object sender, EventArgs e)
        {
            content = "NhaPhanPhoi";
            LoadToDataGridView();
            lblDanhMuc.Text = "Danh mục nhà phân phối";
        }

        private void btnLoaiHangHoa_Click(object sender, EventArgs e)
        {
            content = "LoaiHangHoa";
            LoadToDataGridView();
            lblDanhMuc.Text = "Danh mục loại hàng hóa";
        }

        public void LoadToDataGridView()
        {
            ChangeEditAndDeleteButton();
            string sql = "SELECT * FROM " + content;
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataadapter.Fill(ds, "dgvData");
            conn.Close();
            dgvData.DataSource = ds;
            dgvData.DataMember = "dgvData";
        }

        public void SetContent(string str)
        {
            content = str;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            switch (content)
            {
                case "NhanVien":
                    MaintainNhanVien maintainNhanVien = new MaintainNhanVien(this);
                    maintainNhanVien.Show();
                    break;
                case "HangHoa":
                    MaintainHangHoa maintainHangHoa = new MaintainHangHoa(this);
                    maintainHangHoa.Show();
                    break;
                case "PhanXuong":
                    MaintainPhanXuong maintainPhanXuong = new MaintainPhanXuong(this);
                    maintainPhanXuong.Show();
                    break;
                case "NhaPhanPhoi":
                    MaintainNPP maintainNPP = new MaintainNPP(this);
                    maintainNPP.Show();
                    break;
                case "LoaiHangHoa":
                    MaintainLoaiHangHoa maintainLoaiHangHoa = new MaintainLoaiHangHoa(this, null);
                    maintainLoaiHangHoa.Show();
                    break;
                case "HoaDonNhap":
                    MaintainHoaDonNhap hoaDonNhap = new MaintainHoaDonNhap(this);
                    hoaDonNhap.Show();
                    break;
                case "HoaDonXuat":
                    MaintainHoaDonXuat hoaDonXuat = new MaintainHoaDonXuat(this);
                    hoaDonXuat.Show();
                    break;
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = dgvData.CurrentRow.Cells[0].FormattedValue.ToString().Trim();
            switch (content)
            {
                case "NhanVien":
                    MaintainNhanVien maintainNhanVien = new MaintainNhanVien(this);
                    maintainNhanVien.BindToDialog(id);
                    maintainNhanVien.Show();
                    break;
                case "HangHoa":
                    MaintainHangHoa maintainHangHoa = new MaintainHangHoa(this);
                    maintainHangHoa.BindToDialog(id);
                    maintainHangHoa.Show();
                    break;
                case "PhanXuong":
                    MaintainPhanXuong maintainPhanXuong = new MaintainPhanXuong(this);
                    maintainPhanXuong.BindToDialog(id);
                    maintainPhanXuong.Show();
                    break;
                case "NhaPhanPhoi":
                    MaintainNPP maintainNPP = new MaintainNPP(this);
                    maintainNPP.BindToDialog(id);
                    maintainNPP.Show();
                    break;
                /*case "LoaiHangHoa":
                    MaintainLoaiHangHoa maintainLoaiHangHoa = new MaintainLoaiHangHoa(this, null);
                    maintainLoaiHangHoa.BindToDialog(id);
                    maintainLoaiHangHoa.Show();
                    break;*/
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = dgvData.CurrentRow.Cells[0].FormattedValue.ToString().Trim();
            switch (content)
            {
                case "NhanVien":
                    NhanVien.DeleteNhanVien(id);
                    LoadToDataGridView();
                    break;
                case "HangHoa":
                    HangHoa.DeleteHangHoa(id);
                    LoadToDataGridView();
                    break;
            }
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            content = "HoaDonNhap";
            LoadToDataGridView();

            dgvData.Columns["MaHoaDonNhap"].Width = 150;
            dgvData.Columns["MaHoaDonNhap"].HeaderText = "Mã hóa đơn nhập";

            dgvData.Columns["NgayNhap"].HeaderText = "Ngày nhập";

            dgvData.Columns["MaPhanXuong"].Width = 150;
            dgvData.Columns["MaPhanXuong"].HeaderText = "Mã phân xưởng";

            dgvData.Columns["MaNhanVienNhap"].Width = 150;
            dgvData.Columns["MaNhanVienNhap"].HeaderText = "Mã nhân viên nhập";

            dgvData.Columns["GhiChu"].HeaderText = "Ghi chú";

            lblDanhMuc.Text = "Danh mục hóa đơn nhập";
        }

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            content = "HoaDonXuat";
            LoadToDataGridView();

            dgvData.Columns["MaHoaDonXuat"].Width = 150;
            dgvData.Columns["MaHoaDonXuat"].HeaderText = "Mã hóa đơn xuất";
            
            dgvData.Columns["NgayXuat"].HeaderText = "Ngày xuất";

            dgvData.Columns["MaNhaPhanPhoi"].Width = 150;
            dgvData.Columns["MaNhaPhanPhoi"].HeaderText = "Mã nhà phân phối";

            dgvData.Columns["MaNhanVienXuat"].Width = 150;
            dgvData.Columns["MaNhanVienXuat"].HeaderText = "Mã nhân viên xuất";

            dgvData.Columns["GhiChu"].HeaderText = "Ghi chú";

            lblDanhMuc.Text = "Danh mục hóa đơn xuất";
        }

        private void ChangeEditAndDeleteButton()
        {
            if (content == "HoaDonNhap" || content == "HoaDonXuat")
            {
                btnEdit.Text = "Detail";
                btnDelete.Hide();
            }
            else
            {
                btnEdit.Text = "Edit";
                btnDelete.Show();
            }
        }
    }
}
