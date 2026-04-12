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
    public partial class FrmMAINGV : Form
    {
        public FrmMAINGV()
        {
            InitializeComponent();
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            FrmMAINGV fnew = new FrmMAINGV();
            fnew.Show();
            this.Close();
        }
        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            FrmNHAPDIEMMON fnew = new FrmNHAPDIEMMON();
            fnew.Show();
            this.Close();
        }

        private void mnuChuNhiem_Click(object sender, EventArgs e)
        {
            FrmLOPCHUNHIEM fnew = new FrmLOPCHUNHIEM();
            fnew.Show();
            this.Close();
        }



        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTHONGTINGIAOVIEN fnew = new FrmTHONGTINGIAOVIEN();
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

        private void FrmMAINGV_Load(object sender, EventArgs e)
        {

        }
    }
}
