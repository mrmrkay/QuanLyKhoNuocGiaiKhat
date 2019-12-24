namespace QuanLyKhoNuocGiaiKhat
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new MetroFramework.Controls.MetroButton();
            this.btnXuatKho = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.btnNhapKho = new MetroFramework.Controls.MetroButton();
            this.btnLoaiHangHoa = new MetroFramework.Controls.MetroButton();
            this.btnNPP = new MetroFramework.Controls.MetroButton();
            this.btnPhanXuong = new MetroFramework.Controls.MetroButton();
            this.btnNhanVien = new MetroFramework.Controls.MetroButton();
            this.btnHangHoa = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnThongKe);
            this.gbMenu.Controls.Add(this.btnXuatKho);
            this.gbMenu.Controls.Add(this.metroButton7);
            this.gbMenu.Controls.Add(this.btnNhapKho);
            this.gbMenu.Controls.Add(this.btnLoaiHangHoa);
            this.gbMenu.Controls.Add(this.btnNPP);
            this.gbMenu.Controls.Add(this.btnPhanXuong);
            this.gbMenu.Controls.Add(this.btnNhanVien);
            this.gbMenu.Controls.Add(this.btnHangHoa);
            this.gbMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbMenu.Location = new System.Drawing.Point(0, 67);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(293, 626);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(6, 488);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(241, 51);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.Location = new System.Drawing.Point(6, 431);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(241, 51);
            this.btnXuatKho.TabIndex = 7;
            this.btnXuatKho.Text = "Xuất kho";
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(6, 21);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(48, 48);
            this.metroButton7.TabIndex = 6;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Location = new System.Drawing.Point(6, 374);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(241, 51);
            this.btnNhapKho.TabIndex = 5;
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // btnLoaiHangHoa
            // 
            this.btnLoaiHangHoa.Location = new System.Drawing.Point(6, 317);
            this.btnLoaiHangHoa.Name = "btnLoaiHangHoa";
            this.btnLoaiHangHoa.Size = new System.Drawing.Size(241, 51);
            this.btnLoaiHangHoa.TabIndex = 4;
            this.btnLoaiHangHoa.Text = "Loại hàng hóa";
            this.btnLoaiHangHoa.Click += new System.EventHandler(this.btnLoaiHangHoa_Click);
            // 
            // btnNPP
            // 
            this.btnNPP.Location = new System.Drawing.Point(6, 260);
            this.btnNPP.Name = "btnNPP";
            this.btnNPP.Size = new System.Drawing.Size(241, 51);
            this.btnNPP.TabIndex = 3;
            this.btnNPP.Text = "Nhà phân phối";
            this.btnNPP.Click += new System.EventHandler(this.btnNPP_Click);
            // 
            // btnPhanXuong
            // 
            this.btnPhanXuong.Location = new System.Drawing.Point(6, 203);
            this.btnPhanXuong.Name = "btnPhanXuong";
            this.btnPhanXuong.Size = new System.Drawing.Size(241, 51);
            this.btnPhanXuong.TabIndex = 2;
            this.btnPhanXuong.Text = "Phân xưởng";
            this.btnPhanXuong.Click += new System.EventHandler(this.btnPhanXuong_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(6, 146);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(241, 51);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Location = new System.Drawing.Point(6, 89);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Size = new System.Drawing.Size(241, 51);
            this.btnHangHoa.TabIndex = 0;
            this.btnHangHoa.Text = "Hàng hóa";
            this.btnHangHoa.Click += new System.EventHandler(this.btnHangHoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvData);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(293, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1187, 626);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 116);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1181, 507);
            this.dgvData.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDanhMuc);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1181, 98);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(7, 22);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(136, 17);
            this.lblDanhMuc.TabIndex = 3;
            this.lblDanhMuc.Text = "Danh mục hàng hóa";
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::QuanLyKhoNuocGiaiKhat.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(195, 60);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::QuanLyKhoNuocGiaiKhat.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(99, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::QuanLyKhoNuocGiaiKhat.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(3, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1480, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1480, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMenu;
        private MetroFramework.Controls.MetroButton btnNhapKho;
        private MetroFramework.Controls.MetroButton btnLoaiHangHoa;
        private MetroFramework.Controls.MetroButton btnNPP;
        private MetroFramework.Controls.MetroButton btnPhanXuong;
        private MetroFramework.Controls.MetroButton btnNhanVien;
        private MetroFramework.Controls.MetroButton btnHangHoa;
        private MetroFramework.Controls.MetroButton metroButton7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvData;
        private MetroFramework.Controls.MetroButton btnThongKe;
        private MetroFramework.Controls.MetroButton btnXuatKho;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}

