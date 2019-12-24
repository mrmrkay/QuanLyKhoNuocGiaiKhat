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
    public partial class MaintainLoaiHangHoa : Form
    {
        private MaintainHangHoa maintainHangHoa = null;
        private MainForm mainForm = null;
        public MaintainLoaiHangHoa(MainForm mainForm, MaintainHangHoa maintainHangHoa)
        {
            this.mainForm = mainForm;
            this.maintainHangHoa = maintainHangHoa;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoaiHangHoa loaiHangHoa = new LoaiHangHoa(txtMaLoaiHangHoa.Text, txtTenLoaiHangHoa.Text);
            if(maintainHangHoa != null)
            {
                loaiHangHoa.SaveToDatabase();
                maintainHangHoa.AddNewLHH(new KeyValuePair<string, int>(txtTenLoaiHangHoa.Text, Convert.ToInt32(txtMaLoaiHangHoa.Text)));
            }
            else
            {
                if (btnAdd.Text == "Thêm")
                {
                    loaiHangHoa.SaveToDatabase();
                }
                else
                {
                    loaiHangHoa.UpdateLoaiHangHoaToDatabase();
                }
                mainForm.LoadToDataGridView();
            }
            this.Close();
        }

        public void BindToDialog(string id)
        {
            DataRow dr = NhaPhanPhoi.GetNPPFromDB(id);
            btnAdd.Text = "Cập nhật";
            txtMaLoaiHangHoa.Text = dr["MaLoaiHangHoa"].ToString();
            txtTenLoaiHangHoa.Text = dr["TenLoaiHangHoa"].ToString();
        }

        public LoaiHangHoa GetDataFromDialog()
        {
            LoaiHangHoa loaiHangHoa = new LoaiHangHoa(txtMaLoaiHangHoa.Text, txtTenLoaiHangHoa.Text);
            return loaiHangHoa;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
