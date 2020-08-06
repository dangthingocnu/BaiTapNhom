using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
namespace Bussiness
{
    public class GiaoVienBS
    {
        private GiaoVienDA nvda;
        public GiaoVienBS()
        {
            try
            {
                nvda = new GiaoVienDA();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataSet DangNhapNV(string tendn, string pass)
        {
            nvda = new GiaoVienDA();
            return nvda.DangNhapNV(tendn, pass);
        }
        public DataSet ThongTinNV(string pass)
        {
            nvda = new GiaoVienDA();
            return nvda.ThongTinNV(pass);
        }
        public DataSet GetGiaoVien()
        {
            nvda = new GiaoVienDA();
            return nvda.GetGiaoVien();
        }
        public DataSet GetGiaoVienCV(string cv)
        {
            nvda = new GiaoVienDA();
            return nvda.GetGiaoVienCV(cv);
        }
        public DataSet TimKiemGV(string hoTen)
        {
            nvda = new GiaoVienDA();
            return nvda.TimKiemGiaoVien(hoTen);
        }
        //public DataSet GetTensTendn(string pass)
        //{
        //    nvda = new GiaoVienDA();
        //    return nvda.GetTensTendn(pass);
        //}
        //public int DoiMatKhau(string tendn, string mkcu, string mkmoi)
        //{
        //    nvda = new GiaoVienDA();
        //    return nvda.DoiMatKhau(tendn, mkcu, mkmoi);
        //}
        public DataSet GetGiaoVienL2()
        {
            nvda = new GiaoVienDA();
            return nvda.GetGiaoVienL2();
        }

        public DataSet GetChucVu()
        {
            nvda = new GiaoVienDA();
            return nvda.GetChuVu();
        }

        public DataSet GetGiaoVien_Ma(string ma)
        {
            nvda = new GiaoVienDA();
            return nvda.GetGiaoVien_Ma(ma);
        }
        public int ThemNV(string manv, string hoten, string diachi, string sodt, string ngays, string chucv)
        {
            nvda = new GiaoVienDA();
            return nvda.ThemNV(manv, hoten, diachi, sodt, ngays, chucv);
        }
        public int ThemTaiKhoan(string mand, string tendn, string mk, string loai, string manv)
        {
            nvda = new GiaoVienDA();
            return nvda.ThemTaiKhoan(mand, tendn, mk, loai, manv);
        }
        public int UpdateGiaoVien(string hoTen, string chucVu, string diachi, string sodt, string ns, string ma)
        {
            nvda = new GiaoVienDA();
            return nvda.UpdateGiaoVien(hoTen, chucVu, diachi, sodt, ns, ma);
        }

        public DataSet GetSoCH_MaNV(string manv)
        {
            nvda = new GiaoVienDA();
            return nvda.GetSoCH_MaNV(manv);
        }
        public int DeleteGiaoVien_0(string manv)
        {
            nvda = new GiaoVienDA();
            return nvda.DeleteGiaoVien_0(manv);
        }
    }
}
