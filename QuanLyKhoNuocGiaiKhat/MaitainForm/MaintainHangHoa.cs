using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maintenance;

namespace QuanLyKhoNuocGiaiKhat.MaitainForm
{
    public partial class MaintainHangHoa : Form
    {
        private MainForm mainForm = null;
        private static List<KeyValuePair<string, int>> listLHH = LoaiHangHoa.GetListLoaiHangHoa();
        public MaintainHangHoa(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            btnAdd.Text = "Thêm";
            foreach (KeyValuePair<string, int> item in listLHH)
            {
                cbLoaiHangHoa.Items.Add(item.Key);
            }
        }

        private void btnThemLHH_Click(object sender, EventArgs e)
        {
            MaintainLoaiHangHoa maintainLoaiHangHoa = new MaintainLoaiHangHoa(null, this);
            maintainLoaiHangHoa.Show();
        }

        public void AddNewLHH(KeyValuePair<string, int> item)
        {
            listLHH.Add(item);
            cbLoaiHangHoa.Items.Add(item.Key);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
            {
                HangHoa hangHoa = GetDataFromDialog();
                hangHoa.SaveToDatabase();
            }
            else
            {
                HangHoa hangHoa = GetDataFromDialog();
                hangHoa.UpdateHangHoaToDatabase();
            }
            mainForm.LoadToDataGridView();
            this.Close();
        }

        public void BindToDialog(string id)
        {
            DataRow dr = HangHoa.GetHangHoaFromDB(id);
            btnAdd.Text = "Cập nhật";
            txtMaHangHoa.Text = dr["MaHangHoa"].ToString();
            txtTenHangHoa.Text = dr["TenHangHoa"].ToString();
            string tenLHH = listLHH.Where(x => x.Value == Convert.ToInt32(dr["MaLoaiHangHoa"].ToString())).SingleOrDefault().Key;
            cbLoaiHangHoa.Text = tenLHH;
            txtDungTich.Text = dr["DungTich"].ToString();
            txtQuyCach.Text = dr["QuyCach"].ToString();
        }

        public HangHoa GetDataFromDialog()
        {
            int idLHH = listLHH.Where(x => x.Key == cbLoaiHangHoa.Text).SingleOrDefault().Value;
            HangHoa hangHoa = new HangHoa(txtMaHangHoa.Text, txtTenHangHoa.Text, idLHH, txtDungTich.Text, txtQuyCach.Text);
            return hangHoa;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
