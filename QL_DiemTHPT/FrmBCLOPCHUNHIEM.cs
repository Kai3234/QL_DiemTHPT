using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace QL_DiemTHPT
{
    public class FrmBCLOPCHUNHIEM : Form
    {
        public string MaLop { get; set; }
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public FrmBCLOPCHUNHIEM()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Size = new System.Drawing.Size(1100, 700);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.crystalReportViewer1);
            this.Text = "Báo cáo kết quả lớp chủ nhiệm";
            this.Load += new System.EventHandler(this.FrmBCLOPCHUNHIEM_Load);
        }

        private void FrmBCLOPCHUNHIEM_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Application.StartupPath + @"\Reports\rptLopChuNhiem.rpt");
                rpt.SetDatabaseLogon("", "", @"DESKTOP-BOO9P8F\SQLEXPRESS", "QL_DIEMTHPT");
                rpt.RecordSelectionFormula = "{VW_BAOCAO_LOPCHUNHIEM.MALOP} = '" + MaLop + "'";
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