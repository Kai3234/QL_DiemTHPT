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
    public partial class FrmQLLOP : Form
    {
        public FrmQLLOP()
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

        //khoi tao class
        KETNOI_CSDL kn = new KETNOI_CSDL();

        //lay bang Lop len grid
        public void LayBang_LopHoc()
        {
            DataTable dta = kn.LayBang("SELECT * FROM LOP");
            dataGrid_LOP.DataSource = dta;

            //lấy danh sách không trùng
            DataTable dtTenLop = kn.LayBang("SELECT DISTINCT TENLOP FROM LOP");

            cboTK_TenLop.DataSource = dtTenLop;
            cboTK_TenLop.DisplayMember = "TENLOP";
            cboTK_TenLop.ValueMember = "TENLOP";
            HienThiDuLieu();
        }

        public void LayBang_NamHoc()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("SELECT * FROM NAMHOC");

            cboMaNH.DataSource = dta;
            cboMaNH.DisplayMember = "MANH";
            cboMaNH.ValueMember = "MANH";

            cboTK_NamHoc.DataSource = dta;
            cboTK_NamHoc.DisplayMember = "TENNAM";
            cboTK_NamHoc.ValueMember = "TENNAM";
        }

        public void LayBang_GV()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("SELECT * FROM GIAOVIEN");
            cboMaGV.DataSource = dta;

            cboMaGV.DisplayMember = "MAGV";
            cboMaGV.ValueMember = "MAGV";
        }

        private void HienThiDuLieu()
        {
            // TextBox
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataGrid_LOP.DataSource, "MALOP");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataGrid_LOP.DataSource, "TENLOP");

            // ComboBox
            cboKhoi.DataBindings.Clear();
            cboKhoi.DataBindings.Add("Text", dataGrid_LOP.DataSource, "KHOI");

            cboMaNH.DataBindings.Clear();
            cboMaNH.DataBindings.Add("Text", dataGrid_LOP.DataSource, "MANH");

            cboMaGV.DataBindings.Clear();
            cboMaGV.DataBindings.Add("Text", dataGrid_LOP.DataSource, "MAGVCHUNHIEM");
        }

        private void FrmQLLOP_Load(object sender, EventArgs e)
        {
            LayBang_LopHoc();
            LayBang_NamHoc();
            LayBang_GV();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            cboKhoi.Text = "";
            cboMaNH.Text = "";
            cboMaGV.Text = "";

            txtMaLop.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //kiểm tra rỗng
            if (txtMaLop.Text.Trim() == "" || txtTenLop.Text.Trim() == "" ||
                cboKhoi.Text == "" || cboMaNH.Text == "" || cboMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (kn.cnn.State == ConnectionState.Closed)
                kn.cnn.Open();

            //kiểm tra trùng mã lớp
            string strKtra = "SELECT MALOP FROM LOP WHERE MALOP = '" + txtMaLop.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();

            if (doc_DL.Read())
            {
                MessageBox.Show("Mã lớp đã tồn tại!", "Thông báo");
                txtMaLop.Focus();
                doc_DL.Close();
                return;
            }
            doc_DL.Close();

            //kiểm tra giáo viên chủ nhiệm
            string checkGV = "SELECT * FROM LOP WHERE MAGVCHUNHIEM = '" + cboMaGV.Text +
                             "' AND MANH = '" + cboMaNH.Text + "'";
            SqlCommand cmdGV = new SqlCommand(checkGV, kn.cnn);
            SqlDataReader rd = cmdGV.ExecuteReader();

            if (rd.Read())
            {
                MessageBox.Show("Giáo viên đã chủ nhiệm lớp khác trong năm học này!", "Thông báo");
                rd.Close();
                return;
            }
            rd.Close();

            //thêm dữ liệu
            string Sql_Luu = "INSERT INTO LOP VALUES (" +
                "'" + txtMaLop.Text + "', " +
                "N'" + txtTenLop.Text + "', " +
                "'" + cboKhoi.Text + "', " +
                "'" + cboMaNH.Text + "', " +
                "'" + cboMaGV.Text + "')";

            kn.ThucThi(Sql_Luu);

            LayBang_LopHoc();
            HienThiDuLieu();

            MessageBox.Show("Thêm lớp thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn lớp!");
                return;
            }

            if (txtTenLop.Text.Trim() == "" || cboKhoi.Text == "" ||
                cboMaNH.Text == "" || cboMaGV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (kn.cnn.State == ConnectionState.Closed)
                kn.cnn.Open();

            //kiểm tra tồn tại lớp
            string strKtra = "SELECT MALOP FROM LOP WHERE MALOP = '" + txtMaLop.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();

            if (!doc_DL.Read())
            {
                MessageBox.Show("Không tồn tại mã lớp học!", "Thông báo");
                txtMaLop.Focus();
                doc_DL.Close();
                return;
            }
            doc_DL.Close();

            //kiểm tra giáo viên chủ nhiệm
            string checkGV = "SELECT * FROM LOP WHERE MAGVCHUNHIEM = '" + cboMaGV.Text +
                             "' AND MANH = '" + cboMaNH.Text + "' AND MALOP <> '" + txtMaLop.Text + "'";
            SqlCommand cmdGV = new SqlCommand(checkGV, kn.cnn);
            SqlDataReader rd = cmdGV.ExecuteReader();

            if (rd.Read())
            {
                MessageBox.Show("Giáo viên đã chủ nhiệm lớp khác trong năm học này!", "Thông báo");
                rd.Close();
                return;
            }
            rd.Close();

            //update
            string Sql_sua = "UPDATE LOP SET " +
                "TENLOP = N'" + txtTenLop.Text + "', " +
                "KHOI = '" + cboKhoi.Text + "', " +
                "MANH = '" + cboMaNH.Text + "', " +
                "MAGVCHUNHIEM = '" + cboMaGV.Text + "' " +
                "WHERE MALOP = '" + txtMaLop.Text + "'";

            kn.ThucThi(Sql_sua);

            LayBang_LopHoc();
            HienThiDuLieu();

            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn lớp!");
                return;
            }

            if (kn.cnn.State == ConnectionState.Closed)
                kn.cnn.Open();

            //Kiểm tra lớp có tồn tại không
            string checkTonTai = "SELECT MALOP FROM LOP WHERE MALOP = '" + txtMaLop.Text + "'";
            SqlCommand cmdCheck = new SqlCommand(checkTonTai, kn.cnn);
            SqlDataReader rdCheck = cmdCheck.ExecuteReader();

            if (!rdCheck.Read())
            {
                MessageBox.Show("Mã lớp không tồn tại!", "Thông báo");
                txtMaLop.Focus();
                rdCheck.Close();
                return;
            }
            rdCheck.Close();

            //Kiểm tra ràng buộc ở bảng khác
            string strKtra = "SELECT MALOP FROM HOCSINH_LOP WHERE MALOP = '" + txtMaLop.Text + "' " +
                             "UNION " +
                             "SELECT MALOP FROM PHANCONG WHERE MALOP = '" + txtMaLop.Text + "'";

            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();

            if (doc_DL.Read())
            {
                MessageBox.Show("Lớp đang được sử dụng nên không thể xóa!", "Thông báo");
                txtMaLop.Focus();
                doc_DL.Close();
                return;
            }
            doc_DL.Close();

            //Xác nhận xóa
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No)
                return;

            //Xóa
            string Sql_xoa = "DELETE FROM LOP WHERE MALOP = '" + txtMaLop.Text + "'";
            kn.ThucThi(Sql_xoa);

            LayBang_LopHoc();
            HienThiDuLieu();

            MessageBox.Show("Xóa lớp học thành công!");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sql = "";

            //Chọn cả 2
            if (opt_TenLop.Checked == true && opt_TenNam.Checked == true)
            {
                sql = string.Format(
                    "EXEC SP_TIMKIEM_LOP N'{0}', N'{1}'",
                    cboTK_TenLop.Text,
                    cboTK_NamHoc.Text
                );
            }
            //Chỉ tên lớp
            else if (opt_TenLop.Checked == true)
            {
                sql = string.Format(
                    "EXEC SP_TIMKIEM_LOP N'{0}', NULL",
                    cboTK_TenLop.Text
                );
            }
            //Chỉ năm học
            else if (opt_TenNam.Checked == true)
            {
                sql = string.Format(
                    "EXEC SP_TIMKIEM_LOP NULL, N'{0}'",
                    cboTK_NamHoc.Text
                );
            }
            //Không chọn gì
            else
            {
                sql = "EXEC SP_TIMKIEM_LOP NULL, NULL";
            }

            //Thực thi
            dta = kn.LayBang(sql);

            //Hiển thị
            dataGrid_LOP.DataSource = dta;
            HienThiDuLieu();
        }
    }
}
