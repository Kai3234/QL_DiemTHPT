namespace QL_DiemTHPT
{
    partial class FrmNHAPDIEMMON
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mnuTaiKhoan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mnuChuNhiem = new System.Windows.Forms.Label();
            this.mnuNhapDiem = new System.Windows.Forms.Label();
            this.mnuTrangChu = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.lblThongKe = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();

            // panel1
            this.panel1.BackColor = System.Drawing.Color.FromArgb(240, 241, 242);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.mnuTaiKhoan);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.mnuChuNhiem);
            this.panel1.Controls.Add(this.mnuNhapDiem);
            this.panel1.Controls.Add(this.mnuTrangChu);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 704);
            this.panel1.TabIndex = 1;

            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.btnDangXuat.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 593);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(282, 42);
            this.btnDangXuat.TabIndex = 23;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

            this.pictureBox2.BackgroundImage = global::QL_DiemTHPT.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(21, 539);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;

            this.mnuTaiKhoan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(83, 96, 113);
            this.mnuTaiKhoan.Location = new System.Drawing.Point(67, 539);
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuTaiKhoan.Size = new System.Drawing.Size(215, 40);
            this.mnuTaiKhoan.TabIndex = 21;
            this.mnuTaiKhoan.Text = "Giáo viên";
            this.mnuTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);

            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(170, 171, 172);
            this.label11.Location = new System.Drawing.Point(16, 62);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(165, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Dành cho Giáo viên";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.mnuChuNhiem.BackColor = System.Drawing.Color.FromArgb(240, 241, 242);
            this.mnuChuNhiem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuChuNhiem.ForeColor = System.Drawing.Color.FromArgb(145, 143, 146);
            this.mnuChuNhiem.Location = new System.Drawing.Point(3, 199);
            this.mnuChuNhiem.Name = "mnuChuNhiem";
            this.mnuChuNhiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuChuNhiem.Size = new System.Drawing.Size(279, 40);
            this.mnuChuNhiem.TabIndex = 14;
            this.mnuChuNhiem.Text = "Lớp chủ nhiệm";
            this.mnuChuNhiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuChuNhiem.Click += new System.EventHandler(this.mnuChuNhiem_Click);

            this.mnuNhapDiem.BackColor = System.Drawing.Color.GhostWhite;
            this.mnuNhapDiem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuNhapDiem.ForeColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.mnuNhapDiem.Location = new System.Drawing.Point(3, 159);
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuNhapDiem.Size = new System.Drawing.Size(279, 40);
            this.mnuNhapDiem.TabIndex = 13;
            this.mnuNhapDiem.Text = "Nhập điểm";
            this.mnuNhapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);

            this.mnuTrangChu.BackColor = System.Drawing.Color.FromArgb(240, 241, 242);
            this.mnuTrangChu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuTrangChu.ForeColor = System.Drawing.Color.FromArgb(145, 143, 146);
            this.mnuTrangChu.Location = new System.Drawing.Point(3, 119);
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuTrangChu.Size = new System.Drawing.Size(279, 40);
            this.mnuTrangChu.TabIndex = 12;
            this.mnuTrangChu.Text = "Trang chủ";
            this.mnuTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuTrangChu.Click += new System.EventHandler(this.mnuTrangChu_Click);

            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(83, 96, 113);
            this.btnThoat.Location = new System.Drawing.Point(0, 649);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(282, 55);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM THPT";

            // panel2
            this.panel2.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(278, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 93);
            this.panel2.TabIndex = 11;

            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(741, 93);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHẬP ĐIỂM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(37, 93, 173);
            this.pictureBox1.BackgroundImage = global::QL_DiemTHPT.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1061, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 93);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.GhostWhite;
            this.panelContent.Controls.Add(this.panelFilter);
            this.panelContent.Controls.Add(this.lblThongKe);
            this.panelContent.Controls.Add(this.dgvDiem);
            this.panelContent.Location = new System.Drawing.Point(278, 94);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1141, 619);
            this.panelContent.TabIndex = 12;

            // panelFilter
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(245, 246, 247);
            this.panelFilter.Controls.Add(this.lblNamHoc);
            this.panelFilter.Controls.Add(this.cboNamHoc);
            this.panelFilter.Controls.Add(this.lblHocKy);
            this.panelFilter.Controls.Add(this.cboHocKy);
            this.panelFilter.Controls.Add(this.lblLop);
            this.panelFilter.Controls.Add(this.cboLop);
            this.panelFilter.Controls.Add(this.lblMonHoc);
            this.panelFilter.Controls.Add(this.cboMonHoc);
            this.panelFilter.Controls.Add(this.btnLuuDiem);
            this.panelFilter.Controls.Add(this.btnBaoCao);
            this.panelFilter.Location = new System.Drawing.Point(10, 10);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1120, 100);
            this.panelFilter.TabIndex = 0;

            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(83, 96, 113);
            this.lblNamHoc.Location = new System.Drawing.Point(10, 13);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Text = "Năm học:";

            this.cboNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNamHoc.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboNamHoc.Location = new System.Drawing.Point(90, 8);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(155, 30);
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);

            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblHocKy.ForeColor = System.Drawing.Color.FromArgb(83, 96, 113);
            this.lblHocKy.Location = new System.Drawing.Point(260, 13);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Text = "Học kỳ:";

            this.cboHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocKy.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboHocKy.Location = new System.Drawing.Point(325, 8);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(120, 30);
            this.cboHocKy.TabIndex = 2;
            this.cboHocKy.SelectedIndexChanged += new System.EventHandler(this.cboHocKy_SelectedIndexChanged);

            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblLop.ForeColor = System.Drawing.Color.FromArgb(83, 96, 113);
            this.lblLop.Location = new System.Drawing.Point(460, 13);
            this.lblLop.Name = "lblLop";
            this.lblLop.Text = "Lớp:";

            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboLop.Location = new System.Drawing.Point(500, 8);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(200, 30);
            this.cboLop.TabIndex = 3;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);

            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonHoc.ForeColor = System.Drawing.Color.FromArgb(83, 96, 113);
            this.lblMonHoc.Location = new System.Drawing.Point(715, 13);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Text = "Môn học:";

            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.Font = new System.Drawing.Font("Calibri", 12F);
            this.cboMonHoc.Location = new System.Drawing.Point(795, 8);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(200, 30);
            this.cboMonHoc.TabIndex = 4;
            this.cboMonHoc.SelectedIndexChanged += new System.EventHandler(this.cboMonHoc_SelectedIndexChanged);

            this.btnLuuDiem.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.btnLuuDiem.FlatAppearance.BorderSize = 0;
            this.btnLuuDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDiem.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnLuuDiem.ForeColor = System.Drawing.Color.White;
            this.btnLuuDiem.Location = new System.Drawing.Point(10, 55);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(140, 36);
            this.btnLuuDiem.TabIndex = 5;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = false;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);

            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(160, 55);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(160, 36);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Xuất báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);

            this.lblThongKe.BackColor = System.Drawing.Color.FromArgb(235, 241, 250);
            this.lblThongKe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblThongKe.ForeColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.lblThongKe.Location = new System.Drawing.Point(10, 118);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblThongKe.Size = new System.Drawing.Size(1110, 28);
            this.lblThongKe.TabIndex = 1;
            this.lblThongKe.Text = "Chọn lớp và môn học để hiển thị điểm";
            this.lblThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgvDiem.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 74, 153);
            this.dgvDiem.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDiem.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiem.ColumnHeadersHeight = 35;
            this.dgvDiem.DefaultCellStyle.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvDiem.Location = new System.Drawing.Point(10, 153);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(1120, 455);
            this.dgvDiem.TabIndex = 2;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1419, 713);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmNHAPDIEMMON";
            this.Text = "Nhập điểm môn học";
            this.Load += new System.EventHandler(this.FrmNHAPDIEMMON_Load);

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mnuTrangChu;
        private System.Windows.Forms.Label mnuChuNhiem;
        private System.Windows.Forms.Label mnuNhapDiem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mnuTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Button btnLuuDiem;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.DataGridView dgvDiem;
    }
}