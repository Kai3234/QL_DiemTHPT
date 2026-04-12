using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QL_DiemTHPT
{
    public class FrmBCXEMDIEM : Form
    {
        public string MaHS { get; set; }
        public string MaLop { get; set; }
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public FrmBCXEMDIEM()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Size = new System.Drawing.Size(1100, 700);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.crystalReportViewer1);
            this.Text = "Báo cáo điểm học sinh";
            this.Load += new System.EventHandler(this.FrmBCXEMDIEM_Load);
        }

        private void FrmBCXEMDIEM_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Application.StartupPath + @"\Reports\rptXemDiem.rpt");
                rpt.SetDatabaseLogon("", "", @"DESKTOP-BOO9P8F\SQLEXPRESS", "QL_DIEMTHPT");
                rpt.RecordSelectionFormula =
                    "{VW_XEMDIEM_HOCSINH.MAHS} = '" + MaHS + "' AND " +
                    "{VW_XEMDIEM_HOCSINH.MALOP} = '" + MaLop + "'";
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi báo cáo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}