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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_DiemTHPT
{
    public partial class FrmQLGIAOVIEN : Form
    {
        public FrmQLGIAOVIEN()
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

        public void LayBang_GIAOVIEN()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM GIAOVIEN");
            data_GIAOVIEN.DataSource = dta;
            HienThiDuLieu();
        }

        public void LayBang_NAMHOC()
        {
            DataTable dt = knn.LayBang(
            "SELECT MANH, TENNAM, MANH + ' | ' + TENNAM AS HIENTHI FROM NAMHOC");

            cboBaoCaoNH.DataSource = dt;
            cboBaoCaoNH.DisplayMember = "HIENTHI";
            cboBaoCaoNH.ValueMember = "MANH";
        }

        public void HienThiDuLieu()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", data_GIAOVIEN.DataSource, "MAGV");

            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", data_GIAOVIEN.DataSource, "HOTEN");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", data_GIAOVIEN.DataSource, "NGAYSINH");

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", data_GIAOVIEN.DataSource, "GIOITINH");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", data_GIAOVIEN.DataSource, "DIACHI");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", data_GIAOVIEN.DataSource, "MATKHAU");


        }

        private void FrmQLGIAOVIEN_Load(object sender, EventArgs e)
        {
            LayBang_NAMHOC();
            LayBang_GIAOVIEN();

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
            // Xử lý dl trùng khóa
            string strKra = "SELECT MAGV FROM GIAOVIEN WHERE MAGV = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, knn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã GIÁO VIÊN này đã tồn tại, nhập lại mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                doc_DL.Close();
                doc_DL.Dispose();

            }
            else
            {
                // Insert dl vao database
                DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);

                string sql_luu;
                sql_luu = "INSERT INTO GIAOVIEN " + "VALUES ('" + s1 + "', N'" + s2 + "'";
                sql_luu = sql_luu + ", '" + ngaySinh.ToString("yyyy-MM-dd") + "'";
                sql_luu = sql_luu + ", '" + s4 + "', N'" + s5 + "', '" + s6 + "')";

                knn.ThucThi(sql_luu);
                LayBang_GIAOVIEN();
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

            string strKra = "SELECT MAGV FROM GIAOVIEN WHERE MAGV = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, knn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                // update dl trong database
                DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);


            


                string sql_sua;
                sql_sua = "UPDATE GIAOVIEN SET HOTEN = N'" + s2 + "'";
                sql_sua = sql_sua + ", NGAYSINH = '" + ngaySinh.ToString("yyyy-MM-dd") + "', GIOITINH = N'" + s4 + "'";
                sql_sua = sql_sua + ", DIACHI = N'" + s5 + "', MATKHAU = '" + s6 + "' ";
                sql_sua = sql_sua + "WHERE MAGV = '" + s1 + "'";
                knn.ThucThi(sql_sua);
                LayBang_GIAOVIEN();
                doc_DL.Close();
                doc_DL.Dispose();

            }
            else
            {
                MessageBox.Show("Mã GIÁO VIÊN này không tồn tại, nhập lại mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                doc_DL.Close();
                doc_DL.Dispose();

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strKra = "SELECT MAGVCHUNHIEM FROM LOP WHERE MAGVCHUNHIEM = '" + txtMa.Text + "' UNION SELECT MAGV FROM GIAOVIEN WHERE MAGV = '" + txtMa.Text + "'";
            SqlCommand cmd = new SqlCommand(strKra, knn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();
            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã GIÁO VIÊN này tồn tại ở bảng khác, nhập lại mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMa.Focus();
                doc_DL.Close();
                doc_DL.Dispose();
            }
            else
            {
                // delete dl trong database
                string sql_xoa = "DELETE FROM GIAOVIEN WHERE MAGV = '" + txtMa.Text + "'";
                knn.ThucThi(sql_xoa);
                LayBang_GIAOVIEN();
                doc_DL.Close();
                doc_DL.Dispose();

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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


            string cotTim;
            switch (cboTieuChiTim.Text)
            {
                case "Mã giáo viên":
                    cotTim = "MAGV";
                    break;
                case "Họ tên":
                    cotTim = "HOTEN";
                    break;
                case "Giới tính":
                    cotTim = "GIOITINH";
                    break;
                case "Địa chỉ":
                    cotTim = "DIACHI";
                    break;
                default:
                    MessageBox.Show("Tiêu chí tìm kiếm không hợp lệ!");
                    return;
            }
            string giatri = txtTimKiem.Text.Trim();

            string sql;

            sql = $"SELECT * FROM GIAOVIEN WHERE {cotTim} LIKE N'%{giatri}%'";
            
            
            DataTable dta = knn.LayBang(sql);
            data_GIAOVIEN.DataSource = dta;
            HienThiDuLieu();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LayBang_GIAOVIEN();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cboBaoCaoNH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn năm học để tạo báo cáo!");
                return;
            }

            string maNamHoc = cboBaoCaoNH.SelectedValue.ToString();
            DataRowView row = (DataRowView)cboBaoCaoNH.SelectedItem;
            string tenNam = row["TENNAM"].ToString();
            string hocKy = string.IsNullOrEmpty(cboBaoCaoHK.Text) ? "Cả năm" : cboBaoCaoHK.Text;

            FrmBCGIAOVIEN f = new FrmBCGIAOVIEN(maNamHoc, tenNam, hocKy);
            f.ShowDialog();
        }
    }
}
