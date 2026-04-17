namespace QL_DiemTHPT
{
    partial class FrmMAINGV
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
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.giaovienTableAdapter1 = new QL_DiemTHPT.QL_DIEMTHPTDataSet1TableAdapters.GIAOVIENTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
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
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 593);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(282, 42);
            this.btnDangXuat.TabIndex = 23;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QL_DiemTHPT.Properties.Resources.user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(21, 539);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.mnuTaiKhoan.Location = new System.Drawing.Point(67, 539);
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuTaiKhoan.Size = new System.Drawing.Size(215, 40);
            this.mnuTaiKhoan.TabIndex = 21;
            this.mnuTaiKhoan.Text = "Giáo viên";
            this.mnuTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.label11.Location = new System.Drawing.Point(16, 62);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label11.Size = new System.Drawing.Size(165, 24);
            this.label11.TabIndex = 20;
            this.label11.Text = "Dành cho Giáo viên";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuChuNhiem
            // 
            this.mnuChuNhiem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuChuNhiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(146)))));
            this.mnuChuNhiem.Location = new System.Drawing.Point(3, 199);
            this.mnuChuNhiem.Name = "mnuChuNhiem";
            this.mnuChuNhiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuChuNhiem.Size = new System.Drawing.Size(279, 40);
            this.mnuChuNhiem.TabIndex = 14;
            this.mnuChuNhiem.Text = "Lớp chủ nhiệm";
            this.mnuChuNhiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuChuNhiem.Click += new System.EventHandler(this.mnuChuNhiem_Click);
            // 
            // mnuNhapDiem
            // 
            this.mnuNhapDiem.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuNhapDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(146)))));
            this.mnuNhapDiem.Location = new System.Drawing.Point(3, 159);
            this.mnuNhapDiem.Name = "mnuNhapDiem";
            this.mnuNhapDiem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuNhapDiem.Size = new System.Drawing.Size(279, 40);
            this.mnuNhapDiem.TabIndex = 13;
            this.mnuNhapDiem.Text = "Nhập điểm";
            this.mnuNhapDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuNhapDiem.Click += new System.EventHandler(this.mnuNhapDiem_Click);
            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.BackColor = System.Drawing.Color.GhostWhite;
            this.mnuTrangChu.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.mnuTrangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.mnuTrangChu.Location = new System.Drawing.Point(3, 119);
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mnuTrangChu.Size = new System.Drawing.Size(279, 40);
            this.mnuTrangChu.TabIndex = 12;
            this.mnuTrangChu.Text = "Trang chủ";
            this.mnuTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuTrangChu.Click += new System.EventHandler(this.mnuTrangChu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btnThoat.Location = new System.Drawing.Point(0, 649);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(282, 55);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐIỂM THPT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(278, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 93);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Calibri", 28F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(741, 93);
            this.label2.TabIndex = 0;
            this.label2.Text = "TRANG CHỦ GIÁO VIÊN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(93)))), ((int)(((byte)(173)))));
            this.pictureBox1.BackgroundImage = global::QL_DiemTHPT.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(1061, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 93);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label15.Location = new System.Drawing.Point(331, 476);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(552, 100);
            this.label15.TabIndex = 45;
            this.label15.Text = "Vui lòng chọn chức năng từ menu bên trái để bắt đầu sử dụng hệ thống.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(315, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 342);
            this.panel3.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label6.Location = new System.Drawing.Point(58, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(857, 91);
            this.label6.TabIndex = 45;
            this.label6.Text = "- Để xem thông tin của tài khoản, nhấn Giáo viên cạnh biểu tượng người dùng";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label5.Location = new System.Drawing.Point(58, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(857, 64);
            this.label5.TabIndex = 44;
            this.label5.Text = "- Nếu bạn có lớp là chủ nhiệm, bạn có thể xem tình hình lớp đó";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label4.Location = new System.Drawing.Point(58, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(797, 50);
            this.label4.TabIndex = 43;
            this.label4.Text = "- Bạn có thể nhập điểm cho môn của các lớp mình dạy";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(902, 91);
            this.label3.TabIndex = 24;
            this.label3.Text = "Chào mừng đến với trang giáo viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // giaovienTableAdapter1
            // 
            this.giaovienTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmMAINGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1419, 713);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmMAINGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMAINGV";
            this.Load += new System.EventHandler(this.FrmMAINGV_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private QL_DIEMTHPTDataSet1TableAdapters.GIAOVIENTableAdapter giaovienTableAdapter1;
        private System.Windows.Forms.Label label6;
    }
}