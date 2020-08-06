using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class GiaoVienDA
    {
        private SqlDataAdapter damt;
        public SqlConnection getcon()
        {
            String strcon = @"Data Source=DESKTOP-986FM3J\SQLEXPRESS;Initial Catalog=QL_TracNghiem;Integrated Security=True";
            //String strcon = @"server=192.168.101.56\sqlexpress;Database=DB_Bao_Cao_Xuyen;uid=xuyen_baby; pwd=67896789;";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            return con;
        }
        public DataSet DangNhapNV(string tendn, string pass)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select * from Table_NguoiDung D join Table_GiaoVien N on D.MaGiaoVien=N.MaGiaoVien where TenNguoiDung='" + tendn + "' and MatKhauNguoiDung='" + pass + "'", con);
            damt.Fill(ds, "Table_NguoiDung");
            return ds;

        }
        public DataSet ThongTinNV(string pass)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select * from Table_GiaoVien N join Table_NguoiDung D on N.MaGiaoVien=D.MaGiaoVien where D.MatKhauNguoiDung='" + pass + "'", con);
            damt.Fill(ds, "Table_NguoiDung");
            return ds;
        }
        public DataSet GetGiaoVien()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_GiaoVien", con);
            damt.Fill(ds, "Table_GiaoVien");
            return ds;
        }
        public DataSet GetGiaoVienCV(string cv)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_GiaoVien where ChucVu like N'%" + cv + "%'", con);
            damt.Fill(ds, "Table_GiaoVien");
            return ds;
        }
        public DataSet TimKiemGiaoVien(string hoTen)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_GiaoVien where HoTen like N'%" + hoTen + "%' or MaGiaoVien  like N'%" + hoTen + "%'", con);
            damt.Fill(ds, "Table_GiaoVien");
            return ds;
        }
        //public DataSet GetTensTendn(string pass) // lop nay dung de ???
        //{
        //    DataSet ds = new DataSet();
        //    SqlConnection con = getcon();
        //    damt = new SqlDataAdapter("select N.TenNguoiDung,V.HoTen from Table_NguoiDung N join Table_GiaoVien V on N.MaGiaoVien=V.MaGiaoVien where N.MatKhauNguoiDung='" + pass + "'", con);
        //    damt.Fill(ds, "Table_GiaoVien");
        //    return ds;
        //}
        //public int DoiMatKhau(string tendn, string mkcu, string mkmoi)
        //{
        //    try
        //    {
        //        int x = 0;
        //        SqlConnection con = getcon();
        //        string sql = "update Table_NguoiDung set MatKhauNguoiDung='" + mkmoi + "' where TenNguoiDung='" + tendn + "' and MatKhauNguoiDung='" + mkcu + "'";
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        x = cmd.ExecuteNonQuery(); // ham nay lam gi ?
        //        con.Close();
        //        return x;
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception("Không thể thay đổi mật khẩu");
        //    }
        //}
        public DataSet GetGiaoVienL2()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_GiaoVien ", con); // y nghia cua dong lenh nay
            damt.Fill(ds, "Table_GiaoVien");
            return ds;
        }

        public DataSet GetChuVu()
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select distinct chucvu from Table_GiaoVien ", con); // y nghia cua dong lenh nay
            damt.Fill(ds, "Table_GiaoVien");
            return ds;
        }

        public DataSet GetGiaoVien_Ma(string ma)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("Select * from Table_GiaoVien where MaGiaoVien='" + ma + "'", con);
            damt.Fill(ds, "Table_GiaoVien");
            return ds;
        }
        public int ThemNV(string manv, string hoten, string diachi, string sodt, string ngays, string chucv)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_GiaoVien values('" + manv + "',N'" + hoten + "',N'" + diachi + "','" + sodt + "','" + ngays + "',N'" + chucv + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm giao viên");
            }
        }
        public int ThemTaiKhoan(string mand, string tendn, string mk, string loai, string manv)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "insert Table_NguoiDung values('" + mand + "','" + tendn + "','" + mk + "','" + loai + "','" + manv + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm tài khoản");
            }
        }
        public int UpdateGiaoVien(string hoTen, string chucVu, string diachi, string sodt, string ns, string ma)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "update Table_GiaoVien set HoTen=N'" + hoTen + "',ChucVu=N'" + chucVu + "', DiaChi=N'" + diachi + "', SoDienThoai='" + sodt + "', NgaySinh='" + ns + "' where MaGiaoVien='" + ma + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể thêm tài khoản");
            }
        }
        public DataSet GetSoCH_MaNV(string manv)
        {
            DataSet ds = new DataSet();
            SqlConnection con = getcon();
            damt = new SqlDataAdapter("select count(C.MaCauHoi) from Table_CauHoi C join Table_NguoiDung N on C.MaNguoiDung=N.MaNguoiDung  where N.MaGiaoVien='" + manv + "'  ", con);
            damt.Fill(ds, "Table_CauHoi");
            return ds;
        }
        public int DeleteGiaoVien_0(string manv)
        {
            try
            {
                int x = 0;
                SqlConnection con = getcon();
                string sql = "delete Table_NguoiDung where MaGiaoVien='" + manv + "' delete Table_GiaoVien where MaGiaoVien='" + manv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                x = cmd.ExecuteNonQuery();
                con.Close();
                return x;
            }
            catch (Exception)
            {
                throw new Exception("Không thể xóa nhân viên khoản");
            }
        }
    }
}
