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

namespace QuanLyKhoNuocGiaiKhat.MaitainForm
{
    public partial class MaintainPhanXuong : Form
    {
        private MainForm mainForm = null;
        public MaintainPhanXuong(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            btnAdd.Text = "Thêm";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                PhanXuong phanXuong = GetDataFromDialog();
                phanXuong.SaveToDatabase();
            }
            else
            {
                PhanXuong phanXuong = GetDataFromDialog();
                phanXuong.UpdatePhanXuongToDatabase();
            }
            mainForm.LoadToDataGridView();
            this.Close();
        }

        public void BindToDialog(string id)
        {
            DataRow dr = PhanXuong.GetPhanXuongFromDB(id);
            btnAdd.Text = "Cập nhật";
            txtMaPhanXuong.Text = dr["MaPhanXuong"].ToString();
            txtTenPhanXuong.Text = dr["TenPhanXuong"].ToString();
            txtSDT.Text = dr["SoDienThoai"].ToString();
            txtEmail.Text = dr["Email"].ToString();
        }

        public PhanXuong GetDataFromDialog()
        {
            PhanXuong phanXuong = new PhanXuong(txtMaPhanXuong.Text, txtTenPhanXuong.Text, txtSDT.Text, txtEmail.Text);
            return phanXuong;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
