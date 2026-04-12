using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmLOPCHUNHIEM : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();

        public FrmLOPCHUNHIEM()
        {
            InitializeComponent();
        }

        private void FrmLOPCHUNHIEM_Load(object sender, EventArgs e)
        {
            NapLopChuNhiem();
        }

        
        private void NapLopChuNhiem()
        {
            string sql = string.Format(
                @"SELECT l.MALOP,
                         l.TENLOP + ' - ' + nh.TENNAM AS HIENTHI
                  FROM LOP l
                  INNER JOIN NAMHOC nh ON l.MANH = nh.MANH
                  WHERE l.MAGVCHUNHIEM = '{0}'
                  ORDER BY nh.MANH DESC, l.TENLOP",
                TaiKhoanDangNhap.MaNguoiDung);

            DataTable dt = knn.LayBang(sql);
            cboLop.DisplayMember = "HIENTHI";
            cboLop.ValueMember = "MALOP";
            cboLop.DataSource = dt;
            cboLop.SelectedIndex = -1;
        }

        
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null) return;
            string maLop = cboLop.SelectedValue.ToString();
            HienThiBang(maLop);
        }

        
        private void HienThiBang(string maLop)
        {
            string sql = string.Format(
                @"SELECT
                    v.MAHS          AS [Mã HS],
                    v.TENHOCSINH    AS [Họ tên],
                    v.NGAYSINH      AS [Ngày sinh],
                    v.GIOITINH      AS [Giới tính],
                    v.DIEMTBHKI     AS [ĐTBHKI],
                    v.DIEMTBHKII    AS [ĐTBHKII],
                    v.DIEMTBNAM     AS [ĐTBCN],
                    CASE
                        WHEN v.DIEMTBNAM >= 8.0 THEN N'Tốt'
                        WHEN v.DIEMTBNAM >= 6.5 THEN N'Khá'
                        WHEN v.DIEMTBNAM >= 5.0 THEN N'Đạt'
                        WHEN v.DIEMTBNAM IS NOT NULL THEN N'Chưa đạt'
                        ELSE N'Chưa có điểm'
                    END AS [Xếp loại]
                  FROM VW_DIEMTB_HOCSINH_LOP v
                  WHERE v.MALOP = '{0}'
                  ORDER BY v.TENHOCSINH", maLop);

            DataTable dt = knn.LayBang(sql);
            dgvHocSinh.DataSource = dt;
            dgvHocSinh.ReadOnly = true;
            dgvHocSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            HienThiThongKe(dt);
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
                "Sĩ số: {0}   |   Tốt: {1}   Khá: {2}   Đạt: {3}   Chưa đạt: {4}   Chưa có điểm: {5}",
                total, tot, kha, dat, chuaDat, chuaDiem);
        }

        
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (cboLop.SelectedValue == null)
            { MessageBox.Show("Vui lòng chọn lớp trước khi xuất báo cáo!"); return; }

            FrmBCLOPCHUNHIEM fbc = new FrmBCLOPCHUNHIEM();
            fbc.MaLop = cboLop.SelectedValue.ToString();
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
