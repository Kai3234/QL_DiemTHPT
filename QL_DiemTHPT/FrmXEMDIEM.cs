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
    public partial class FrmXEMDIEM : Form
    {
        KETNOI_CSDL kn = new KETNOI_CSDL();
        
        public FrmXEMDIEM()
        {
            InitializeComponent();
        }

        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            FrmMAINHS fnew = new FrmMAINHS();
            fnew.Show();
            this.Close();
        }

        private void mnuXemDiem_Click(object sender, EventArgs e)
        {
            FrmXEMDIEM fnew = new FrmXEMDIEM();
            fnew.Show();
            this.Close();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTHONGTINHOCSINH fnew = new FrmTHONGTINHOCSINH();
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

        private void FrmXEMDIEM_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
            LoadLop();
            LoadHocKy();
        }

        private void LoadNamHoc()
        {
            DataTable dt = kn.LayBang("SELECT MANH, TENNAM FROM NAMHOC");
            cboNamHoc.DataSource = dt;
            cboNamHoc.DisplayMember = "TENNAM";
            cboNamHoc.ValueMember = "MANH";
        }

        private void LoadLop()
        {
            string sql = @"SELECT l.MALOP, l.TENLOP 
                          FROM LOP l 
                          INNER JOIN HOCSINH_LOP hl ON l.MALOP = hl.MALOP 
                          WHERE hl.MAHS = '" + TaiKhoanDangNhap.MaNguoiDung + "'";
            DataTable dt = kn.LayBang(sql);
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }

        private void LoadHocKy()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAHK");
            dt.Columns.Add("TENHK");
            dt.Rows.Add("1", "Học kỳ I");
            dt.Rows.Add("2", "Học kỳ II");
            dt.Rows.Add("3", "Cả năm");
            cboHocKy.DataSource = dt;
            cboHocKy.DisplayMember = "TENHK";
            cboHocKy.ValueMember = "MAHK";
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue == null || cboLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn năm học và lớp!");
                return;
            }

            string hocKy = cboHocKy.SelectedValue.ToString();
            string sql;

            if (hocKy == "3")
            {
                sql = @"SELECT m.TENMON,
                              AVG(CASE WHEN d.HOCKY = 1 THEN d.DIEMTB END) AS DIEMTBHK1,
                              AVG(CASE WHEN d.HOCKY = 2 THEN d.DIEMTB END) AS DIEMTBHK2,
                              AVG(d.DIEMTB) AS DIEMTBCN,
                              CASE 
                                  WHEN AVG(d.DIEMTB) >= 9 THEN N'Tốt'
                                  WHEN AVG(d.DIEMTB) >= 7 THEN N'Khá'
                                  WHEN AVG(d.DIEMTB) >= 5 THEN N'Đạt'
                                  ELSE N'Chưa đạt'
                              END AS XEPLOAI
                       FROM MONHOC m
                       LEFT JOIN DIEM d ON m.MAMH = d.MAMH 
                           AND d.MAHS = '" + TaiKhoanDangNhap.MaNguoiDung + @"'
                           AND d.MANH = '" + cboNamHoc.SelectedValue + @"'
                       GROUP BY m.MAMH, m.TENMON
                       ORDER BY m.TENMON";
            }
            else
            {
                sql = @"SELECT m.TENMON, d.DIEMTX, d.DIEMGK, d.DIEMCK, d.DIEMTB,
                              CASE 
                                  WHEN d.DIEMTB >= 9 THEN N'Tốt'
                                  WHEN d.DIEMTB >= 7 THEN N'Khá'
                                  WHEN d.DIEMTB >= 5 THEN N'Đạt'
                                  ELSE N'Chưa đạt'
                              END AS XEPLOAI
                       FROM MONHOC m
                       LEFT JOIN DIEM d ON m.MAMH = d.MAMH 
                           AND d.MAHS = '" + TaiKhoanDangNhap.MaNguoiDung + @"'
                           AND d.MANH = '" + cboNamHoc.SelectedValue + @"'
                           AND d.HOCKY = " + hocKy + @"
                       GROUP BY m.MAMH, m.TENMON, d.DIEMTX, d.DIEMGK, d.DIEMCK, d.DIEMTB
                       ORDER BY m.TENMON";
            }

            DataTable dt = kn.LayBang(sql);
            dataGridViewDiem.DataSource = dt;

            if (hocKy == "3")
            {
                dataGridViewDiem.Columns["TENMON"].HeaderText = "Môn học";
                dataGridViewDiem.Columns["DIEMTBHK1"].HeaderText = "ĐTB HK1";
                dataGridViewDiem.Columns["DIEMTBHK2"].HeaderText = "ĐTB HK2";
                dataGridViewDiem.Columns["DIEMTBCN"].HeaderText = "ĐTB Cả năm";
                dataGridViewDiem.Columns["XEPLOAI"].HeaderText = "Xếp loại";
            }
            else
            {
                dataGridViewDiem.Columns["TENMON"].HeaderText = "Môn học";
                dataGridViewDiem.Columns["DIEMTX"].HeaderText = "Điểm TX";
                dataGridViewDiem.Columns["DIEMGK"].HeaderText = "Điểm GK";
                dataGridViewDiem.Columns["DIEMCK"].HeaderText = "Điểm CK";
                dataGridViewDiem.Columns["DIEMTB"].HeaderText = "ĐTB";
                dataGridViewDiem.Columns["XEPLOAI"].HeaderText = "Xếp loại";
            }

            UpdatePersonalSummary(dt, hocKy);
        }

        private void UpdatePersonalSummary(DataTable dt, string hocKy)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                lblXepLoai.Text = "Xếp loại: --";
                lblTongMon.Text = "Tổng số môn: 0";
                lblDaCoDiem.Text = "Đã có điểm: 0";
                lblChuaCoDiem.Text = "Chưa có điểm: 0";
                return;
            }

            int tongMon = dt.Rows.Count;
            int coDiem = 0;
            string xepLoai = "";

            if (hocKy == "3")
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DIEMTBCN"] != DBNull.Value && Convert.ToDouble(row["DIEMTBCN"]) > 0)
                        coDiem++;
                }
                if (dt.Rows[0]["XEPLOAI"] != DBNull.Value)
                    xepLoai = dt.Rows[0]["XEPLOAI"].ToString();
            }
            else
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["DIEMTB"] != DBNull.Value && Convert.ToDouble(row["DIEMTB"]) > 0)
                        coDiem++;
                }
                if (dt.Rows[0]["XEPLOAI"] != DBNull.Value)
                    xepLoai = dt.Rows[0]["XEPLOAI"].ToString();
            }

            lblXepLoai.Text = $"Xếp loại: {xepLoai}";
            lblTongMon.Text = $"Tổng số môn: {tongMon}";
            lblDaCoDiem.Text = $"Đã có điểm: {coDiem}";
            lblChuaCoDiem.Text = $"Chưa có điểm: {tongMon - coDiem}";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn năm học!");
                return;
            }

            FrmBaoCaoDiemCaNhan f = new FrmBaoCaoDiemCaNhan();
            f.MaHS = TaiKhoanDangNhap.MaNguoiDung;
            f.MaNamHoc = cboNamHoc.SelectedValue.ToString();
            f.HocKy = cboHocKy.SelectedValue.ToString();
            f.ShowDialog();
        }


    }
}
