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
    public partial class FrmBCGIAOVIEN : Form
    {
        public string maNam;
        public string tenNam;
        public string hocKy;

        public FrmBCGIAOVIEN(string maNH, string tenNH, string hk)
        {
            InitializeComponent();

            this.maNam = maNH;
            this.tenNam = tenNH;
            this.hocKy = hk;
        }

        private void FrmBCGIAOVIEN_Load(object sender, EventArgs e)
        {
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}