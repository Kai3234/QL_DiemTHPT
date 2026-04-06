using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmQLHOCSINH : Form
    {
        KETNOI_CSDL kn = new KETNOI_CSDL();
        
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

        private void FrmQLHOCSINH_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        private void LoadData()
        {
            string sql = "SELECT MAHS, HOTEN, NGAYSINH, GIOITINH, DIACHI, MATKHAU FROM HOCSINH";
            DataTable dt = kn.LayBang(sql);
            data_HOCSINH.DataSource = dt;
            BindControls();
        }

        private void BindControls()
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

        private void LoadComboBoxes()
        {
            DataTable dtNH = kn.LayBang("SELECT MANH, TENNAM FROM NAMHOC");
            cboBaoCaoNH.DataSource = dtNH;
            cboBaoCaoNH.DisplayMember = "TENNAM";
            cboBaoCaoNH.ValueMember = "MANH";

            DataTable dtLop = kn.LayBang("SELECT MALOP, TENLOP FROM LOP");
            cboBaoCaoLop.DataSource = dtLop;
            cboBaoCaoLop.DisplayMember = "TENLOP";
            cboBaoCaoLop.ValueMember = "MALOP";
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtHoTen.Text = "";
            txtNgaySinh.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtMa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                MessageBox.Show("Vui lòng nhập mã học sinh!");
                return;
            }

            string sqlCheck = $"SELECT MAHS FROM HOCSINH WHERE MAHS = '{txtMa.Text}'";
            DataTable dt = kn.LayBang(sqlCheck);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã học sinh đã tồn tại!");
                return;
            }

            DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);
            string sql = $@"INSERT INTO HOCSINH (MAHS, HOTEN, NGAYSINH, GIOITINH, DIACHI, MATKHAU) 
                           VALUES ('{txtMa.Text}', N'{txtHoTen.Text}', '{ngaySinh:yyyy-MM-dd}', 
                                   N'{cboGioiTinh.Text}', N'{txtDiaChi.Text}', '{txtMatKhau.Text}')";
            kn.ThucThi(sql);
            LoadData();
            MessageBox.Show("Thêm học sinh thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime ngaySinh = DateTime.Parse(txtNgaySinh.Text);
            string sql = $@"UPDATE HOCSINH SET HOTEN = N'{txtHoTen.Text}', NGAYSINH = '{ngaySinh:yyyy-MM-dd}',
                           GIOITINH = N'{cboGioiTinh.Text}', DIACHI = N'{txtDiaChi.Text}', 
                           MATKHAU = '{txtMatKhau.Text}' WHERE MAHS = '{txtMa.Text}'";
            kn.ThucThi(sql);
            LoadData();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM HOCSINH WHERE MAHS = '{txtMa.Text}'";
                kn.ThucThi(sql);
                LoadData();
                MessageBox.Show("Xóa thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MAHS, HOTEN, NGAYSINH, GIOITINH, DIACHI, MATKHAU FROM HOCSINH WHERE 1=1";
            if (!string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                if (cboTieuChiTim.Text == "Mã học sinh")
                    sql += $" AND MAHS LIKE N'%{txtTimKiem.Text}%'";
                else if (cboTieuChiTim.Text == "Họ tên")
                    sql += $" AND HOTEN LIKE N'%{txtTimKiem.Text}%'";
                else if (cboTieuChiTim.Text == "Địa chỉ")
                    sql += $" AND DIACHI LIKE N'%{txtTimKiem.Text}%'";
            }
            data_HOCSINH.DataSource = kn.LayBang(sql);
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LoadData();
            txtTimKiem.Text = "";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            FrmBaoCaoHocSinh f = new FrmBaoCaoHocSinh();
            f.MaLop = cboBaoCaoLop.SelectedValue?.ToString();
            f.MaNamHoc = cboBaoCaoNH.SelectedValue?.ToString();
            f.ShowDialog();
        }
    }
}
