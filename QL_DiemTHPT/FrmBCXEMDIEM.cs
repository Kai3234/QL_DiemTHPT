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
    public partial class FrmBCXEMDIEM : Form
    {
        public string MaHS { get; set; }
        public string MaLop { get; set; }

        KETNOI_CSDL knn = new KETNOI_CSDL();
        public FrmBCXEMDIEM()
        {
            InitializeComponent();
        }

        private void FrmBCXEMDIEM_Load(object sender, EventArgs e)
        {
            try
            {
                // ===== SQL =====
                string sql =
                    @"SELECT *
                      FROM VW_XEMDIEM_HOCSINH
                      WHERE MAHS = '" + MaHS + "' AND MALOP = '" + MaLop + "'";

                DataTable dta = knn.LayBang(sql);

                // ===== Report =====
                rptXemDiem rpt = new rptXemDiem();

                rpt.SetDataSource(dta);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message,
                    "Lỗi báo cáo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
