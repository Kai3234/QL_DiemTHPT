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
    public partial class FrmTHONGTINHOCSINH : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
        BindingSource bd = new BindingSource();

        public void LayBangHocSinh()
        {
            string sql = "SELECT * FROM HOCSINH WHERE MAHS = '" + TaiKhoanDangNhap.MaNguoiDung + "'";
            DataTable dt = knn.LayBang(sql);
            if(dt.Rows.Count > 0)
            {
                bd.DataSource = dt;
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin học sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void HienThiDuLieu()
        {
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", bd, "HOTEN");
            
            txtMaHS.DataBindings.Clear();
            txtMaHS.DataBindings.Add("Text", bd, "MAHS");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bd, "DIACHI");   

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bd, "MATKHAU");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bd, "NGAYSINH", true);

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("SelectedItem", bd, "GIOITINH");

        }
        public FrmTHONGTINHOCSINH()
        {
            InitializeComponent();
                //LayBangHocSinh();
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            FrmMAINHS fnew = new FrmMAINHS();
            fnew.Show();
            this.Close();
        }

        private void mnuXemDiem_Click(object sender, EventArgs e)
        {
            FrmXEMDIEM fnew = new FrmXEMDIEM();
            fnew.Show();
            this.Close();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTHONGTINHOCSINH fnew = new FrmTHONGTINHOCSINH();
            fnew.Show();
            this.Close();
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

        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmDOIMATKHAU fnew = new FrmDOIMATKHAU("student");
            fnew.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmTHONGTINHOCSINH_Load(object sender, EventArgs e)
        {
            LayBangHocSinh();
        }
    }
}
