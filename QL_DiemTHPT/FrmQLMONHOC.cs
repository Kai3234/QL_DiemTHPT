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
    public partial class FrmQLMONHOC : Form
    {
        public FrmQLMONHOC()
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
        public void LayBang_MonHoc()
        {
            DataTable dta = new DataTable();
            dta = kn.LayBang("SELECT * FROM MONHOC");
            dataGrid_MONHOC.DataSource = dta;
        }

        private void HienThiDuLieu()
        {
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", dataGrid_MONHOC.DataSource, "MAMH");

            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", dataGrid_MONHOC.DataSource, "TENMH");
        }

        private void FrmQLMONHOC_Load(object sender, EventArgs e)
        {
            LayBang_MonHoc();
            HienThiDuLieu();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtMaMH.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string strKtra = "SELECT MAMH FROM MONHOC WHERE MAMH = '" + txtMaMH.Text + "'";
            SqlCommand cmd = new SqlCommand(strKtra, kn.cnn);
            SqlDataReader doc_DL = cmd.ExecuteReader();

            if (doc_DL.Read() == true)
            {
                MessageBox.Show("Mã môn học đã tồn tại!", "Thông báo");
                txtMaMH.Focus();
                doc_DL.Close();
            }
            else
            {
                doc_DL.Close();

                string Sql_Luu = "INSERT INTO MONHOC VALUES ('" + txtMaMH.Text + "', N'" + txtTenMH.Text + "')";
                MessageBox.Show(Sql_Luu);

                kn.ThucThi(Sql_Luu);
                LayBang_MonHoc();
                HienThiDuLieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn môn học!");
                return;
            }

            string Sql_sua = "UPDATE MONHOC SET TENMH = N'" + txtTenMH.Text + "'";
            Sql_sua += " WHERE MAMH = '" + txtMaMH.Text + "'";

            MessageBox.Show(Sql_sua);

            kn.ThucThi(Sql_sua);
            LayBang_MonHoc();
            HienThiDuLieu();

            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn môn học!");
                return;
            }

            string Sql_xoa = "DELETE FROM MONHOC WHERE MAMH = '" + txtMaMH.Text + "'";
            MessageBox.Show(Sql_xoa);

            kn.ThucThi(Sql_xoa);
            LayBang_MonHoc();
            HienThiDuLieu();

            MessageBox.Show("Xóa thành công!");
        }
    }
}
