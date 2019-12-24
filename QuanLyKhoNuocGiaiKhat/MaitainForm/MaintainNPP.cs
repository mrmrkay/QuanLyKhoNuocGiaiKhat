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
    public partial class MaintainNPP : Form
    {
        private MainForm mainForm = null;

        public MaintainNPP(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            btnAdd.Text = "Thêm";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                NhaPhanPhoi nhaPhanPhoi = GetDataFromDialog();
                nhaPhanPhoi.SaveToDatabase();
            }
            else
            {
                NhaPhanPhoi nhaPhanPhoi = GetDataFromDialog();
                nhaPhanPhoi.UpdateNPPToDatabase();
            }
            mainForm.LoadToDataGridView();
            this.Close();
        }

        public void BindToDialog(string id)
        {
            DataRow dr = NhaPhanPhoi.GetNPPFromDB(id);
            btnAdd.Text = "Cập nhật";
            txtMaNPP.Text = dr["MaNhaPhanPhoi"].ToString();
            txtTenNPP.Text = dr["TenNhaPhanPhoi"].ToString();
            txtLoaiNPP.Text = dr["LoaiNhaPhanPhoi"].ToString();
            txtDiaChi.Text = dr["DiaChi"].ToString();
            txtSDT.Text = dr["SoDienThoai"].ToString();
        }

        public NhaPhanPhoi GetDataFromDialog()
        {
            NhaPhanPhoi nhaPhanPhoi = new NhaPhanPhoi(txtMaNPP.Text, txtTenNPP.Text, txtLoaiNPP.Text, txtDiaChi.Text, txtSDT.Text);
            return nhaPhanPhoi;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void txtLoaiNPP_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNPP_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNPP_Click(object sender, EventArgs e)
        {

        }
    }
}
