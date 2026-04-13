using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmXEMDIEM : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private string _maHS = "";
        private string _maLop = "";

        public FrmXEMDIEM()
        {
            InitializeComponent();
        }

        private void FrmXEMDIEM_Load(object sender, EventArgs e)
        {
            _maHS = TaiKhoanDangNhap.MaNguoiDung;
            HienThiTenHocSinh();
            NapNamHoc();
            NapHocKy();
        }

     
        private void HienThiTenHocSinh()
        {
            DataTable dt = knn.LayBang("SELECT HOTEN FROM HOCSINH WHERE MAHS='" + _maHS + "'");
            if (dt.Rows.Count > 0)
                lblTenHS.Text = "Học sinh: " + dt.Rows[0]["HOTEN"].ToString() + "  (Mã: " + _maHS + ")";
        }

        
        private void NapNamHoc()
        {
            
            string sql = string.Format(
                @"SELECT DISTINCT nh.MANH, nh.TENNAM
                  FROM HOCSINH_LOP hl
                  INNER JOIN LOP l ON hl.MALOP = l.MALOP
                  INNER JOIN NAMHOC nh ON l.MANH = nh.MANH
                  WHERE hl.MAHS = '{0}'
                  ORDER BY nh.MANH DESC", _maHS);
            DataTable dt = knn.LayBang(sql);
            cboNamHoc.DisplayMember = "TENNAM";
            cboNamHoc.ValueMember = "MANH";
            cboNamHoc.DataSource = dt;
            cboNamHoc.SelectedIndex = -1;
        }

        private void NapHocKy()
        {
            cboHocKy.Items.Clear();
            cboHocKy.Items.Add("Học kỳ 1");
            cboHocKy.Items.Add("Học kỳ 2");
            cboHocKy.Items.Add("Cả năm");
            cboHocKy.SelectedIndex = -1;
        }

        private void NapLop(string maNamHoc)
        {
            string sql = string.Format(
                @"SELECT l.MALOP, l.TENLOP AS HIENTHI
                  FROM HOCSINH_LOP hl
                  INNER JOIN LOP l ON hl.MALOP = l.MALOP
                  WHERE hl.MAHS = '{0}' AND l.MANH = '{1}'",
                _maHS, maNamHoc);
            DataTable dt = knn.LayBang(sql);
            cboLop.DisplayMember = "HIENTHI";
            cboLop.ValueMember = "MALOP";
            cboLop.DataSource = dt;
            if (dt.Rows.Count > 0) cboLop.SelectedIndex = 0;
        }

        
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue == null) return;
            NapLop(cboNamHoc.SelectedValue.ToString());
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null) return;
            _maLop = cboLop.SelectedValue.ToString();
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiBang();
        }

        
        private void HienThiBang()
        {
            if (string.IsNullOrEmpty(_maLop) || cboHocKy.SelectedIndex < 0) return;

            string sqlDiem;
            string tieuDe;

            if (cboHocKy.SelectedIndex == 2) 
            {
                sqlDiem = string.Format(
                    @"SELECT
                        mh.TENMH            AS [Môn học],
                        pc.HOCKY            AS [Học kỳ],
                        d.DIEMTX            AS [ĐTX],
                        d.DIEMGK            AS [ĐGK],
                        d.DIEMCK            AS [ĐCK],
                        d.DIEMTB            AS [ĐTBM],
                        CASE WHEN d.DIEMTB >= 8 THEN N'Tốt'
                             WHEN d.DIEMTB >= 6.5 THEN N'Khá'
                             WHEN d.DIEMTB >= 5 THEN N'Đạt'
                             WHEN d.DIEMTB IS NOT NULL THEN N'Chưa đạt'
                             ELSE N'--' END AS [Xếp loại]
                      FROM DIEM d
                      INNER JOIN PHANCONG pc ON d.MAPC = pc.MAPC
                      INNER JOIN MONHOC mh ON pc.MAMH = mh.MAMH
                      WHERE d.MAHS = '{0}' AND pc.MALOP = '{1}'
                      ORDER BY pc.HOCKY, mh.TENMH", _maHS, _maLop);
                tieuDe = "Cả năm";
            }
            else
            {
                int hocKy = cboHocKy.SelectedIndex + 1;
                sqlDiem = string.Format(
                    @"SELECT
                        mh.TENMH            AS [Môn học],
                        d.DIEMTX            AS [ĐTX],
                        d.DIEMGK            AS [ĐGK],
                        d.DIEMCK            AS [ĐCK],
                        d.DIEMTB            AS [ĐTBM],
                        CASE WHEN d.DIEMTB >= 8 THEN N'Tốt'
                             WHEN d.DIEMTB >= 6.5 THEN N'Khá'
                             WHEN d.DIEMTB >= 5 THEN N'Đạt'
                             WHEN d.DIEMTB IS NOT NULL THEN N'Chưa đạt'
                             ELSE N'--' END AS [Xếp loại]
                      FROM DIEM d
                      INNER JOIN PHANCONG pc ON d.MAPC = pc.MAPC
                      INNER JOIN MONHOC mh ON pc.MAMH = mh.MAMH
                      WHERE d.MAHS = '{0}' AND pc.MALOP = '{1}' AND pc.HOCKY = {2}
                      ORDER BY mh.TENMH", _maHS, _maLop, hocKy);
                tieuDe = "Học kỳ " + hocKy;
            }

            DataTable dtDiem = knn.LayBang(sqlDiem);
            dgvDiem.DataSource = dtDiem;
            dgvDiem.ReadOnly = true;
            dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            HienThiThongKe(tieuDe);
        }

        
        private void HienThiThongKe(string tieuDe)
        {
            
            DataTable dtKQ = knn.LayBang(string.Format(
                "SELECT * FROM VW_KETQUA_HOCSINH WHERE MAHS='{0}' AND MALOP='{1}'",
                _maHS, _maLop));

            if (dtKQ.Rows.Count == 0)
            {
                lblThongKe.Text = "Chưa có dữ liệu điểm.";
                return;
            }

            DataRow r = dtKQ.Rows[0];
            double? tbHKI = r["DIEMTBHKI"] == DBNull.Value ? (double?)null : Convert.ToDouble(r["DIEMTBHKI"]);
            double? tbHKII = r["DIEMTBHKII"] == DBNull.Value ? (double?)null : Convert.ToDouble(r["DIEMTBHKII"]);
            double? tbNam = r["DIEMTBNAM"] == DBNull.Value ? (double?)null : Convert.ToDouble(r["DIEMTBNAM"]);
            int soMonHKI = Convert.ToInt32(r["SOMON_HKI"]);
            int soMonHKII = Convert.ToInt32(r["SOMON_HKII"]);

            string XepLoai(double? d) => d == null ? "Chưa có" :
                d >= 8 ? "Tốt" : d >= 6.5 ? "Khá" : d >= 5 ? "Đạt" : "Chưa đạt";

            lblThongKe.Text = string.Format(
                "HK1: TB={0}  ({1}) - {2} môn   |   HK2: TB={3}  ({4}) - {5} môn   |   Cả năm: TB={6}  ({7})",
                tbHKI?.ToString("F2") ?? "--", XepLoai(tbHKI), soMonHKI,
                tbHKII?.ToString("F2") ?? "--", XepLoai(tbHKII), soMonHKII,
                tbNam?.ToString("F2") ?? "--", XepLoai(tbNam));
        }

        
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maLop) || cboNamHoc.SelectedValue == null)
            { MessageBox.Show("Vui lòng chọn năm học và lớp trước khi xuất báo cáo!"); return; }

            FrmBCXEMDIEM fbc = new FrmBCXEMDIEM();
            fbc.MaHS = _maHS;
            fbc.MaLop = _maLop;
            fbc.ShowDialog();
        }

        
        private void mnuTrangChu_Click(object sender, EventArgs e)
        { new FrmMAINHS().Show(); this.Close(); }
        private void mnuXemDiem_Click(object sender, EventArgs e)
        { new FrmXEMDIEM().Show(); this.Close(); }
        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        { new FrmTHONGTINHOCSINH().Show(); this.Close(); }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap.MaNguoiDung = null;
            TaiKhoanDangNhap.LoaiNguoiDung = null;
            new FrmLOGIN().Show(); this.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
