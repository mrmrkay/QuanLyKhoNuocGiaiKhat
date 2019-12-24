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


namespace QuanLyKhoNuocGiaiKhat
{
    public partial class MaintainNhanVien : Form
    {
        private MainForm mainForm = null;
        public MaintainNhanVien(MainForm main)
        {
            mainForm = main;
            InitializeComponent();
            btnAdd.Text = "Thêm";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                NhanVien nv = GetDataFromDialog();
                nv.SaveToDatabase();
            }
            else
            {
                NhanVien nv = GetDataFromDialog();
                nv.UpdateNhanVienToDatabase();
            }
            mainForm.LoadToDataGridView();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BindToDialog(string id)
        {
            DataRow dr = NhanVien.GetNhanVienFromDB(id);
            btnAdd.Text = "Cập nhật";
            txtMaNhanVien.Text = dr["MaNhanVien"].ToString();
            txtTen.Text = dr["TenNhanVien"].ToString();
            if ((bool)dr["GioiTinh"])
            {
                rbtNam.Checked = true;
            }
            else rbtNu.Checked = true;
            dtNgaySinh.Value = Convert.ToDateTime(dr["NgaySinh"].ToString());
            txtDiaChi.Text = dr["DiaChi"].ToString();
            txtSDT.Text = dr["SoDienThoai"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            dtNgayLamViec.Value = dr["NgayBatDauLamViec"].ToString() == "" ? DateTime.Now : Convert.ToDateTime(dr["NgayBatDauLamViec"].ToString());
        }

        public NhanVien GetDataFromDialog()
        {
            int gioiTinh = 0;
            if (rbtNam.Checked)
            {
                gioiTinh = 1;
            }
            NhanVien nv = new NhanVien(txtMaNhanVien.Text, txtTen.Text, gioiTinh, dtNgaySinh.Value.ToString(), txtDiaChi.Text, txtSDT.Text, txtEmail.Text, dtNgayLamViec.Value.ToString());
            return nv;
        }
    }
}
