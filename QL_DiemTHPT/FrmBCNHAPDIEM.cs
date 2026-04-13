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
    public partial class FrmBCNHAPDIEM : Form
    {

        public string MaPC { get; set; }

        KETNOI_CSDL knn = new KETNOI_CSDL();

        public FrmBCNHAPDIEM()
        {
            InitializeComponent();
        }

        private void FrmBCNHAPDIEM_Load(object sender, EventArgs e)
        {
            try
            {
                // ===== SQL =====
                string sql =
                    @"SELECT *
                  FROM VW_BAOCAO_NHAPDIEM
                  WHERE MAPC = '" + MaPC + "'";

                DataTable dta = knn.LayBang(sql);

                // ===== Report =====
                rptNhapDiem rpt = new rptNhapDiem();

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
