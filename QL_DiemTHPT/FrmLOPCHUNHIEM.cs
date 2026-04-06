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
    public partial class FrmLOPCHUNHIEM : Form
    {
        KETNOI_CSDL kn = new KETNOI_CSDL();
        
        public FrmLOPCHUNHIEM()
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

        private void FrmLOPCHUNHIEM_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
            LoadLopChuNhiem();
        }

        private void LoadNamHoc()
        {
            DataTable dt = kn.LayBang("SELECT MANH, TENNAM FROM NAMHOC");
            cboNamHoc.DataSource = dt;
            cboNamHoc.DisplayMember = "TENNAM";
            cboNamHoc.ValueMember = "MANH";
        }

        private void LoadLopChuNhiem()
        {
            string sql = @"SELECT MALOP, TENLOP FROM LOP 
                          WHERE MAGVCHUNHIEM = '" + TaiKhoanDangNhap.MaNguoiDung + "'";
            DataTable dt = kn.LayBang(sql);
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }

        private void btnXemDanhSach_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp và năm học!");
                return;
            }

            string sql = @"SELECT hs.MAHS, hs.HOTEN, hs.NGAYSINH, hs.GIOITINH,
                                  d1.DIEMTB AS DIEMTBHK1,
                                  d2.DIEMTB AS DIEMTBHK2,
                                  d3.DIEMTB AS DIEMTBCN,
                                  d3.XEPLOAI
                           FROM HOCSINH hs
                           INNER JOIN HOCSINH_LOP hl ON hs.MAHS = hl.MAHS
                           LEFT JOIN (
                               SELECT MAHS, AVG(DIEMTB) AS DIEMTB 
                               FROM DIEM WHERE MANH = '" + cboNamHoc.SelectedValue + @"' AND HOCKY = 1 
                               GROUP BY MAHS
                           ) d1 ON hs.MAHS = d1.MAHS
                           LEFT JOIN (
                               SELECT MAHS, AVG(DIEMTB) AS DIEMTB 
                               FROM DIEM WHERE MANH = '" + cboNamHoc.SelectedValue + @"' AND HOCKY = 2 
                               GROUP BY MAHS
                           ) d2 ON hs.MAHS = d2.MAHS
                           LEFT JOIN (
                               SELECT MAHS, AVG(DIEMTB) AS DIEMTB,
                                      CASE 
                                          WHEN AVG(DIEMTB) >= 9 THEN N'Tốt'
                                          WHEN AVG(DIEMTB) >= 7 THEN N'Khá'
                                          WHEN AVG(DIEMTB) >= 5 THEN N'Đạt'
                                          ELSE N'Chưa đạt'
                                      END AS XEPLOAI
                               FROM DIEM WHERE MANH = '" + cboNamHoc.SelectedValue + @"'
                               GROUP BY MAHS
                           ) d3 ON hs.MAHS = d3.MAHS
                           WHERE hl.MALOP = '" + cboLop.SelectedValue + @"' 
                             AND hl.MANH = '" + cboNamHoc.SelectedValue + @"'
                           ORDER BY hs.MAHS";

            DataTable dt = kn.LayBang(sql);
            dataGridViewHS.DataSource = dt;

            dataGridViewHS.Columns["MAHS"].HeaderText = "Mã HS";
            dataGridViewHS.Columns["HOTEN"].HeaderText = "Họ tên";
            dataGridViewHS.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dataGridViewHS.Columns["GIOITINH"].HeaderText = "Giới tính";
            dataGridViewHS.Columns["DIEMTBHK1"].HeaderText = "ĐTB HK1";
            dataGridViewHS.Columns["DIEMTBHK2"].HeaderText = "ĐTB HK2";
            dataGridViewHS.Columns["DIEMTBCN"].HeaderText = "ĐTB Cả năm";
            dataGridViewHS.Columns["XEPLOAI"].HeaderText = "Xếp loại";

            UpdateSummary(dt);
        }

        private void UpdateSummary(DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                lblTongSo.Text = "Tổng số HS: 0";
                lblTot.Text = "Tốt: 0";
                lblKha.Text = "Khá: 0";
                lblDat.Text = "Đạt: 0";
                lblChuaDat.Text = "Chưa đạt: 0";
                return;
            }

            int total = dt.Rows.Count;
            int tot = 0, kha = 0, dat = 0, chuaDat = 0;

            foreach (DataRow row in dt.Rows)
            {
                string xepLoai = row["XEPLOAI"]?.ToString();
                if (xepLoai == "Tốt") tot++;
                else if (xepLoai == "Khá") kha++;
                else if (xepLoai == "Đạt") dat++;
                else if (xepLoai == "Chưa đạt") chuaDat++;
            }

            lblTongSo.Text = $"Tổng số HS: {total}";
            lblTot.Text = $"Tốt: {tot}";
            lblKha.Text = $"Khá: {kha}";
            lblDat.Text = $"Đạt: {dat}";
            lblChuaDat.Text = $"Chưa đạt: {chuaDat}";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp và năm học!");
                return;
            }

            FrmBaoCaoLopCN f = new FrmBaoCaoLopCN();
            f.MaLop = cboLop.SelectedValue.ToString();
            f.MaNamHoc = cboNamHoc.SelectedValue.ToString();
            f.ShowDialog();
        }


    }
}
