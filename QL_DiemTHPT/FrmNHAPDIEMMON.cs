using System;
using System.Data;
using System.Windows.Forms;

namespace QL_DiemTHPT
{
    public partial class FrmNHAPDIEMMON : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
        private string _maDiem = ""; 

        public FrmNHAPDIEMMON()
        {
            InitializeComponent();
        }

        private void FrmNHAPDIEMMON_Load(object sender, EventArgs e)
        {
            NapNamHoc();
            NapHocKy();
            NapLop();   
            NapMonHoc();
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

        private void NapLop()
        {
            DataTable dt = knn.LayBang("SELECT MALOP, TENLOP FROM LOP");
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
            cboLop.DataSource = dt;
            cboLop.SelectedIndex = -1;
        }

        private void NapMonHoc()
        {
            DataTable dt = knn.LayBang("SELECT MAMON, TENMON FROM MONHOC");
            cboMonHoc.DisplayMember = "TENMON";
            cboMonHoc.ValueMember = "MAMON";
            cboMonHoc.DataSource = dt;
            cboMonHoc.SelectedIndex = -1;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];
                _maDiem = row.Cells["MADIEM"].Value.ToString();

                txtDIEMTX.Text = row.Cells["DIEMTX"].Value?.ToString();
                txtDIEMGK.Text = row.Cells["DIEMGK"].Value?.ToString();
                txtDIEMCK.Text = row.Cells["DIEMCK"].Value?.ToString();
            }
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maDiem))
            {
                MessageBox.Show("Vui lòng chọn học sinh cần nhập điểm!");
                return;
            }

            string sql = string.Format(
                "UPDATE DIEM SET DIEMTX = '{0}', DIEMGK = '{1}', DIEMCK = '{2}' WHERE MADIEM = '{3}'",
                txtDIEMTX.Text, txtDIEMGK.Text, txtDIEMCK.Text, _maDiem
            );

            if (knn.ThucThi(sql))
            {
                MessageBox.Show("Lưu điểm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _maDiem = "";
                txtDIEMTX.Clear();
                txtDIEMGK.Clear();
                txtDIEMCK.Clear();
            }
            else
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu!");
            }
        }
        private void mnuTrangChu_Click(object sender, EventArgs e)
        {
            FrmMAINGV f = new FrmMAINGV();
            f.Show();
            this.Hide(); 
        }

        private void mnuNhapDiem_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuChuNhiem_Click(object sender, EventArgs e)
        {
            FrmLOPCHUNHIEM f = new FrmLOPCHUNHIEM();
            f.Show();
            this.Hide();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmTHONGTINGIAOVIEN f = new FrmTHONGTINGIAOVIEN();
            f.Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmNHAPDIEMMON_Load_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHocKy_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void mnuChuNhiem_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmNHAPDIEMMON_Load_2(object sender, EventArgs e)
        {

        }

        private void lblHuongDan_Click(object sender, EventArgs e)
        {

        }
    }
}