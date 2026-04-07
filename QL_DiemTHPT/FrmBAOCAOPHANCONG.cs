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
    public partial class FrmBAOCAOPHANCONG : Form
    {

        string maGV;
        string hoTen;
        string maNam;
        string tenNam;

        public FrmBAOCAOPHANCONG(string maGV, string hoTen,
                                  string maNam, string tenNam)
        {
            InitializeComponent();

            this.maGV = maGV;
            this.hoTen = hoTen;
            this.maNam = maNam;
            this.tenNam = tenNam;
        }

        KETNOI_CSDL knn = new KETNOI_CSDL();

        private void FrmBAOCAOPHANCONG_Load(object sender, EventArgs e)
        {
            string sql =
            @"SELECT *
              FROM VIEW_PHANCONG_BAOCAO
              WHERE MAGV = '" + maGV + "' AND MANH = '" + maNam + "'";

            DataTable dta = new DataTable();
            dta = knn.LayBang(sql);

            RptBAOCAO_PHANCONG rpt = new RptBAOCAO_PHANCONG();
            rpt.SetDataSource(dta);

            rpt.SetParameterValue("NamHoc", tenNam);
            rpt.SetParameterValue("MaGV", maGV);
            rpt.SetParameterValue("HoTenGV", hoTen);

            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
