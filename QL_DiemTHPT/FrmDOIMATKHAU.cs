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
    public partial class FrmDOIMATKHAU : Form
    {
        private string _loaiNguoidung;
        private string _MaNguoidung;

        string matKhauHienTaiTrongDB = "";

        KETNOI_CSDL knn = new KETNOI_CSDL();
        BindingSource bs = new BindingSource();

        public void LayBangTheoThongTin()
        {
            string sql = "SELECT * FROM " + _loaiNguoidung + " WHERE " + _MaNguoidung + " = '" + TaiKhoanDangNhap.MaNguoiDung + "'";
            DataTable dt = knn.LayBang(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                matKhauHienTaiTrongDB = dt.Rows[0]["MATKHAU"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin người dùng!");
            }
        }
        public FrmDOIMATKHAU(string loaiNguoidung)
        {
            InitializeComponent();
            if (loaiNguoidung == "student")
            {
                _loaiNguoidung="HOCSINH";
                _MaNguoidung = "MAHS";
            }
            else if (loaiNguoidung == "admin")
            {
                _loaiNguoidung="ADMIN";
            }
            else
            {
                _loaiNguoidung = "GIAOVIEN";
                _MaNguoidung = "MAGV";
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            FrmTHONGTINGIAOVIEN fnew= new FrmTHONGTINGIAOVIEN();
            fnew.Show();
            this.Close();
        }

        private void FrmDOIMATKHAU_Load(object sender, EventArgs e)
        {
            LayBangTheoThongTin();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string mkNhapVao = txtMatKhauHienTai.Text.Trim();
            string mkMoi = txtMatKhauMoi.Text.Trim();
            string mkXacNhan = txtXacNhanMatKhau.Text.Trim();

            if (mkNhapVao == "" || mkMoi == "" || mkXacNhan == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các ô!");
                return;
            }

            if (mkNhapVao != matKhauHienTaiTrongDB)
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác!");
                return;
            }

            if (mkMoi == mkNhapVao)
            {
                MessageBox.Show("Mật khẩu mới không được giống mật khẩu cũ!");
                return;
            }

            if (mkMoi != mkXacNhan)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp!");
                return;
            }

            var regex = new System.Text.RegularExpressions.Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (!regex.IsMatch(mkMoi))
            {
                MessageBox.Show("Mật khẩu yếu! Phải có ít nhất 8 ký tự, gồm chữ hoa, chữ thường, số và ký tự đặc biệt.");
                return;
            }

            try
            {
                string q = "UPDATE " + _loaiNguoidung + " SET MATKHAU = '" + mkMoi + "' WHERE " + _MaNguoidung + " = '" + TaiKhoanDangNhap.MaNguoiDung + "'";
                knn.ThucThi(q);

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void txtMatKhauHienTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
