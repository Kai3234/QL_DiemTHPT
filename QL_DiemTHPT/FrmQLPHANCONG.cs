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
    public partial class FrmQLPHANCONG : Form
    {
        public FrmQLPHANCONG()
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

        KETNOI_CSDL knn = new KETNOI_CSDL();

        public void LayBang_PHANCONG()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM VIEW_CHITIET_PHANCONG");
            data_PHANCONG.DataSource = dta;
            HienThiDuLieu();
        }

        public void LayBang_GIAOVIEN()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT *, MAGV + ' | ' + HOTEN AS HIENTHI FROM GIAOVIEN");
            data_GIAOVIEN.DataSource = dta;
            cboMaGV.DataSource = dta;
            cboMaGV.DisplayMember = "MAGV";
            cboMaGV.ValueMember = "MAGV";

            cboBaoCaoGV.DataSource = dta;
            cboBaoCaoGV.DisplayMember = "HIENTHI";
            cboBaoCaoGV.ValueMember = "MAGV";
        }

        public void LayBang_MONHOC()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT * FROM MONHOC");
            cboMaMon.DataSource = dta;
            cboMaMon.DisplayMember = "MAMH";
            cboMaMon.ValueMember = "MAMH";
        }

        public void LayBang_NAMHOC()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang(
            "SELECT MANH, TENNAM, MANH + ' | ' + TENNAM AS HIENTHI FROM NAMHOC");

            cboBaoCaoNH.DataSource = dta;
            cboBaoCaoNH.DisplayMember = "HIENTHI";
            cboBaoCaoNH.ValueMember = "MANH";

            cboLocLopNH.DataSource = dta;
            cboLocLopNH.DisplayMember = "HIENTHI";
            cboLocLopNH.ValueMember = "MANH";

        }

        public void LayBang_LOP()
        {
            DataTable dta = new DataTable();
            dta = knn.LayBang("SELECT LOP.*, TENNAM FROM LOP JOIN NAMHOC ON LOP.MANH = NAMHOC.MANH");
            
            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
            HienThiDuLieu();
        }

        public void LayBang_LOP(string manh = "")
        {
            DataTable dta = new DataTable();

            string sql = @"
                SELECT LOP.*, TENNAM
                FROM LOP
                JOIN NAMHOC ON LOP.MANH = NAMHOC.MANH";

            if (manh != "")
                sql += " WHERE LOP.MANH = '" + manh + "'";

            dta = knn.LayBang(sql);

            cboMaLop.DataSource = dta;
            cboMaLop.DisplayMember = "MALOP";
            cboMaLop.ValueMember = "MALOP";
            HienThiDuLieu();
        }

        public void HienThiDuLieu()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("Text", data_PHANCONG.DataSource, "MAPC");

            cboMaMon.DataBindings.Clear();
            cboMaMon.DataBindings.Add("Text", data_PHANCONG.DataSource, "MAMH");

            cboMaGV.DataBindings.Clear();
            cboMaGV.DataBindings.Add("Text", data_PHANCONG.DataSource, "MAGV");

            cboMaLop.DataBindings.Clear();
            cboMaLop.DataBindings.Add("Text", data_PHANCONG.DataSource, "MALOP");

            cboHocKy.DataBindings.Clear();
            cboHocKy.DataBindings.Add("Text", data_PHANCONG.DataSource, "HOCKY");

            txtTenMon.DataBindings.Clear();
            txtTenMon.DataBindings.Add("Text", cboMaMon.DataSource, "TENMH");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add(
                "Text",
                cboMaLop.DataSource,
                "TENLOP"
            );

            txtNamHoc.DataBindings.Clear();
            txtNamHoc.DataBindings.Add("Text", cboMaLop.DataSource, "TENNAM");


        }

        private void FrmQLPHANCONG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DIEMTHPTDataSet5.VIEW_CHITIET_PHANCONG' table. You can move, or remove it, as needed.
            LayBang_MONHOC();
            LayBang_LOP();
            LayBang_NAMHOC();
            LayBang_GIAOVIEN();
            LayBang_PHANCONG();


        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra giáo viên
            if (cboBaoCaoGV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giáo viên!");
                return;
            }

            // Kiểm tra năm học
            if (cboBaoCaoNH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn năm học!");
                return;
            }

            // ===== Lấy thông tin giáo viên =====
            string maGV = cboBaoCaoGV.SelectedValue.ToString();
            DataRowView gvRow = (DataRowView)cboBaoCaoGV.SelectedItem;
            string hoTen = gvRow["HOTEN"].ToString();

            // ===== Lấy thông tin năm học =====
            string maNam = cboBaoCaoNH.SelectedValue.ToString();
            DataRowView nhRow = (DataRowView)cboBaoCaoNH.SelectedItem;
            string tenNam = nhRow["TENNAM"].ToString();

            // ===== Mở form báo cáo PHANCONG =====
            FrmBAOCAOPHANCONG frm =
                new FrmBAOCAOPHANCONG(maGV, hoTen, maNam, tenNam);

            frm.ShowDialog();
        }



        private void optLocLopNH_CheckedChanged(object sender, EventArgs e)
        {
            if (optLocLopNH.Checked)
            {
                if (cboLocLopNH.SelectedValue != null)
                {
                    string manh = cboLocLopNH.SelectedValue.ToString();
                    LayBang_LOP(manh);
                }
            }
            else
            {
                LayBang_LOP(); // hiện tất cả lớp
            }
        }
        

        private void cboLocLopNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optLocLopNH.Checked)
            {
                string manh = cboLocLopNH.SelectedValue.ToString();
                LayBang_LOP(manh);
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            cboMaMon.SelectedIndex = -1;
            txtTenMon.Text = "";
            cboMaGV.SelectedIndex = -1;
            optLocLopNH.Checked = false;
            cboLocLopNH.SelectedIndex = -1;
            cboMaLop.SelectedIndex = -1;
            txtTenLop.Text = "";
            txtNamHoc.Text = "";
            cboHocKy.SelectedIndex = -1;
            txtMa.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // ===== 1. Lấy dữ liệu =====
            string mapc = txtMa.Text.Trim();
            string mamh = cboMaMon.Text;
            string magv = cboMaGV.Text;
            string malop = cboMaLop.Text;
            string hockyText = cboHocKy.Text.Trim();

            // ===== 2. Kiểm tra rỗng =====
            if (mapc == "" || mamh == null || magv == null
                || malop == null || hockyText == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // ===== 3. Kiểm tra học kỳ =====
            int hocky;
            if (!int.TryParse(hockyText, out hocky) || (hocky != 1 && hocky != 2))
            {
                MessageBox.Show("Học kỳ chỉ được chọn 1 hoặc 2!");
                cboHocKy.Focus();
                return;
            }

            // ===== 4. Kiểm tra trùng khóa =====
            string sqlCheck =
                "SELECT MAPC FROM PHANCONG WHERE MAPC = @MAPC";

            SqlCommand cmdCheck = new SqlCommand(sqlCheck, knn.cnn);
            cmdCheck.Parameters.AddWithValue("@MAPC", mapc);

            SqlDataReader rd = cmdCheck.ExecuteReader();

            if (rd.Read())
            {
                MessageBox.Show("Mã phân công đã tồn tại!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                rd.Close();
                txtMa.Focus();
                return;
            }
            rd.Close();

            // ===== 5. Insert dữ liệu =====
            string sqlInsert =
                @"INSERT INTO PHANCONG(MAPC,MAMH,MAGV,HOCKY,MALOP)
          VALUES(@MAPC,@MAMH,@MAGV,@HOCKY,@MALOP)";

            SqlCommand cmdInsert = new SqlCommand(sqlInsert, knn.cnn);

            cmdInsert.Parameters.AddWithValue("@MAPC", mapc);
            cmdInsert.Parameters.AddWithValue("@MAMH", mamh);
            cmdInsert.Parameters.AddWithValue("@MAGV", magv);
            cmdInsert.Parameters.AddWithValue("@HOCKY", hocky);
            cmdInsert.Parameters.AddWithValue("@MALOP", malop);

            cmdInsert.ExecuteNonQuery();

            MessageBox.Show("Thêm phân công thành công!");

            // ===== 6. Load lại dữ liệu =====
            LayBang_PHANCONG();
            HienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mapc = txtMa.Text;
            string mamh = cboMaMon.SelectedValue?.ToString();
            string magv = cboMaGV.SelectedValue?.ToString();
            string malop = cboMaLop.SelectedValue?.ToString();
            string hockyText = cboHocKy.Text;

            if (mapc == "" || mamh == null || magv == null
                || malop == null || hockyText == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int hocky;
            if (!int.TryParse(hockyText, out hocky))
            {
                MessageBox.Show("Học kỳ không hợp lệ!");
                return;
            }

            // ===== kiểm tra MAPC tồn tại =====
            string sqlCheck =
                "SELECT MAPC FROM PHANCONG WHERE MAPC=@MAPC";

            SqlCommand cmdCheck = new SqlCommand(sqlCheck, knn.cnn);
            cmdCheck.Parameters.AddWithValue("@MAPC", mapc);

            SqlDataReader rd = cmdCheck.ExecuteReader();

            if (!rd.Read())
            {
                MessageBox.Show("Mã phân công không tồn tại!");
                rd.Close();
                return;
            }
            rd.Close();

            // ===== UPDATE =====
            string sqlUpdate =
                @"UPDATE PHANCONG
                  SET MAMH=@MAMH,
                      MAGV=@MAGV,
                      MALOP=@MALOP,
                      HOCKY=@HOCKY
                  WHERE MAPC=@MAPC";

            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, knn.cnn);

            cmdUpdate.Parameters.AddWithValue("@MAMH", mamh);
            cmdUpdate.Parameters.AddWithValue("@MAGV", magv);
            cmdUpdate.Parameters.AddWithValue("@MALOP", malop);
            cmdUpdate.Parameters.AddWithValue("@HOCKY", hocky);
            cmdUpdate.Parameters.AddWithValue("@MAPC", mapc);

            cmdUpdate.ExecuteNonQuery();

            MessageBox.Show("Cập nhật thành công!");

            LayBang_PHANCONG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mapc = txtMa.Text;

            if (mapc == "")
            {
                MessageBox.Show("Chưa chọn phân công!");
                return;
            }

            // ===== kiểm tra đang dùng trong DIEM =====
            string sqlCheck =
                "SELECT MAPC FROM DIEM WHERE MAPC=@MAPC";

            SqlCommand cmdCheck = new SqlCommand(sqlCheck, knn.cnn);
            cmdCheck.Parameters.AddWithValue("@MAPC", mapc);

            SqlDataReader rd = cmdCheck.ExecuteReader();

            if (rd.Read())
            {
                MessageBox.Show(
                    "Phân công đã có dữ liệu điểm, không thể xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                rd.Close();
                return;
            }
            rd.Close();

            // ===== xác nhận xóa =====
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa phân công này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.No) return;

            // ===== DELETE =====
            string sqlDelete =
                "DELETE FROM PHANCONG WHERE MAPC=@MAPC";

            SqlCommand cmdDelete = new SqlCommand(sqlDelete, knn.cnn);
            cmdDelete.Parameters.AddWithValue("@MAPC", mapc);

            cmdDelete.ExecuteNonQuery();

            MessageBox.Show("Xóa thành công!");

            LayBang_PHANCONG();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM VIEW_CHITIET_PHANCONG WHERE 1=1";

            // ===== NĂM HỌC =====
            if (optTenNamHoc.Checked && txtTimTenNam.Text.Trim() != "")
            {
                sql += " AND TENNAM LIKE N'%" + txtTimTenNam.Text.Trim() + "%'";
            }

            // ===== TÊN LỚP =====
            if (optTenLop.Checked && txtTimTenLop.Text.Trim() != "")
            {
                sql += " AND TENLOP LIKE N'%" + txtTimTenLop.Text.Trim() + "%'";
            }

            // ===== HỌC KỲ (COMBOBOX) =====
            if (optHocKy.Checked && cboTimHocKy.Text.Trim() != "")
            {
                if (cboTimHocKy.Text == "1")
                    sql += " AND HOCKY = 1";
                else if (cboTimHocKy.Text == "2")
                    sql += " AND HOCKY = 2";
            }

            // ===== TÊN MÔN HỌC =====
            if (optTenMonHoc.Checked && txtTimTenMon.Text.Trim() != "")
            {
                sql += " AND TENMH LIKE N'%" + txtTimTenMon.Text.Trim() + "%'";
            }

            // ===== MÃ GIÁO VIÊN =====
            if (optMaGV.Checked && txtTimMaGV.Text.Trim() != "")
            {
                sql += " AND MAGV LIKE N'%" + txtTimMaGV.Text.Trim() + "%'";
            }

            // ===== LOAD DATA =====
            DataTable dta = knn.LayBang(sql);
            data_PHANCONG.DataSource = dta;
            HienThiDuLieu();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            LayBang_MONHOC();
            LayBang_LOP();
            LayBang_NAMHOC();
            LayBang_GIAOVIEN();
            LayBang_PHANCONG();
        }
    }
}
