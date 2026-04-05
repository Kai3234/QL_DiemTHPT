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
    public partial class FrmChuyenLop : Form
    {
        KETNOI_CSDL knn = new KETNOI_CSDL();
        public void LoadDuLieuDauVao()
        {
            // Load DataGridView (Danh sách học sinh - lớp)
            string sqlGrid = "SELECT HOCSINH_LOP.MAHS, HOCSINH_LOP.MALOP, LOP.TENLOP " +
                             "FROM HOCSINH_LOP, LOP " +
                             "WHERE LOP.MALOP = HOCSINH_LOP.MALOP";
            DataTable dtGrid = knn.LayBang(sqlGrid);
            data_HOCSINH_LOP.DataSource = dtGrid;

            // Load ComboBox Lớp Cũ (Chỉ lấy những lớp đang có trong bảng HOCSINH_LOP)
            string sqlLopCu = "SELECT DISTINCT HOCSINH_LOP.MALOP, LOP.TENLOP " +
                              "FROM HOCSINH_LOP, LOP WHERE LOP.MALOP = HOCSINH_LOP.MALOP";
            DataTable dtLopCu = knn.LayBang(sqlLopCu);
            cobLopCu.DataSource = dtLopCu;
            cobLopCu.DisplayMember = "MALOP";
            cobLopCu.ValueMember = "TENLOP";

            // Load ComboBox Lớp Mới (Tất cả các lớp trong bảng LOP)
            string sqlLopMoi = "SELECT MALOP, TENLOP FROM LOP";
            DataTable dtLopMoi = knn.LayBang(sqlLopMoi);
            cobLopMoi.DataSource = dtLopMoi;
            cobLopMoi.DisplayMember = "MALOP";
            cobLopMoi.ValueMember = "TENLOP";

            // Reset lựa chọn ban đầu để không bị tự nhảy tên lớp khi vừa mở form
            cobLopCu.SelectedIndex = -1;
            cobLopMoi.SelectedIndex = -1;
            txtTenLopCu.Text = "";
            txtTenLopMoi.Text = "";
        }

        public void LayBangHocSinh_Lop()
        {
            string sql = "SELECT DISTINCT HOCSINH_LOP.MAHS, HOCSINH_LOP.MALOP, LOP.TENLOP " +
                         "FROM HOCSINH_LOP, LOP " +
                         "WHERE LOP.MALOP = HOCSINH_LOP.MALOP";

            DataTable dt = knn.LayBang(sql);
            if (dt != null)
            {
                data_HOCSINH_LOP.DataSource = dt;
            }
        }

        public FrmChuyenLop()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy Mã lớp trực tiếp từ thuộc tính Text của ComboBox
            string oldCode = cobLopCu.Text.Trim();
            string newCode = cobLopMoi.Text.Trim();

            if (string.IsNullOrEmpty(oldCode) || string.IsNullOrEmpty(newCode))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ lớp cũ và lớp mới!");
                return;
            }

            if (newCode == oldCode)
            {
                MessageBox.Show("Lớp mới phải khác lớp cũ!");
                return;
            }

            // Xác nhận trước khi thực hiện cập nhật hàng loạt
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn chuyển toàn bộ học sinh lớp {oldCode} sang lớp {newCode}?",
                                             "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string qChangeLop = "UPDATE HOCSINH_LOP SET MALOP = '" + newCode + "' WHERE MALOP = '" + oldCode + "'";
                    knn.ThucThi(qChangeLop);

                    MessageBox.Show("Chuyển lớp thành công!", "Thông báo");

                    // Load lại dữ liệu để cập nhật danh sách và ComboBox
                    LoadDuLieuDauVao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chuyển lớp: " + ex.Message);
                }
            }
        

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmChuyenLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_DIEMTHPTDataSet7.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qL_DIEMTHPTDataSet7.LOP);
            // TODO: This line of code loads data into the 'qL_DIEMTHPTDataSet6.HOCSINH_LOP' table. You can move, or remove it, as needed.
            this.hOCSINH_LOPTableAdapter.Fill(this.qL_DIEMTHPTDataSet6.HOCSINH_LOP);
            LayBangHocSinh_Lop();
            LoadDuLieuDauVao();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cobLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobLopCu.SelectedValue != null)
            {
                txtTenLopCu.Text = cobLopCu.SelectedValue.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cobLopMoi.SelectedValue != null)
            {
                txtTenLopMoi.Text = cobLopMoi.SelectedValue.ToString();
            }
        }
    }
}
