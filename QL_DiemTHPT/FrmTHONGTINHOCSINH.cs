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
        public FrmTHONGTINHOCSINH()
        {
            InitializeComponent();
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


    }
}
