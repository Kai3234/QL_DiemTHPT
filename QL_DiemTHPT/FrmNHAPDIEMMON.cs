using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmNHAPDIEMMON : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private string _maMaPC = "";  
        private string _maLop = "";
        private string _maHS = "";
        private string _maDiem = "";

        public FrmNHAPDIEMMON()
        {
            InitializeComponent();
        }

        private void FrmNHAPDIEMMON_Load(object sender, EventArgs e)
        {
            NapNamHoc();
            NapHocKy();
        }

        
        private void NapNamHoc()
        {
            DataTable dt = knn.LayBang("SELECT MANH, TENNAM FROM NAMHOC ORDER BY MANH");
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
            cboHocKy.SelectedIndex = -1;
        }

        private void NapLop(string maNamHoc, int hocKy)
        {
            string sql = string.Format(
                @"SELECT DISTINCT l.MALOP, l.TENLOP + ' (' + nh.TENNAM + ')' AS HIENTHI
                  FROM PHANCONG pc
                  INNER JOIN LOP l ON pc.MALOP = l.MALOP
                  INNER JOIN NAMHOC nh ON l.MANH = nh.MANH
                  WHERE l.MANH = '{0}' AND pc.HOCKY = {1} AND pc.MAGV = '{2}'
                  ORDER BY l.TENLOP",
                maNamHoc, hocKy, TaiKhoanDangNhap.MaNguoiDung);
            DataTable dt = knn.LayBang(sql);
            cboLop.DisplayMember = "HIENTHI";
            cboLop.ValueMember = "MALOP";
            cboLop.DataSource = dt;
            cboLop.SelectedIndex = -1;
        }

        private void NapMonHoc(string maNamHoc, int hocKy, string maLop)
        {
            string sql = string.Format(
                @"SELECT pc.MAPC, mh.TENMH AS HIENTHI
                  FROM PHANCONG pc
                  INNER JOIN MONHOC mh ON pc.MAMH = mh.MAMH
                  WHERE pc.MALOP = '{0}' AND pc.HOCKY = {1} AND pc.MAGV = '{2}'",
                maLop, hocKy, TaiKhoanDangNhap.MaNguoiDung);
            DataTable dt = knn.LayBang(sql);
            cboMonHoc.DisplayMember = "HIENTHI";
            cboMonHoc.ValueMember = "MAPC";
            cboMonHoc.DataSource = dt;
            cboMonHoc.SelectedIndex = -1;
        }

        
        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue == null) return;
            if (cboHocKy.SelectedIndex < 0) return;
            NapLop(cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedIndex + 1);
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue == null) return;
            if (cboHocKy.SelectedIndex < 0) return;
            NapLop(cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedIndex + 1);
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null) return;
            if (cboNamHoc.SelectedValue == null || cboHocKy.SelectedIndex < 0) return;
            _maLop = cboLop.SelectedValue.ToString();
            NapMonHoc(cboNamHoc.SelectedValue.ToString(), cboHocKy.SelectedIndex + 1, _maLop);
        }

        private void cboMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonHoc.SelectedValue == null) return;
            _maMaPC = cboMonHoc.SelectedValue.ToString();
            TaoDiemChoHocSinhNeuChua(_maMaPC, _maLop);
            HienThiBang();
        }

        
        private void TaoDiemChoHocSinhNeuChua(string maPC, string maLop)
        {
            
            DataTable dsHS = knn.LayBang(
                "SELECT MAHS FROM HOCSINH_LOP WHERE MALOP='" + maLop + "'");

            foreach (DataRow row in dsHS.Rows)
            {
                string mahs = row["MAHS"].ToString();
                DataTable check = knn.LayBang(string.Format(
                    "SELECT MADIEM FROM DIEM WHERE MAPC='{0}' AND MAHS='{1}'", maPC, mahs));
                if (check.Rows.Count == 0)
                {
                    
                    string maDiem = "D" + maPC + "_" + mahs;
                    knn.ThucThi(string.Format(
                        "INSERT INTO DIEM(MADIEM, MAPC, MAHS) VALUES('{0}','{1}','{2}')",
                        maDiem, maPC, mahs));
                }
            }
        }

        
        private void HienThiBang()
        {
            if (string.IsNullOrEmpty(_maMaPC)) return;

            string sql = string.Format(
                @"SELECT d.MADIEM, hs.MAHS, hs.HOTEN AS [Họ tên],
                         d.DIEMTX AS [ĐTX], d.DIEMGK AS [ĐGK],
                         d.DIEMCK AS [ĐCK], d.DIEMTB AS [ĐTBM],
                         CASE WHEN d.DIEMTB >= 8 THEN N'Tốt'
                              WHEN d.DIEMTB >= 6.5 THEN N'Khá'
                              WHEN d.DIEMTB >= 5 THEN N'Đạt'
                              WHEN d.DIEMTB IS NOT NULL THEN N'Chưa đạt'
                              ELSE N'--' END AS [Xếp loại]
                  FROM DIEM d
                  INNER JOIN HOCSINH hs ON d.MAHS = hs.MAHS
                  WHERE d.MAPC = '{0}'
                  ORDER BY hs.HOTEN", _maMaPC);

            DataTable dt = knn.LayBang(sql);
            dgvDiem.DataSource = dt;

            
            if (dgvDiem.Columns.Contains("MADIEM"))
                dgvDiem.Columns["MADIEM"].Visible = false;
            if (dgvDiem.Columns.Contains("MAHS"))
                dgvDiem.Columns["MAHS"].Visible = false;

            
            dgvDiem.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvDiem.Columns)
            {
                bool editable = col.Name == "ĐTX" || col.Name == "ĐGK" || col.Name == "ĐCK";
                col.ReadOnly = !editable;
            }

            HienThiThongKe(dt);
        }

        
        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maMaPC))
            { MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước!"); return; }

            int loi = 0;
            foreach (DataGridViewRow row in dgvDiem.Rows)
            {
                if (row.IsNewRow) continue;

                string madiem = row.Cells["MADIEM"].Value?.ToString();
                if (string.IsNullOrEmpty(madiem)) continue;

                string sDTX = row.Cells["ĐTX"].Value?.ToString();
                string sDGK = row.Cells["ĐGK"].Value?.ToString();
                string sDCK = row.Cells["ĐCK"].Value?.ToString();

                double dtx, dgk, dck;
                bool okTX = double.TryParse(sDTX, out dtx);
                bool okGK = double.TryParse(sDGK, out dgk);
                bool okCK = double.TryParse(sDCK, out dck);

                if (!string.IsNullOrWhiteSpace(sDTX) && (!okTX || dtx < 0 || dtx > 10)) { loi++; continue; }
                if (!string.IsNullOrWhiteSpace(sDGK) && (!okGK || dgk < 0 || dgk > 10)) { loi++; continue; }
                if (!string.IsNullOrWhiteSpace(sDCK) && (!okCK || dck < 0 || dck > 10)) { loi++; continue; }

                string sqlTX = string.IsNullOrWhiteSpace(sDTX) ? "NULL" : dtx.ToString("F1").Replace(",", ".");
                string sqlGK = string.IsNullOrWhiteSpace(sDGK) ? "NULL" : dgk.ToString("F1").Replace(",", ".");
                string sqlCK = string.IsNullOrWhiteSpace(sDCK) ? "NULL" : dck.ToString("F1").Replace(",", ".");

                string sql = string.Format(
                    "UPDATE DIEM SET DIEMTX={0}, DIEMGK={1}, DIEMCK={2} WHERE MADIEM='{3}'",
                    sqlTX, sqlGK, sqlCK, madiem);
                knn.ThucThi(sql);
            }

            if (loi > 0)
                MessageBox.Show(loi + " dòng có lỗi (điểm phải từ 0-10), các dòng còn lại đã lưu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HienThiBang(); 
        }

        
        private void HienThiThongKe(DataTable dt)
        {
            int total = 0, tot = 0, kha = 0, dat = 0, chuaDat = 0, chuaDiem = 0;
            foreach (DataRow row in dt.Rows)
            {
                total++;
                string xl = row["Xếp loại"]?.ToString();
                switch (xl)
                {
                    case "Tốt": tot++; break;
                    case "Khá": kha++; break;
                    case "Đạt": dat++; break;
                    case "Chưa đạt": chuaDat++; break;
                    default: chuaDiem++; break;
                }
            }

            lblThongKe.Text = string.Format(
                "Tổng: {0} HS   |   Tốt: {1}   Khá: {2}   Đạt: {3}   Chưa đạt: {4}   Chưa có điểm: {5}",
                total, tot, kha, dat, chuaDat, chuaDiem);
        }

        
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maMaPC))
            { MessageBox.Show("Vui lòng chọn đầy đủ thông tin trước khi xuất báo cáo!"); return; }

            FrmBCNHAPDIEM fbc = new FrmBCNHAPDIEM();
            fbc.MaPC = _maMaPC;
            fbc.ShowDialog();
        }

        
        private void mnuTrangChu_Click(object sender, EventArgs e)
        { new FrmMAINGV().Show(); this.Close(); }
        private void mnuNhapDiem_Click(object sender, EventArgs e)
        { new FrmNHAPDIEMMON().Show(); this.Close(); }
        private void mnuChuNhiem_Click(object sender, EventArgs e)
        { new FrmLOPCHUNHIEM().Show(); this.Close(); }
        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        { new FrmTHONGTINGIAOVIEN().Show(); this.Close(); }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            TaiKhoanDangNhap.MaNguoiDung = null;
            TaiKhoanDangNhap.LoaiNguoiDung = null;
            new FrmLOGIN().Show(); this.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e) { Application.Exit(); }
    }
}
