using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QL_DiemTHPT
{
    public partial class FrmTHONGTINGIAOVIEN : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
            BindingSource bd = new BindingSource();
        public void LayBangGiaoVien()
        {
            DataTable dt = knn.LayBang("SELECT * FROM GIAOVIEN WHERE MAGV = '" + TaiKhoanDangNhap.MaNguoiDung + "'");
            bd.DataSource = dt;
            if (dt != null && dt.Rows.Count > 0)
            {
                bd.DataSource = dt;
                HienThiDuLieu();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin giáo viên! Kiểm tra lại mã: " + TaiKhoanDangNhap.MaNguoiDung);
            }
        }
        public void HienThiDuLieu()
        {
            txtMaGV.DataBindings.Clear();
            txtMaGV.DataBindings.Add("Text", bd, "MAGV");

            txtHoTenGV.DataBindings.Clear();
            txtHoTenGV.DataBindings.Add("Text",bd, "HOTEN");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text",bd , "DIACHI");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", bd, "MATKHAU");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bd, "NGAYSINH",true);

            cboGioiTinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Add("SelectedItem", bd, "GIOITINH");
        }

        public FrmTHONGTINGIAOVIEN()
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


        private void FrmTHONGTINGIAOVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DIEMTHPTDataSet3.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter1.Fill(this.qL_DIEMTHPTDataSet3.GIAOVIEN);
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
                LayBangGiaoVien();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMAGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDIACHI_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            FrmDOIMATKHAU fnew = new FrmDOIMATKHAU("teacher");
            fnew.ShowDialog();
             LayBangGiaoVien();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
