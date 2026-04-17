using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmQLHOCSINH : Form
    {
        public FrmQLHOCSINH()
        {
            InitializeComponent();
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            FrmMAINADMIN fnew = new FrmMAINADMIN();
            fnew.Show();
            this.Close();
        }

        private void mnuHocSinh_Click(object sender, EventArgs e)
        {
            FrmQLHOCSINH fnew = new FrmQLHOCSINH();
            fnew.Show();
            this.Close();
        }

        private void mnuGV_Click(object sender, EventArgs e)
        {
            FrmQLGIAOVIEN fnew = new FrmQLGIAOVIEN();
            fnew.Show();
            this.Close();
        }

        private void mnuNam_Click(object sender, EventArgs e)
        {
            FrmQLNAMHOC fnew = new FrmQLNAMHOC();
            fnew.Show();
            this.Close();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            FrmQLLOP fnew = new FrmQLLOP();
            fnew.Show();
            this.Close();
        }

        private void mnuHSLop_Click(object sender, EventArgs e)
        {
            FrmQLHOCSINH_LOP fnew = new FrmQLHOCSINH_LOP();
            fnew.Show();
            this.Close();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            FrmQLMONHOC fnew = new FrmQLMONHOC();
            fnew.Show();
            this.Close();
        }

        private void mnuPhanCong_Click(object sender, EventArgs e)
        {
            FrmQLPHANCONG fnew = new FrmQLPHANCONG();
            fnew.Show();
            this.Close();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap.MaNguoiDung = null;
            TaiKhoanDangNhap.LoaiNguoiDung = null;

            FrmLOGIN fnew = new FrmLOGIN();
            fnew.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        KETNOI_CSDL knn = new KETNOI_CSDL();

        public void LayBang_HOCSINH()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM HOCSINH");
            data_HOCSINH.DataSource = dta;
            HienThiDuLieu();
        }

        public void LayBang_NAMHOC()
        {
            DataTable dt = knn.LayBang(
            "SELECT MANH, TENNAM, MANH + ' | ' + TENNAM AS HIENTHI FROM NAMHOC");

            cboTimNH.DataSource = dt;
            cboTimNH.DisplayMember = "HIENTHI";
            cboTimNH.ValueMember = "MANH";
        }

        public void HienThiDuLieu()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", data_HOCSINH.DataSource, "MAHS");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", data_HOCSINH.DataSource, "HOTEN");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", data_HOCSINH.DataSource, "NGAYSINH");

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", data_HOCSINH.DataSource, "GIOITINH");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", data_HOCSINH.DataSource, "DIACHI");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", data_HOCSINH.DataSource, "MATKHAU");


        }

        private void FrmQLHOCSINH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DIEMTHPTDataSet10.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qL_DIEMTHPTDataSet10.HOCSINH);
            LayBang_NAMHOC();
            LayBang_HOCSINH();

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            cboGioiTinh.SelectedIndex = -1;
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtMa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string s1 = txtMa.Text;
            string s2 = txtHoTen.Text;
            string s3 = txtNgaySinh.Text;
            string s4 = cboGioiTinh.Text;
            string s5 = txtDiaChi.Text;
            string s6 = txtMatKhau.Text;

            if (txtMa.Text.Trim() == "" || txtHoTen.Text.Trim() == "" ||
                txtNgaySinh.Text.Trim() == "" || cboGioiTinh.Text == "" || txtDiaChi.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Xử lý dl trùng khóa
            string strKra = "SELECT MAHS FROM HOCSINH WHERE MAHS = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, knn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã HỌC SINH này đã tồn tại, nhập lại mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                doc_DL.Close();
                doc_DL.Dispose();

            }
            else
            {
                // Insert dl vao database
                DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);

                string sql_luu;
                sql_luu = "INSERT INTO HOCSINH " + "VALUES ('" + s1 + "', N'" + s2 + "'";
                sql_luu = sql_luu + ", '" + ngaySinh.ToString("yyyy-MM-dd") + "'";
                sql_luu = sql_luu + ", N'" + s4 + "', N'" + s5 + "', '" + s6 + "')";

                knn.ThucThi(sql_luu);
                LayBang_HOCSINH();
                HienThiDuLieu();
                doc_DL.Close();
                doc_DL.Dispose();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string s1 = txtMa.Text;
            string s2 = txtHoTen.Text;
            string s3 = txtNgaySinh.Text;
            string s4 = cboGioiTinh.Text;
            string s5 = txtDiaChi.Text;
            string s6 = txtMatKhau.Text;

            if (txtMa.Text.Trim() == "" || txtHoTen.Text.Trim() == "" ||
                txtNgaySinh.Text.Trim() == "" || cboGioiTinh.Text == "" || txtDiaChi.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string strKra = "SELECT MAHS FROM HOCSINH WHERE MAHS = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, knn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                // update dl trong database
                DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);

                string sql_sua;
                sql_sua = "UPDATE HOCSINH SET HOTEN = N'" + s2 + "'";
                sql_sua = sql_sua + ", NGAYSINH = '" + ngaySinh.ToString("yyyy-MM-dd") + "', GIOITINH = N'" + s4 + "'";
                sql_sua = sql_sua + ", DIACHI = N'" + s5 + "', MATKHAU = '" + s6 + "' ";
                sql_sua = sql_sua + "WHERE MAHS = '" + s1 + "'";
                knn.ThucThi(sql_sua);
                LayBang_HOCSINH();
                doc_DL.Close();
                doc_DL.Dispose();

            }
            else
            {
                MessageBox.Show("Mã HỌC SINH này không tồn tại, nhập lại mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                doc_DL.Close();
                doc_DL.Dispose();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "" )
            {
                MessageBox.Show("Vui lòng nhập mã học sinh!");
                return;
            }
            string strKra =
                "SELECT MAHS FROM HOCSINH_LOP WHERE MAHS = '" + txtMa.Text + "'" +
                " UNION " +
                "SELECT MAHS FROM DIEM WHERE MAHS = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, knn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã HỌC SINH này tồn tại ở bảng khác, nhập lại mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                doc_DL.Close();
                doc_DL.Dispose();
            }
            else
            {
                // delete dl trong database
                string sql_xoa = "DELETE FROM HOCSINH WHERE MAHS = '" + txtMa.Text + "'";
                knn.ThucThi(sql_xoa);
                LayBang_HOCSINH();
                doc_DL.Close();
                doc_DL.Dispose();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "";

            // ===== KHÔNG CHỌN NĂM HỌC =====
            if (!optNamHoc.Checked)
            {
                if (txtTimKiem.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin tìm kiếm!");
                    return;
                }

                if (cboTieuChiTim.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm!");
                    return;
                }

                string cotTim = LayCotTim();
                string giatri = txtTimKiem.Text.Trim();

                sql = $"SELECT * FROM HOCSINH h WHERE {cotTim} LIKE N'%{giatri}%'";
            }

            // ===== CHỌN NĂM HỌC =====
            else
            {
                if (cboTimNH.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng chọn năm học để tìm kiếm!");
                    return;
                }

                // query cơ bản theo năm học
                sql = $@"
                    SELECT DISTINCT h.*
                    FROM HOCSINH h
                    INNER JOIN HOCSINH_LOP hl ON h.MAHS = hl.MAHS
                    INNER JOIN LOP l ON hl.MALOP = l.MALOP
                    WHERE l.MANH = '{cboTimNH.SelectedValue.ToString()}'";

                // ===== nếu có nhập tiêu chí =====
                if (txtTimKiem.Text.Trim() != "" &&
                    cboTieuChiTim.Text.Trim() != "")
                {
                    string cotTim = LayCotTim();
                    string giatri = txtTimKiem.Text.Trim();

                    sql += $" AND {cotTim} LIKE N'%{giatri}%'";
                }
            }

            DataTable dta = knn.LayBang(sql);
            data_HOCSINH.DataSource = dta;
            HienThiDuLieu();
        }

        private string LayCotTim()
        {
            switch (cboTieuChiTim.Text)
            {
                case "Mã học sinh": return "h.MAHS";
                case "Họ tên": return "h.HOTEN";
                case "Giới tính": return "h.GIOITINH";
                case "Địa chỉ": return "h.DIACHI";
                default:
                    MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ!");
                    return "";
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LayBang_HOCSINH();
        }
    }
}
