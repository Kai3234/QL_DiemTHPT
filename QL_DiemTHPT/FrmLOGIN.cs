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
    public partial class FrmLOGIN : Form
    {
        public FrmLOGIN()
        {
            InitializeComponent();
            cboLoai.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        KETNOI_CSDL kn = new KETNOI_CSDL();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            kn.KetNoi_Dulieu();
            string S1 = txtMa.Text;
            string S2 = txtMatKhau.Text;
            string S3 = cboLoai.Text;

            string Sql_login;


            if (S3 == "Học sinh")
            {
                S3 = "HOCSINH";
                Sql_login = "SELECT * FROM " + S3 + " WHERE MAHS = '" + S1 + "' AND MATKHAU ='" + S2 + "'";

            }
            else if (S3 == "Giáo viên")
            {
                S3 = "GIAOVIEN";
                Sql_login = "SELECT * FROM " + S3 + " WHERE MAGV = '" + S1 + "' AND MATKHAU ='" + S2 + "'";
            }
            else
            {
                S3 = "ADMIN";
                Sql_login = "SELECT * FROM " + S3 + " WHERE MAADMIN = '" + S1 + "' AND MATKHAU ='" + S2 + "'";
            }
            TaiKhoanDangNhap.LoaiNguoiDung = S3;


            SqlCommand cmd = new SqlCommand(Sql_login, kn.cnn);
            SqlDataReader datRed = cmd.ExecuteReader();

            if (datRed.Read() == true)
            {
                MessageBox.Show("Đăng nhập thành công!");
                TaiKhoanDangNhap.MaNguoiDung = S1;
                Form fmain;
                this.Hide();
                if (S3 == "HOCSINH")
                {
                    fmain = new FrmMAINHS();
                }
                else if (S3 == "GIAOVIEN")
                {
                    fmain = new FrmMAINGV();
                }
                else
                {
                    fmain = new FrmMAINADMIN();
                }
                
                fmain.Show();
            }
            else
            {
                MessageBox.Show("Thông tin mật khẩu hoặc mã đăng nhập bị sai!");
            }
        }
    }
}
