using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmQLHOCSINH : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();

        public FrmQLHOCSINH()
        {
            InitializeComponent();
        }

        private void FrmQLHOCSINH_Load(object sender, EventArgs e)
        {
            LayBang_HOCSINH();
        }

        public void LayBang_HOCSINH()
        {
            DataTable dt = knn.LayBang("SELECT MAHS, HOTEN, NGAYSINH, GIOITINH, DIACHI FROM HOCSINH ORDER BY MAHS");
            data_HOCSINH.DataSource = dt;
            HienThiDuLieu();
            CapNhatSoLuong();
        }

        public void HienThiDuLieu()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", data_HOCSINH.DataSource, "MAHS");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", data_HOCSINH.DataSource, "HOTEN");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", data_HOCSINH.DataSource, "NGAYSINH");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", data_HOCSINH.DataSource, "DIACHI");
            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("Text", data_HOCSINH.DataSource, "GIOITINH");
        }

        private void data_HOCSINH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string mahs = data_HOCSINH.Rows[e.RowIndex].Cells["MAHS"].Value.ToString();
                HienThiMatKhau(mahs);
            }
        }

        private void HienThiMatKhau(string mahs)
        {
            DataTable dtPass = knn.LayBang("SELECT MATKHAU FROM HOCSINH WHERE MAHS='" + mahs + "'");
            if (dtPass.Rows.Count > 0)
                txtMatKhau.Text = dtPass.Rows[0]["MATKHAU"]?.ToString();
        }

        private void CapNhatSoLuong()
        {
            lblSoLuong.Text = "Số lượng: " + data_HOCSINH.Rows.Count.ToString();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            // Code mở Form Crystal Reports của bạn ở đây
            // FrmInBaoCao f = new FrmInBaoCao();
            // f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            // FormLogin f = new FormLogin(); f.Show();
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            // Điều hướng về trang chủ
        }

        private void mnuXemDiem_Click(object sender, EventArgs e)
        {
            // Mở form xem điểm
        }
    }
}