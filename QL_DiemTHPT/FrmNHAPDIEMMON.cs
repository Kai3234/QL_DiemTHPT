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
    public partial class FrmNHAPDIEMMON : Form
    {
        KETNOI_CSDL kn = new KETNOI_CSDL();
        DataTable dtDiem;
        
        public FrmNHAPDIEMMON()
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

        private void FrmNHAPDIEMMON_Load(object sender, EventArgs e)
        {

        }

        private void FrmNHAPDIEMMON_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
            LoadHocKy();
            LoadMonHoc();
            LoadLop();
        }

        private void LoadNamHoc()
        {
            DataTable dt = kn.LayBang("SELECT MANH, TENNAM FROM NAMHOC");
            cboNamHoc.DataSource = dt;
            cboNamHoc.DisplayMember = "TENNAM";
            cboNamHoc.ValueMember = "MANH";
        }

        private void LoadHocKy()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAHK");
            dt.Columns.Add("TENHK");
            dt.Rows.Add("1", "Học kỳ I");
            dt.Rows.Add("2", "Học kỳ II");
            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TENHK";
            cboHocKy.ValueMember = "MAHK";
        }

        private void LoadMonHoc()
        {
            DataTable dt = kn.LayBang("SELECT MAMH, TENMON FROM MONHOC");
            cboMonHoc.DataSource = dt;
            cboMonHoc.DisplayMember = "TENMON";
            cboMonHoc.ValueMember = "MAMH";
        }

        private void LoadLop()
        {
            string sql = @"SELECT DISTINCT l.MALOP, l.TENLOP 
                          FROM LOP l 
                          INNER JOIN PHANCONG pc ON l.MALOP = pc.MALOP 
                          WHERE pc.MAGV = '" + TaiKhoanDangNhap.MaNguoiDung + "'";
            DataTable dt = kn.LayBang(sql);
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }

        private void btnLoadDiem_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null || 
                cboNamHoc.SelectedValue == null || cboHocKy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!");
                return;
            }

            string sql = @"SELECT hs.MAHS, hs.HOTEN, 
                                  ISNULL(d.DIEMTX, 0) AS DIEMTX, 
                                  ISNULL(d.DIEMGK, 0) AS DIEMGK, 
                                  ISNULL(d.DIEMCK, 0) AS DIEMCK,
                                  d.MADIEM,
                                  CASE WHEN d.DIEMTX IS NULL THEN 0 ELSE 1 END AS CODIEM
                           FROM HOCSINH hs
                           INNER JOIN HOCSINH_LOP hl ON hs.MAHS = hl.MAHS
                           LEFT JOIN DIEM d ON hs.MAHS = d.MAHS 
                               AND d.MAMH = '" + cboMonHoc.SelectedValue + @"'
                               AND d.MANH = '" + cboNamHoc.SelectedValue + @"'
                               AND d.HOCKY = " + cboHocKy.SelectedValue + @"
                           WHERE hl.MALOP = '" + cboLop.SelectedValue + @"'
                           ORDER BY hs.MAHS";

            dtDiem = kn.LayBang(sql);
            dataGridViewDiem.DataSource = dtDiem;

            if (dataGridViewDiem.Columns["MADIEM"] != null)
                dataGridViewDiem.Columns["MADIEM"].Visible = false;
            if (dataGridViewDiem.Columns["CODIEM"] != null)
                dataGridViewDiem.Columns["CODIEM"].Visible = false;

            dataGridViewDiem.Columns["MAHS"].HeaderText = "Mã HS";
            dataGridViewDiem.Columns["HOTEN"].HeaderText = "Họ tên";
            dataGridViewDiem.Columns["DIEMTX"].HeaderText = "Điểm TX";
            dataGridViewDiem.Columns["DIEMGK"].HeaderText = "Điểm GK";
            dataGridViewDiem.Columns["DIEMCK"].HeaderText = "Điểm CK";

            UpdateSummary();
        }

        private void dataGridViewDiem_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4))
            {
                UpdateSummary();
            }
        }

        private void UpdateSummary()
        {
            if (dtDiem == null) return;

            int total = dtDiem.Rows.Count;
            int daNhap = 0;
            foreach (DataRow row in dtDiem.Rows)
            {
                if (Convert.ToInt32(row["CODIEM"]) == 1)
                    daNhap++;
            }

            lblTongSo.Text = $"Tổng số HS: {total}";
            lblDaNhap.Text = $"Đã nhập điểm: {daNhap}";
            lblChuaNhap.Text = $"Chưa nhập: {total - daNhap}";
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (dtDiem == null || dtDiem.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu!");
                return;
            }

            int saved = 0;
            foreach (DataRow row in dtDiem.Rows)
            {
                string maHS = row["MAHS"].ToString();
                double diemTX = Convert.ToDouble(row["DIEMTX"]);
                double diemGK = Convert.ToDouble(row["DIEMGK"]);
                double diemCK = Convert.ToDouble(row["DIEMCK"]);
                int coDiem = Convert.ToInt32(row["CODIEM"]);

                if (coDiem == 0)
                {
                    string sql = $@"INSERT INTO DIEM (MAHS, MAMH, MANH, HOCKY, DIEMTX, DIEMGK, DIEMCK) 
                                   VALUES ('{maHS}', '{cboMonHoc.SelectedValue}', '{cboNamHoc.SelectedValue}', 
                                           {cboHocKy.SelectedValue}, {diemTX}, {diemGK}, {diemCK})";
                    kn.ThucThi(sql);
                }
                else
                {
                    string sql = $@"UPDATE DIEM SET DIEMTX = {diemTX}, DIEMGK = {diemGK}, DIEMCK = {diemCK} 
                                   WHERE MADIEM = {row["MADIEM"]}";
                    kn.ThucThi(sql);
                }
                saved++;
            }

            MessageBox.Show($"Đã lưu {saved} bản ghi điểm!");
            btnLoadDiem_Click(null, null);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null || cboMonHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp và môn học!");
                return;
            }

            FrmBaoCaoDiemMon f = new FrmBaoCaoDiemMon();
            f.MaLop = cboLop.SelectedValue.ToString();
            f.MaMon = cboMonHoc.SelectedValue.ToString();
            f.MaNamHoc = cboNamHoc.SelectedValue.ToString();
            f.HocKy = cboHocKy.SelectedValue.ToString();
            f.ShowDialog();
        }
    }
}
