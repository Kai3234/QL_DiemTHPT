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
    public partial class FrmBAOCAOGIAOVIEN : Form
    {
        private string maNamHoc;
        private string tenNamHoc;
        private string hocKy;

        public FrmBAOCAOGIAOVIEN(string maNamHoc, string tenNamHoc, string hocKy)
        {
            InitializeComponent();

            this.maNamHoc = maNamHoc;
            this.tenNamHoc = tenNamHoc;
            this.hocKy = hocKy;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        KETNOI_CSDL knn = new KETNOI_CSDL();



        private void FrmBAOCAOGIAOVIEN_Load(object sender, EventArgs e)
        {
            string sql =
                    @"SELECT *
              FROM VW_GIAOVIEN_BAOCAO
              WHERE MANH = '" + maNamHoc + "'";

            // thêm điều kiện học kỳ
            if (hocKy == "Học kỳ I")
            {
                sql += " AND HOCKY = 1";
            }
            else if (hocKy == "Học kỳ II")
            {
                sql += " AND HOCKY = 2";
            }

            DataTable dta = new DataTable();
            dta = knn.LayBang(sql);

            RptBAOCAO_GIAOVIEN rpt = new RptBAOCAO_GIAOVIEN();
            rpt.SetDataSource(dta);

            rpt.SetParameterValue("NamHoc", tenNamHoc);
            rpt.SetParameterValue("HocKy", hocKy);

            crystalReportViewer1.ReportSource = rpt;
        }
    }
    
}
