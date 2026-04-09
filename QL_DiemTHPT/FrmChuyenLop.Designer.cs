namespace QL_DiemTHPT
{
    partial class FrmChuyenLop
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.data_HOCSINH_LOP = new System.Windows.Forms.DataGridView();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mALOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOCSINHLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DIEMTHPTDataSet6 = new QL_DiemTHPT.QL_DIEMTHPTDataSet6();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cobLopMoi = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_DIEMTHPTDataSet7 = new QL_DiemTHPT.QL_DIEMTHPTDataSet7();
            this.cobLopCu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLopMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLopCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChuyenLop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hOCSINH_LOPTableAdapter = new QL_DiemTHPT.QL_DIEMTHPTDataSet6TableAdapters.HOCSINH_LOPTableAdapter();
            this.lOPTableAdapter = new QL_DiemTHPT.QL_DIEMTHPTDataSet7TableAdapters.LOPTableAdapter();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_HOCSINH_LOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DIEMTHPTDataSet6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DIEMTHPTDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.data_HOCSINH_LOP);
            this.panel5.Location = new System.Drawing.Point(99, 346);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1049, 257);
            this.panel5.TabIndex = 30;
            // 
            // data_HOCSINH_LOP
            // 
            this.data_HOCSINH_LOP.AutoGenerateColumns = false;
            this.data_HOCSINH_LOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_HOCSINH_LOP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.data_HOCSINH_LOP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(143)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_HOCSINH_LOP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.data_HOCSINH_LOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_HOCSINH_LOP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATKHAU,
            this.mALOPDataGridViewTextBoxColumn,
            this.mAHSDataGridViewTextBoxColumn});
            this.data_HOCSINH_LOP.DataSource = this.hOCSINHLOPBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_HOCSINH_LOP.DefaultCellStyle = dataGridViewCellStyle11;
            this.data_HOCSINH_LOP.EnableHeadersVisualStyles = false;
            this.data_HOCSINH_LOP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.data_HOCSINH_LOP.Location = new System.Drawing.Point(19, 16);
            this.data_HOCSINH_LOP.Name = "data_HOCSINH_LOP";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_HOCSINH_LOP.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.data_HOCSINH_LOP.Size = new System.Drawing.Size(1008, 227);
            this.data_HOCSINH_LOP.TabIndex = 0;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "MATKHAU";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Visible = false;
            // 
            // mALOPDataGridViewTextBoxColumn
            // 
            this.mALOPDataGridViewTextBoxColumn.DataPropertyName = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.HeaderText = "MALOP";
            this.mALOPDataGridViewTextBoxColumn.Name = "mALOPDataGridViewTextBoxColumn";
            // 
            // mAHSDataGridViewTextBoxColumn
            // 
            this.mAHSDataGridViewTextBoxColumn.DataPropertyName = "MAHS";
            this.mAHSDataGridViewTextBoxColumn.HeaderText = "MAHS";
            this.mAHSDataGridViewTextBoxColumn.Name = "mAHSDataGridViewTextBoxColumn";
            // 
            // hOCSINHLOPBindingSource
            // 
            this.hOCSINHLOPBindingSource.DataMember = "HOCSINH_LOP";
            this.hOCSINHLOPBindingSource.DataSource = this.qL_DIEMTHPTDataSet6;
            // 
            // qL_DIEMTHPTDataSet6
            // 
            this.qL_DIEMTHPTDataSet6.DataSetName = "QL_DIEMTHPTDataSet6";
            this.qL_DIEMTHPTDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.cobLopMoi);
            this.panel4.Controls.Add(this.cobLopCu);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtTenLopMoi);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtTenLopCu);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnChuyenLop);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(99, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1049, 250);
            this.panel4.TabIndex = 31;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cobLopMoi
            // 
            this.cobLopMoi.DataSource = this.lOPBindingSource;
            this.cobLopMoi.DisplayMember = "MALOP";
            this.cobLopMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobLopMoi.FormattingEnabled = true;
            this.cobLopMoi.Location = new System.Drawing.Point(404, 101);
            this.cobLopMoi.Name = "cobLopMoi";
            this.cobLopMoi.Size = new System.Drawing.Size(237, 28);
            this.cobLopMoi.TabIndex = 43;
            this.cobLopMoi.ValueMember = "TENLOP";
            this.cobLopMoi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qL_DIEMTHPTDataSet7;
            // 
            // qL_DIEMTHPTDataSet7
            // 
            this.qL_DIEMTHPTDataSet7.DataSetName = "QL_DIEMTHPTDataSet7";
            this.qL_DIEMTHPTDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cobLopCu
            // 
            this.cobLopCu.DataSource = this.lOPBindingSource;
            this.cobLopCu.DisplayMember = "MALOP";
            this.cobLopCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobLopCu.FormattingEnabled = true;
            this.cobLopCu.Location = new System.Drawing.Point(89, 102);
            this.cobLopCu.Name = "cobLopCu";
            this.cobLopCu.Size = new System.Drawing.Size(237, 28);
            this.cobLopCu.TabIndex = 42;
            this.cobLopCu.ValueMember = "TENLOP";
            this.cobLopCu.SelectedIndexChanged += new System.EventHandler(this.cobLopMoi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label3.Location = new System.Drawing.Point(400, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 30);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tên lớp mới:";
            // 
            // txtTenLopMoi
            // 
            this.txtTenLopMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.txtTenLopMoi.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtTenLopMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.txtTenLopMoi.Location = new System.Drawing.Point(405, 188);
            this.txtTenLopMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLopMoi.Name = "txtTenLopMoi";
            this.txtTenLopMoi.ReadOnly = true;
            this.txtTenLopMoi.Size = new System.Drawing.Size(236, 30);
            this.txtTenLopMoi.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(85, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên lớp cũ:";
            // 
            // txtTenLopCu
            // 
            this.txtTenLopCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.txtTenLopCu.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtTenLopCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.txtTenLopCu.Location = new System.Drawing.Point(90, 193);
            this.txtTenLopCu.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLopCu.Name = "txtTenLopCu";
            this.txtTenLopCu.ReadOnly = true;
            this.txtTenLopCu.Size = new System.Drawing.Size(236, 30);
            this.txtTenLopCu.TabIndex = 38;
            this.txtTenLopCu.TextChanged += new System.EventHandler(this.txtTenLopCu_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label1.Location = new System.Drawing.Point(400, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã lớp mới:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnChuyenLop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnChuyenLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenLop.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnChuyenLop.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnChuyenLop.Location = new System.Drawing.Point(837, 182);
            this.btnChuyenLop.Margin = new System.Windows.Forms.Padding(2);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(190, 41);
            this.btnChuyenLop.TabIndex = 35;
            this.btnChuyenLop.Text = "Chuyển Lớp";
            this.btnChuyenLop.UseVisualStyleBackColor = false;
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label5.Location = new System.Drawing.Point(85, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 30);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã lớp cũ:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(453, 40);
            this.label4.TabIndex = 24;
            this.label4.Text = "Thay đổi tất cả học sinh của 1 lớp";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // hOCSINH_LOPTableAdapter
            // 
            this.hOCSINH_LOPTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btnXoa.Location = new System.Drawing.Point(837, 124);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(190, 41);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Chỉ xóa Lớp cũ";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btnThoat.Location = new System.Drawing.Point(936, 22);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(282, 55);
            this.btnThoat.TabIndex = 45;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 685);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Name = "FrmChuyenLop";
            this.Text = "FrmChuyenLop";
            this.Load += new System.EventHandler(this.FrmChuyenLop_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_HOCSINH_LOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DIEMTHPTDataSet6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_DIEMTHPTDataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView data_HOCSINH_LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChuyenLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private QL_DIEMTHPTDataSet6 qL_DIEMTHPTDataSet6;
        private System.Windows.Forms.BindingSource hOCSINHLOPBindingSource;
        private QL_DIEMTHPTDataSet6TableAdapters.HOCSINH_LOPTableAdapter hOCSINH_LOPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mALOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLopMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLopCu;
        private System.Windows.Forms.ComboBox cobLopMoi;
        private System.Windows.Forms.ComboBox cobLopCu;
        private QL_DIEMTHPTDataSet7 qL_DIEMTHPTDataSet7;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QL_DIEMTHPTDataSet7TableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}