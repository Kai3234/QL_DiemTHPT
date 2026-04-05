namespace QL_DiemTHPT
{
    partial class FrmDOIMATKHAU
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
            this.label13 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Đổi Mật Khẩu";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Calibri", 14F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label13.Location = new System.Drawing.Point(64, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 30);
            this.label13.TabIndex = 46;
            this.label13.Text = "Mật khẩu mới:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(68, 214);
            this.txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(402, 30);
            this.txtMatKhauMoi.TabIndex = 45;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnQuayLai.Location = new System.Drawing.Point(543, 259);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(164, 41);
            this.btnQuayLai.TabIndex = 43;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label6.Location = new System.Drawing.Point(65, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 30);
            this.label6.TabIndex = 42;
            this.label6.Text = "Mật khẩu hiện tại:";
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.txtMatKhauHienTai.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtMatKhauHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(68, 121);
            this.txtMatKhauHienTai.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.PasswordChar = '*';
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(402, 30);
            this.txtMatKhauHienTai.TabIndex = 41;
            this.txtMatKhauHienTai.TextChanged += new System.EventHandler(this.txtMatKhauHienTai_TextChanged);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(153)))));
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.btnDoiMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.btnDoiMatKhau.Location = new System.Drawing.Point(543, 171);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(164, 41);
            this.btnDoiMatKhau.TabIndex = 39;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.label2.Location = new System.Drawing.Point(65, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 48;
            this.label2.Text = "Xác nhận mật khẩu:";
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.txtXacNhanMatKhau.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(96)))), ((int)(((byte)(113)))));
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(69, 302);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(402, 30);
            this.txtXacNhanMatKhau.TabIndex = 47;
            // 
            // FrmDOIMATKHAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 515);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.label1);
            this.Name = "FrmDOIMATKHAU";
            this.Text = "FrmDOIMATKHAU";
            this.Load += new System.EventHandler(this.FrmDOIMATKHAU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
    }
}