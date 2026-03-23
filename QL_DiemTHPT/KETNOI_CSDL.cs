using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_DiemTHPT
{
    internal class KETNOI_CSDL
    {
        public SqlConnection cnn;
        public SqlCommand CMD;
        public DataTable dta;
        public SqlDataAdapter ada;

        public void KetNoi_Dulieu()
        {
            // Thay đổi chuỗi kết nối phù hợp với cơ sở dữ liệu của bạn
            string strKetNoi = @"Data Source=DESKTOP-BOO9P8F\SQLEXPRESS;Initial Catalog=QL_DIEMTHPT;Integrated Security=True";
            cnn = new SqlConnection(strKetNoi);
            cnn.Open();
        }

        public void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }

        public DataTable LayBang(string Sql)
        {
            KetNoi_Dulieu();
            ada = new SqlDataAdapter(Sql, cnn);
            dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }

        public void ThucThi(string Sql)
        {
            KetNoi_Dulieu();
            CMD = new SqlCommand(Sql, cnn);
            CMD.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}

// Data Source=DESKTOP-BOO9P8F\SQLEXPRESS;Initial Catalog=QL_DIEMTHPT;Integrated Security=True;Encrypt=True;Trust Server Certificate=True
