using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangThiNgocNu_Tuan4
{
    public class NguoiDung
    {

        public static string tenDangNhap;
        public List<string> getMaNhomNguoiDung(string pUser)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select MaNhomNguoiDung from QL_NguoiDungNhomNguoiDung where TenDangNhap='" + pUser + "'", Properties.Settings.Default.ABC);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            List<string> a = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                a.Add(row[0].ToString());
            }
            return a;
        }


    }
}
