namespace QuanLyKhoNuocGiaiKhat.MaitainForm
{
    partial class MaintainLoaiHangHoa
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
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtTenLoaiHangHoa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtMaLoaiHangHoa = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "Loại hàng hóa";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 41);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Quay lại";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 41);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTenLoaiHangHoa
            // 
            this.txtTenLoaiHangHoa.Location = new System.Drawing.Point(171, 111);
            this.txtTenLoaiHangHoa.Name = "txtTenLoaiHangHoa";
            this.txtTenLoaiHangHoa.Size = new System.Drawing.Size(272, 30);
            this.txtTenLoaiHangHoa.TabIndex = 50;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(21, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(118, 20);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Tên loại hàng hóa";
            // 
            // txtMaLoaiHangHoa
            // 
            this.txtMaLoaiHangHoa.Location = new System.Drawing.Point(171, 74);
            this.txtMaLoaiHangHoa.Name = "txtMaLoaiHangHoa";
            this.txtMaLoaiHangHoa.Size = new System.Drawing.Size(272, 30);
            this.txtMaLoaiHangHoa.TabIndex = 46;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(21, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 20);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Mã loại hàng hóa";
            // 
            // MaintainLoaiHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 242);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTenLoaiHangHoa);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtMaLoaiHangHoa);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MaintainLoaiHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin loại hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtTenLoaiHangHoa;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtMaLoaiHangHoa;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}