namespace QL_DiemTHPT
{
    partial class FrmQLHOCSINH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.mnuXemDiem = new System.Windows.Forms.Label();
            this.mnuTrangChu = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.data_HOCSINH = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_HOCSINH)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();

            // Gán sự kiện cho các nút và menu
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            this.mnuTrangChu.Click += new System.EventHandler(this.mnuTrangChu_Click);
            this.mnuXemDiem.Click += new System.EventHandler(this.mnuXemDiem_Click);

            // Thiết lập DataGridView
            this.data_HOCSINH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_HOCSINH.Location = new System.Drawing.Point(210, 200);
            this.data_HOCSINH.Name = "data_HOCSINH";
            this.data_HOCSINH.Size = new System.Drawing.Size(760, 450);
            this.data_HOCSINH.TabIndex = 0;
            this.data_HOCSINH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_HOCSINH_CellClick);

            // Các TextBox (Đặt tên khớp với file .cs)
            this.txtMa.Name = "txtMa";
            this.txtHoTen.Name = "txtHoTen";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtMatKhau.Name = "txtMatKhau";
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.lblSoLuong.Name = "lblSoLuong";

            // FrmQLHOCSINH
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.data_HOCSINH);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQLHOCSINH";
            this.Text = "Quản Lý Học Sinh";
            this.Load += new System.EventHandler(this.FrmQLHOCSINH_Load);
            this.panel1.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_HOCSINH)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label mnuXemDiem;
        private System.Windows.Forms.Label mnuTrangChu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView data_HOCSINH;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Button btnBaoCao;
    }
}