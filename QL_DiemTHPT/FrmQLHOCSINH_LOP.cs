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
    public partial class FrmQLHOCSINH_LOP : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();

        public void LayBangHocSinh_Lop()
        {
            // Sử dụng WHERE thuần, không Alias theo yêu cầu trước đó của bạn
            string sql = "SELECT HOCSINH_LOP.MAHS, HOCSINH.HOTEN, " +
                         "HOCSINH_LOP.MALOP, LOP.TENLOP, " +
                         "LOP.MAGVCHUNHIEM, GIAOVIEN.HOTEN, " +
                         "NAMHOC.TENNAM " +
                         "FROM HOCSINH_LOP, HOCSINH, LOP, GIAOVIEN, NAMHOC " +
                         "WHERE HOCSINH_LOP.MAHS = HOCSINH.MAHS " +
                         "AND HOCSINH_LOP.MALOP = LOP.MALOP " +
                         "AND LOP.MAGVCHUNHIEM = GIAOVIEN.MAGV " +
                         "AND LOP.MANH = NAMHOC.MANH";

            DataTable dt = knn.LayBang(sql);
            dataHocSinh_Lop.DataSource = dt;
            HienThiDuLieu();
        }

        public void HienThiDuLieu()
        {
            txtMaHS.DataBindings.Clear();
            txtTenHS.DataBindings.Clear();
            txtMaLOP.DataBindings.Clear();
            txtTenLop.DataBindings.Clear();
            txtMaGV.DataBindings.Clear();
            txtTenGV.DataBindings.Clear();
            txtNamHoc.DataBindings.Clear();

            if (dataHocSinh_Lop.DataSource != null)
            {
                txtMaHS.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "MAHS");
                txtTenHS.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "HOTEN");
                txtMaLOP.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "MALOP");
                txtTenLop.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "TENLOP");
                txtMaGV.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "MAGVCHUNHIEM");
                txtTenGV.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "HOTEN1");
                txtNamHoc.DataBindings.Add("Text", dataHocSinh_Lop.DataSource, "TENNAM");
            }
        }

        public FrmQLHOCSINH_LOP()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmQLHOCSINH_LOP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DIEMTHPTDataSet4.HOCSINH_LOP' table. You can move, or remove it, as needed.
            this.hOCSINH_LOPTableAdapter.Fill(this.qL_DIEMTHPTDataSet4.HOCSINH_LOP);
            LayBangHocSinh_Lop();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaHS.DataBindings.Clear();
            txtMaLOP.DataBindings.Clear();
            txtMaHS.Text = "";
            txtMaLOP.Text = "";
            txtTenHS.Text = "";
            txtTenLop.Text = "";
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtNamHoc.Text = "";
            txtMaHS.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mahs = txtMaHS.Text.Trim();
            string malop = txtMaLOP.Text.Trim();

            if (string.IsNullOrEmpty(mahs) || string.IsNullOrEmpty(malop))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã HS và Mã Lớp!");
                return;
            }

            string checkExist = "SELECT * FROM HOCSINH_LOP WHERE MAHS = '" + mahs + "' and MALOP='"+malop+"'";
            if (knn.LayBang(checkExist).Rows.Count > 0)
            {
                MessageBox.Show("Học sinh này đã được xếp lớp rồi! Dùng nút 'Sửa' nếu muốn đổi lớp.");
                return;
            }

            try
            {
                string sql = "INSERT INTO HOCSINH_LOP (MAHS, MALOP) VALUES ('" + mahs + "', '" + malop + "')";
                knn.ThucThi(sql);
                MessageBox.Show("Xếp lớp thành công!");
                LayBangHocSinh_Lop();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mahs = txtMaHS.Text.Trim();
            string malop = txtMaLOP.Text.Trim();
            string checkExist = "SELECT * FROM HOCSINH_LOP WHERE MAHS = '" + mahs + "' and MALOP='" + malop + "'";
            if(knn.LayBang(checkExist).Rows.Count == 0)
            {
                MessageBox.Show("Học sinh này chưa được xếp lớp nào! Không thể xóa.");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa học sinh này khỏi lớp?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM HOCSINH_LOP WHERE MAHS = '" + mahs + "' AND MALOP = '" + malop + "'";
                    knn.ThucThi(sql);
                    LayBangHocSinh_Lop();
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mahs = txtMaHS.Text.Trim();
            string malopMoi = txtMaLOP.Text.Trim();

            try
            {
                string sql = "UPDATE HOCSINH_LOP SET MALOP = '" + malopMoi + "' WHERE MAHS = '" + mahs + "'";
                knn.ThucThi(sql);
                MessageBox.Show("Cập nhật lớp cho học sinh thành công!");
                LayBangHocSinh_Lop();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            FrmChuyenLop fnew = new FrmChuyenLop();
            fnew.ShowDialog();
            
        }
    }
}
