using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string sqlGrid = "SELECT HOCSINH_LOP.MAHS, HOCSINH_LOP.MALOP, LOP.TENLOP " +
                             "FROM HOCSINH_LOP, LOP " +
                             "WHERE LOP.MALOP = HOCSINH_LOP.MALOP";
            DataTable dtGrid = knn.LayBang(sqlGrid);
            data_HOCSINH_LOP.DataSource = dtGrid;

            string sqlLopCu = "SELECT DISTINCT HOCSINH_LOP.MALOP, LOP.TENLOP " +
                              "FROM HOCSINH_LOP, LOP WHERE LOP.MALOP = HOCSINH_LOP.MALOP";
            DataTable dtLopCu = knn.LayBang(sqlLopCu);
            cobLopCu.DataSource = dtLopCu;
            cobLopCu.DisplayMember = "MALOP";
            cobLopCu.ValueMember = "TENLOP";

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

        private void txtTenLopCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
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

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn chuyển toàn bộ học sinh lớp {oldCode} sang lớp {newCode}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string sql = @"
                INSERT INTO HOCSINH_LOP(MALOP, MAHS)
                SELECT @NewClass, MAHS
                FROM HOCSINH_LOP old
                WHERE old.MALOP = @OldClass
                AND NOT EXISTS (
                    SELECT 1
                    FROM HOCSINH_LOP new
                    WHERE new.MALOP = @NewClass
                    AND new.MAHS = old.MAHS
                )";

                    SqlCommand cmd = new SqlCommand(sql, knn.cnn);
                    cmd.Parameters.AddWithValue("@OldClass", oldCode);
                    cmd.Parameters.AddWithValue("@NewClass", newCode);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Chuyển lớp thành công!", "Thông báo");
                    LoadDuLieuDauVao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chuyển lớp: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string oldCode = cobLopCu.Text.Trim();

            if (string.IsNullOrEmpty(oldCode))
            {
                MessageBox.Show("Vui lòng chọn lớp cần xoá!");
                return;
            }

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn xoá toàn bộ học sinh khỏi lớp {oldCode}?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    string sql = @"DELETE FROM HOCSINH_LOP
                           WHERE MALOP = @OldClass";

                    SqlCommand cmd = new SqlCommand(sql, knn.cnn);
                    cmd.Parameters.AddWithValue("@OldClass", oldCode);

                    int rows = cmd.ExecuteNonQuery();

                    MessageBox.Show($"Đã xoá {rows} học sinh khỏi lớp {oldCode}!",
                                    "Thông báo");

                    LoadDuLieuDauVao();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xoá: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
