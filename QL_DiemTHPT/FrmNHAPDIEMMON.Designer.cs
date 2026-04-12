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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemGK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.txtDIEMCK = new System.Windows.Forms.TextBox();
            this.lblCK = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtDIEMGK = new System.Windows.Forms.TextBox();
            this.cboNamHoc = new System.Windows.Forms.ComboBox();
            this.lblGK = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.txtDIEMTX = new System.Windows.Forms.TextBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblTX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.panelFilter.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.AliceBlue;
            this.panelFilter.Controls.Add(this.panel3);
            this.panelFilter.Controls.Add(this.groupBox1);
            this.panelFilter.Controls.Add(this.panel2);
            this.panelFilter.Controls.Add(this.panel1);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(2724, 790);
            this.panelFilter.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(412, 469);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2306, 321);
            this.panel3.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTen,
            this.Lop,
            this.DiemTX,
            this.DiemGK,
            this.DiemCK});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(2306, 321);
            this.dataGridView1.TabIndex = 0;
            //this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaHS
            // 
            this.MaHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHS.HeaderText = "Mã HS";
            this.MaHS.MinimumWidth = 10;
            this.MaHS.Name = "MaHS";
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 10;
            this.HoTen.Name = "HoTen";
            // 
            // Lop
            // 
            this.Lop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 10;
            this.Lop.Name = "Lop";
            // 
            // DiemTX
            // 
            this.DiemTX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemTX.HeaderText = "Điểm TX";
            this.DiemTX.MinimumWidth = 10;
            this.DiemTX.Name = "DiemTX";
            // 
            // DiemGK
            // 
            this.DiemGK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemGK.HeaderText = "Điểm GK";
            this.DiemGK.MinimumWidth = 10;
            this.DiemGK.Name = "DiemGK";
            // 
            // DiemCK
            // 
            this.DiemCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiemCK.HeaderText = "Điểm CK";
            this.DiemCK.MinimumWidth = 10;
            this.DiemCK.Name = "DiemCK";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnLuuDiem);
            this.groupBox1.Controls.Add(this.txtDIEMCK);
            this.groupBox1.Controls.Add(this.lblCK);
            this.groupBox1.Controls.Add(this.lblNamHoc);
            this.groupBox1.Controls.Add(this.txtDIEMGK);
            this.groupBox1.Controls.Add(this.cboNamHoc);
            this.groupBox1.Controls.Add(this.lblGK);
            this.groupBox1.Controls.Add(this.lblHocKy);
            this.groupBox1.Controls.Add(this.txtDIEMTX);
            this.groupBox1.Controls.Add(this.cboHocKy);
            this.groupBox1.Controls.Add(this.lblTX);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(412, 204);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(2306, 254);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnLuuDiem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuDiem.Location = new System.Drawing.Point(1088, 148);
            this.btnLuuDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(174, 96);
            this.btnLuuDiem.TabIndex = 10;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = false;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // txtDIEMCK
            // 
            this.txtDIEMCK.Location = new System.Drawing.Point(756, 133);
            this.txtDIEMCK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDIEMCK.Name = "txtDIEMCK";
            this.txtDIEMCK.Size = new System.Drawing.Size(120, 39);
            this.txtDIEMCK.TabIndex = 9;
            // 
            // lblCK
            // 
            this.lblCK.Location = new System.Drawing.Point(640, 138);
            this.lblCK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCK.Name = "lblCK";
            this.lblCK.Size = new System.Drawing.Size(154, 60);
            this.lblCK.TabIndex = 8;
            this.lblCK.Text = "Điểm CK:";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.Location = new System.Drawing.Point(52, 83);
            this.lblNamHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(100, 39);
            this.lblNamHoc.TabIndex = 0;
            this.lblNamHoc.Text = "Năm học:";
            // 
            // txtDIEMGK
            // 
            this.txtDIEMGK.Location = new System.Drawing.Point(458, 133);
            this.txtDIEMGK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDIEMGK.Name = "txtDIEMGK";
            this.txtDIEMGK.Size = new System.Drawing.Size(106, 39);
            this.txtDIEMGK.TabIndex = 7;
            // 
            // cboNamHoc
            // 
            this.cboNamHoc.Location = new System.Drawing.Point(186, 77);
            this.cboNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNamHoc.Name = "cboNamHoc";
            this.cboNamHoc.Size = new System.Drawing.Size(120, 40);
            this.cboNamHoc.TabIndex = 1;
            this.cboNamHoc.SelectedIndexChanged += new System.EventHandler(this.cboNamHoc_SelectedIndexChanged);
            // 
            // lblGK
            // 
            this.lblGK.Location = new System.Drawing.Point(350, 138);
            this.lblGK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(138, 33);
            this.lblGK.TabIndex = 6;
            this.lblGK.Text = "Điểm GK:";
            // 
            // lblHocKy
            // 
            this.lblHocKy.Location = new System.Drawing.Point(350, 85);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(100, 37);
            this.lblHocKy.TabIndex = 2;
            this.lblHocKy.Text = "Học kỳ:";
            this.lblHocKy.Click += new System.EventHandler(this.lblHocKy_Click);
            // 
            // txtDIEMTX
            // 
            this.txtDIEMTX.Location = new System.Drawing.Point(186, 133);
            this.txtDIEMTX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDIEMTX.Name = "txtDIEMTX";
            this.txtDIEMTX.Size = new System.Drawing.Size(120, 39);
            this.txtDIEMTX.TabIndex = 5;
            // 
            // cboHocKy
            // 
            this.cboHocKy.Location = new System.Drawing.Point(458, 77);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(106, 40);
            this.cboHocKy.TabIndex = 3;
            // 
            // lblTX
            // 
            this.lblTX.Location = new System.Drawing.Point(52, 138);
            this.lblTX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTX.Name = "lblTX";
            this.lblTX.Size = new System.Drawing.Size(126, 33);
            this.lblTX.TabIndex = 4;
            this.lblTX.Text = "Điểm TX:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 598);
            this.panel2.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(6, 512);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(388, 75);
            this.button5.TabIndex = 7;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(6, 425);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(388, 75);
            this.button4.TabIndex = 6;
            this.button4.Text = "Đăng xuất";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(106, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_DiemTHPT.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(24, 342);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 69);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(14, 221);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(380, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quản lý điểm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(14, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(380, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quản lý giáo viên";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(14, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(380, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quản lý học sinh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 106);
            this.label2.TabIndex = 0;
            this.label2.Text = "QUẢN LÝ NHẬP ĐIỂM THPT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2724, 192);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(680, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHẬP ĐIỂM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeight = 46;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 82;
            this.dgvDiem.Size = new System.Drawing.Size(2724, 790);
            this.dgvDiem.TabIndex = 0;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // FrmNHAPDIEMMON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2724, 790);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.dgvDiem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNHAPDIEMMON";
            this.Text = "Quản lý nhập điểm";
            this.panelFilter.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        // Khai báo biến đầy đủ để file .cs không báo lỗi
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.ComboBox cboNamHoc;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Label lblTX;
        private System.Windows.Forms.TextBox txtDIEMTX;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.TextBox txtDIEMGK;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.TextBox txtDIEMCK;
        private System.Windows.Forms.Button btnLuuDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemGK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemCK;
    }
}