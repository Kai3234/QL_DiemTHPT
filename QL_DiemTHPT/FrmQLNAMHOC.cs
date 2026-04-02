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
    public partial class FrmQLNAMHOC : Form
    {
        public FrmQLNAMHOC()
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

        //lay bang nam hoc len grid
        public void LayBang_NamHoc()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("SELECT * FROM NAMHOC");
            dataGrid_NamHoc.DataSource = dta;
        }

        private void HienThiDuLieu()
        {
            txtMaNH.DataBindings.Clear();
            txtMaNH.DataBindings.Add("Text", dataGrid_NamHoc.DataSource, "MANH");

            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", dataGrid_NamHoc.DataSource, "TENNAM");
        }

        private void FrmQLNAMHOC_Load(object sender, EventArgs e)
        {
            LayBang_NamHoc();
            HienThiDuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaNH.Text = "";
            txtNamHoc.Text = "";
            txtMaNH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "SELECT MANH FROM NAMHOC WHERE MANH = '" + txtMaNH.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();

            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã năm học này đã tồn tại. Vui lòng nhập mã khác!", "Thông báo");
                txtMaNH.Focus();
                doc_DL.Close();
                doc_DL.Dispose();
            }
            else
            {
                string a = txtMaNH.Text;
                string b = txtNamHoc.Text;
                string Sql_Luu;
                Sql_Luu = "INSERT INTO NAMHOC VALUES ('" + a + "', N'" + b + "')";

                MessageBox.Show(Sql_Luu);
                kn.ThucThi(Sql_Luu);
                LayBang_NamHoc();
                HienThiDuLieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn năm học!");
                return;
            }

            string Sql_sua = "UPDATE NAMHOC SET TENNAM = N'" + txtNamHoc.Text + "'";
            Sql_sua += " WHERE MANH = '" + txtMaNH.Text + "'";

            MessageBox.Show(Sql_sua);
            kn.ThucThi(Sql_sua);
            LayBang_NamHoc();
            HienThiDuLieu();

            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string Sql_xoa = " DELETE FROM NAMHOC WHERE MANH = '" + txtMaNH.Text + "'";
            MessageBox.Show(Sql_xoa);
            kn.ThucThi(Sql_xoa);
            LayBang_NamHoc();
            HienThiDuLieu();
            MessageBox.Show("Xóa năm học thành công!");
        }
    }
}
