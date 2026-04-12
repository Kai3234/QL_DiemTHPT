namespace QL_DiemTHPT
{
    partial class FrmLOPCHUNHIEM
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.mnuTaiKhoan = new System.Windows.Forms.Label();
            this.mnuNhapDiem = new System.Windows.Forms.Label();
            this.mnuChuNhiem = new System.Windows.Forms.Label();
            this.mnuTrangChu = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTieuDeForm = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dgvLopChuNhiem = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnLuuDiem = new System.Windows.Forms.Button();

            this.lblTX = new System.Windows.Forms.Label();
            this.txtDIEMTX = new System.Windows.Forms.TextBox();
            this.lblGK = new System.Windows.Forms.Label();
            this.txtDIEMGK = new System.Windows.Forms.TextBox();
            this.lblCK = new System.Windows.Forms.Label();
            this.txtDIEMCK = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLopChuNhiem)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();

            this.lblTX.Text = "Điểm TX:";
            this.lblTX.Location = new System.Drawing.Point(20, 20);
            this.txtDIEMTX.Location = new System.Drawing.Point(80, 17);
            this.txtDIEMTX.Size = new System.Drawing.Size(60, 20);

            this.lblGK.Text = "Điểm GK:";
            this.lblGK.Location = new System.Drawing.Point(160, 20);
            this.txtDIEMGK.Location = new System.Drawing.Point(220, 17);
            this.txtDIEMGK.Size = new System.Drawing.Size(60, 20);

            this.lblCK.Text = "Điểm CK:";
            this.lblCK.Location = new System.Drawing.Point(300, 20);
            this.txtDIEMCK.Location = new System.Drawing.Point(360, 17);
            this.txtDIEMCK.Size = new System.Drawing.Size(60, 20);

            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.Location = new System.Drawing.Point(440, 15);
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);

            // Thêm các control vào panel
            this.panelFilter.Controls.Add(this.lblTX);
            this.panelFilter.Controls.Add(this.txtDIEMTX);
            this.panelFilter.Controls.Add(this.lblGK);
            this.panelFilter.Controls.Add(this.txtDIEMGK);
            this.panelFilter.Controls.Add(this.lblCK);
            this.panelFilter.Controls.Add(this.txtDIEMCK);
            this.panelFilter.Controls.Add(this.btnLuuDiem);

            // Gán sự kiện cho bảng
            this.dgvLopChuNhiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLopChuNhiem_CellClick);

            // Layout chung
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Name = "FrmLOPCHUNHIEM";
            this.Text = "Giáo Viên - Quản Lý Lớp Chủ Nhiệm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopChuNhiem)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label mnuTaiKhoan;
        private System.Windows.Forms.Label mnuNhapDiem;
        private System.Windows.Forms.Label mnuChuNhiem;
        private System.Windows.Forms.Label mnuTrangChu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTieuDeForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dgvLopChuNhiem;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Button btnLuuDiem;

        private System.Windows.Forms.Label lblTX;
        private System.Windows.Forms.TextBox txtDIEMTX;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.TextBox txtDIEMGK;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.TextBox txtDIEMCK;
    }
}