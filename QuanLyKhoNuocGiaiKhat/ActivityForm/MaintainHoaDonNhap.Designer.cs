namespace QuanLyKhoNuocGiaiKhat.ActivityForm
{
    partial class MaintainHoaDonNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMaNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnThemHoaDon = new System.Windows.Forms.Button();
            this.lsvChiTiet = new System.Windows.Forms.ListView();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemChiTiet = new System.Windows.Forms.Button();
            this.btnThemHangHoa = new System.Windows.Forms.Button();
            this.txtSoLuong = new MetroFramework.Controls.MetroTextBox();
            this.txtMaLo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtDonGia = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNSX = new System.Windows.Forms.DateTimePicker();
            this.dtHSD = new System.Windows.Forms.DateTimePicker();
            this.txtMaHoaDonNhap = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cbPhanXuong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập kho";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(334, 154);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(272, 30);
            this.txtTen.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(141, 154);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Tên nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(334, 117);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(272, 30);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(141, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Mã nhân viên nhập kho";
            // 
            // btnThemHoaDon
            // 
            this.btnThemHoaDon.Location = new System.Drawing.Point(334, 750);
            this.btnThemHoaDon.Name = "btnThemHoaDon";
            this.btnThemHoaDon.Size = new System.Drawing.Size(164, 49);
            this.btnThemHoaDon.TabIndex = 14;
            this.btnThemHoaDon.Text = "Thêm hóa đơn";
            this.btnThemHoaDon.UseVisualStyleBackColor = true;
            this.btnThemHoaDon.Click += new System.EventHandler(this.btnThemHoaDon_Click);
            // 
            // lsvChiTiet
            // 
            this.lsvChiTiet.HideSelection = false;
            this.lsvChiTiet.Location = new System.Drawing.Point(62, 535);
            this.lsvChiTiet.Name = "lsvChiTiet";
            this.lsvChiTiet.Size = new System.Drawing.Size(764, 200);
            this.lsvChiTiet.TabIndex = 18;
            this.lsvChiTiet.UseCompatibleStateImageBehavior = false;
            this.lsvChiTiet.View = System.Windows.Forms.View.Details;
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(334, 361);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(192, 24);
            this.cbHangHoa.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mặt hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhập hàng hóa:";
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.Location = new System.Drawing.Point(334, 492);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(102, 37);
            this.btnThemChiTiet.TabIndex = 19;
            this.btnThemChiTiet.Text = "Thêm chi tiết";
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // btnThemHangHoa
            // 
            this.btnThemHangHoa.Location = new System.Drawing.Point(550, 361);
            this.btnThemHangHoa.Name = "btnThemHangHoa";
            this.btnThemHangHoa.Size = new System.Drawing.Size(59, 27);
            this.btnThemHangHoa.TabIndex = 20;
            this.btnThemHangHoa.Text = "Thêm";
            this.btnThemHangHoa.UseVisualStyleBackColor = true;
            this.btnThemHangHoa.Click += new System.EventHandler(this.btnThemHangHoa_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(334, 391);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(78, 30);
            this.txtSoLuong.TabIndex = 9;
            // 
            // txtMaLo
            // 
            this.txtMaLo.Location = new System.Drawing.Point(334, 190);
            this.txtMaLo.Name = "txtMaLo";
            this.txtMaLo.Size = new System.Drawing.Size(272, 30);
            this.txtMaLo.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel3.Location = new System.Drawing.Point(141, 190);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(43, 20);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Mã lô";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel4.Location = new System.Drawing.Point(141, 226);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(96, 20);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Ngày sản xuất";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel5.Location = new System.Drawing.Point(141, 262);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 20);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "Hạn sử dụng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(334, 428);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(272, 30);
            this.txtDonGia.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Đơn giá";
            // 
            // dtNSX
            // 
            this.dtNSX.Location = new System.Drawing.Point(334, 226);
            this.dtNSX.Name = "dtNSX";
            this.dtNSX.Size = new System.Drawing.Size(272, 22);
            this.dtNSX.TabIndex = 5;
            // 
            // dtHSD
            // 
            this.dtHSD.Location = new System.Drawing.Point(334, 262);
            this.dtHSD.Name = "dtHSD";
            this.dtHSD.Size = new System.Drawing.Size(272, 22);
            this.dtHSD.TabIndex = 6;
            // 
            // txtMaHoaDonNhap
            // 
            this.txtMaHoaDonNhap.Location = new System.Drawing.Point(334, 81);
            this.txtMaHoaDonNhap.Name = "txtMaHoaDonNhap";
            this.txtMaHoaDonNhap.Size = new System.Drawing.Size(272, 30);
            this.txtMaHoaDonNhap.TabIndex = 1;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(141, 81);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(145, 20);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Mã hóa đơn nhập kho";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(141, 299);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(82, 20);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Phân xưởng";
            // 
            // cbPhanXuong
            // 
            this.cbPhanXuong.FormattingEnabled = true;
            this.cbPhanXuong.Location = new System.Drawing.Point(334, 299);
            this.cbPhanXuong.Name = "cbPhanXuong";
            this.cbPhanXuong.Size = new System.Drawing.Size(192, 24);
            this.cbPhanXuong.TabIndex = 7;
            // 
            // MaintainHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 811);
            this.Controls.Add(this.cbPhanXuong);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtMaHoaDonNhap);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dtHSD);
            this.Controls.Add(this.dtNSX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtMaLo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.btnThemHangHoa);
            this.Controls.Add(this.btnThemChiTiet);
            this.Controls.Add(this.btnThemHoaDon);
            this.Controls.Add(this.lsvChiTiet);
            this.Controls.Add(this.cbHangHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Name = "MaintainHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDonNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtTen;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMaNhanVien;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnThemHoaDon;
        private System.Windows.Forms.ListView lsvChiTiet;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemChiTiet;
        private System.Windows.Forms.Button btnThemHangHoa;
        private MetroFramework.Controls.MetroTextBox txtSoLuong;
        private MetroFramework.Controls.MetroTextBox txtMaLo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNSX;
        private System.Windows.Forms.DateTimePicker dtHSD;
        private MetroFramework.Controls.MetroTextBox txtMaHoaDonNhap;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ComboBox cbPhanXuong;
    }
}