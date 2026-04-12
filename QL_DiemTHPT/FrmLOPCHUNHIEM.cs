using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmLOPCHUNHIEM : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private string _maDiem = ""; 

        public FrmLOPCHUNHIEM()
        {
            InitializeComponent();
        }

        private void FrmLOPCHUNHIEM_Load(object sender, EventArgs e)
        {
            LoadDanhSachLop();
        }

        private void LoadDanhSachLop()
        {
            DataTable dt = knn.LayBang("SELECT * FROM VIEW_LOPCHUNHIEM");
            dgvLopChuNhiem.DataSource = dt;
        }

        private void dgvLopChuNhiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopChuNhiem.Rows[e.RowIndex];

                if (row.Cells["MADIEM"].Value != null)
                {
                    _maDiem = row.Cells["MADIEM"].Value.ToString();

                    txtDIEMTX.Text = row.Cells["DIEMTX"].Value?.ToString();
                    txtDIEMGK.Text = row.Cells["DIEMGK"].Value?.ToString();
                    txtDIEMCK.Text = row.Cells["DIEMCK"].Value?.ToString();
                }
            }
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maDiem))
            {
                MessageBox.Show("Vui lòng chọn một học sinh!");
                return;
            }

            string sql = string.Format(
                "UPDATE DIEM SET DIEMTX = '{0}', DIEMGK = '{1}', DIEMCK = '{2}' WHERE MADIEM = '{3}'",
                txtDIEMTX.Text.Trim(), txtDIEMGK.Text.Trim(), txtDIEMCK.Text.Trim(), _maDiem
            );

            if (knn.ThucThi(sql))
            {
                MessageBox.Show("Cập nhật điểm thành công!");
                LoadDanhSachLop(); 
            }
            else
            {
                MessageBox.Show("Lỗi: Không thể lưu điểm!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e) => Application.Exit();
        private void btnDangXuat_Click(object sender, EventArgs e) => this.Close();
        private void mnuTrangChu_Click(object sender, EventArgs e) { new FrmMAINGV().Show(); this.Close(); }
        private void mnuNhapDiem_Click(object sender, EventArgs e) { new FrmNHAPDIEMMON().Show(); this.Close(); }
        private void mnuChuNhiem_Click(object sender, EventArgs e) { }
        private void mnuTaiKhoan_Click(object sender, EventArgs e) { new FrmTHONGTINGIAOVIEN().Show(); this.Close(); }
    }
}