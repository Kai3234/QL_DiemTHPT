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
            this.label11 = new System.Windows.Forms.Label();
            this.mnuChuNhiem = new System.Windows.Forms.Label();
            this.mnuNhapDiem = new System.Windows.Forms.Label();
            this.mnuTrangChu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.mnuTaiKhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblMon = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.groupBoxNhapDiem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDIEMTX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDIEMGK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDIEMCK = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.lblHuongDan = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxFilters.SuspendLayout();
            this.groupBoxNhapDiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.mnuChuNhiem);
            this.panel1.Controls.Add(this.mnuNhapDiem);
            this.panel1.Controls.Add(this.mnuTrangChu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.mnuTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 411);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.label11.Location = new System.Drawing.Point(3, 55);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(152, 19);
            this.label11.TabIndex = 32;
            this.label11.Text = "Dành cho Giáo viên";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuChuNhiem
            // 
            this.mnuChuNhiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.mnuChuNhiem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuChuNhiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(146)))));
            this.mnuChuNhiem.Location = new System.Drawing.Point(-10, 192);
            this.mnuChuNhiem.Name = "mnuChuNhiem";
            this.mnuChuNhiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuChuNhiem.Size = new System.Drawing.Size(279, 40);
            this.mnuChuNhiem.TabIndex = 31;
            this.mnuChuNhiem.Text = "Lớp chủ nhiệm";
            this.mnuChuNhiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuChuNhiem.Click += new System.EventHandler(this.mnuChuNhiem_Click);
            // 
            // mnuNhapDiem
            // 
            this.mnuNhapDiem.BackColor = System.Drawing.Color.GhostWhite;
            this.mnuNhapDiem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuNhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.mnuNhapDiem.Location = new System.Drawing.Point(-10, 152);
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuNhapDiem.Size = new System.Drawing.Size(279, 40);
            this.mnuNhapDiem.TabIndex = 30;
            this.mnuNhapDiem.Text = "Nhập điểm";
            this.mnuNhapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.mnuTrangChu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(146)))));
            this.mnuTrangChu.Location = new System.Drawing.Point(-10, 112);
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuTrangChu.Size = new System.Drawing.Size(279, 40);
            this.mnuTrangChu.TabIndex = 29;
            this.mnuTrangChu.Text = "Trang chủ";
            this.mnuTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuTrangChu.Click += new System.EventHandler(this.mnuTrangChu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.label6.Location = new System.Drawing.Point(1, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = "QUẢN LÝ ĐIỂM THPT";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDangXuat.Location = new System.Drawing.Point(-24, 639);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(282, 42);
            this.btnDangXuat.TabIndex = 27;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QL_DiemTHPT.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(13, 587);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(59, 587);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(215, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "Giáo viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btnThoat.Location = new System.Drawing.Point(0, 356);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(251, 55);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.mnuTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(50, 12);
            this.mnuTaiKhoan.TabIndex = 5;
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(251, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 64);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.lblNamHoc);
            this.groupBoxFilters.Controls.Add(this.cboNamHoc);
            this.groupBoxFilters.Controls.Add(this.lblHocKy);
            this.groupBoxFilters.Controls.Add(this.cboHocKy);
            this.groupBoxFilters.Controls.Add(this.lblLop);
            this.groupBoxFilters.Controls.Add(this.cboLop);
            this.groupBoxFilters.Controls.Add(this.lblMon);
            this.groupBoxFilters.Controls.Add(this.cboMonHoc);
            this.groupBoxFilters.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFilters.Location = new System.Drawing.Point(255, 68);
            this.groupBoxFilters.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFilters.Size = new System.Drawing.Size(1145, 73);
            this.groupBoxFilters.TabIndex = 3;
            this.groupBoxFilters.TabStop = false;
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.lblNamHoc.Location = new System.Drawing.Point(15, 36);
            this.lblNamHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(84, 23);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(109, 34);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(177, 31);
            this.cboNamHoc.TabIndex = 1;
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.lblHocKy.Location = new System.Drawing.Point(300, 37);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(67, 23);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(375, 33);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(127, 31);
            this.cboHocKy.TabIndex = 3;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.lblLop.Location = new System.Drawing.Point(533, 34);
            this.lblLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(45, 23);
            this.lblLop.TabIndex = 4;
            this.lblLop.Text = "Lớp:";
            // 
            // cboLop
            // 
            this.cboLop.Location = new System.Drawing.Point(582, 34);
            this.cboLop.Margin = new System.Windows.Forms.Padding(2);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(177, 31);
            this.cboLop.TabIndex = 5;
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.lblMon.Location = new System.Drawing.Point(775, 35);
            this.lblMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(84, 23);
            this.lblMon.TabIndex = 6;
            this.lblMon.Text = "Môn học:";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Location = new System.Drawing.Point(869, 33);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(227, 31);
            this.cboMonHoc.TabIndex = 7;
            // 
            // groupBoxNhapDiem
            // 
            this.groupBoxNhapDiem.Controls.Add(this.label3);
            this.groupBoxNhapDiem.Controls.Add(this.txtDIEMTX);
            this.groupBoxNhapDiem.Controls.Add(this.label4);
            this.groupBoxNhapDiem.Controls.Add(this.txtDIEMGK);
            this.groupBoxNhapDiem.Controls.Add(this.label5);
            this.groupBoxNhapDiem.Controls.Add(this.txtDIEMCK);
            this.groupBoxNhapDiem.Controls.Add(this.btnLuu);
            this.groupBoxNhapDiem.Controls.Add(this.btnBaoCao);
            this.groupBoxNhapDiem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNhapDiem.Location = new System.Drawing.Point(255, 151);
            this.groupBoxNhapDiem.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxNhapDiem.Name = "groupBoxNhapDiem";
            this.groupBoxNhapDiem.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxNhapDiem.Size = new System.Drawing.Size(1145, 73);
            this.groupBoxNhapDiem.TabIndex = 2;
            this.groupBoxNhapDiem.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm TX:";
            // 
            // txtDIEMTX
            // 
            this.txtDIEMTX.Location = new System.Drawing.Point(104, 36);
            this.txtDIEMTX.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIEMTX.Name = "txtDIEMTX";
            this.txtDIEMTX.Size = new System.Drawing.Size(77, 31);
            this.txtDIEMTX.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(187, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm GK:";
            // 
            // txtDIEMGK
            // 
            this.txtDIEMGK.Location = new System.Drawing.Point(278, 33);
            this.txtDIEMGK.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIEMGK.Name = "txtDIEMGK";
            this.txtDIEMGK.Size = new System.Drawing.Size(77, 31);
            this.txtDIEMGK.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label5.Location = new System.Drawing.Point(382, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm CK:";
            // 
            // txtDIEMCK
            // 
            this.txtDIEMCK.Location = new System.Drawing.Point(472, 34);
            this.txtDIEMCK.Margin = new System.Windows.Forms.Padding(2);
            this.txtDIEMCK.Name = "txtDIEMCK";
            this.txtDIEMCK.Size = new System.Drawing.Size(77, 31);
            this.txtDIEMCK.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnLuu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(636, 26);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 36);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu điểm";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBaoCao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(832, 26);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(148, 36);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "Xuất báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHuongDan.AutoSize = true;
            this.lblHuongDan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblHuongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHuongDan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHuongDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(152)))));
            this.lblHuongDan.Location = new System.Drawing.Point(255, 231);
            this.lblHuongDan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(510, 32);
            this.lblHuongDan.TabIndex = 1;
            this.lblHuongDan.Text = " Chọn lớp và môn học để hiển thị điểm học sinh ";
            this.lblHuongDan.Click += new System.EventHandler(this.lblHuongDan_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.ColumnHeadersHeight = 46;
            this.dgvDiem.Location = new System.Drawing.Point(255, 265);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 82;
            this.dgvDiem.Size = new System.Drawing.Size(1145, 468);
            this.dgvDiem.TabIndex = 0;
            // 
            // FrmNHAPDIEMMON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 411);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.groupBoxNhapDiem);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmNHAPDIEMMON";
            this.Text = "NHẬP ĐIỂM MÔN HỌC";
            this.Load += new System.EventHandler(this.FrmNHAPDIEMMON_Load_2);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.groupBoxNhapDiem.ResumeLayout(false);
            this.groupBoxNhapDiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1, panel2;
        private System.Windows.Forms.Label label1, mnuTaiKhoan, lblHuongDan;
        private System.Windows.Forms.Button btnLuu, btnBaoCao;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.GroupBox groupBoxFilters, groupBoxNhapDiem;
        private System.Windows.Forms.Label lblNamHoc, lblHocKy, lblLop, lblMon, label3, label4, label5;
        private System.Windows.Forms.ComboBox cboNamHoc, cboHocKy, cboLop, cboMonHoc;
        private System.Windows.Forms.TextBox txtDIEMTX, txtDIEMGK, txtDIEMCK;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mnuChuNhiem;
        private System.Windows.Forms.Label mnuNhapDiem;
        private System.Windows.Forms.Label mnuTrangChu;
        private System.Windows.Forms.Label label6;
    }
}