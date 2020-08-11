using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class GiaoVien_BAL_DLL
    {
        private DB_QLTracNghiemDataContext db;

        public GiaoVien_BAL_DLL()
        {
            db = new DB_QLTracNghiemDataContext();
        }

        public IQueryable getGiaoVien()
        {
            return db.Table_GiaoViens.Select(n => n);
        }
        public IQueryable<Table_GiaoVien> layGiaovienDH()
        {
            return from gv in db.Table_GiaoViens where gv.ChucVu.Equals("Điều hành") select gv;
        }
        public IQueryable<Table_GiaoVien> layGiaovienQL()
        {
            return from gv in db.Table_GiaoViens where gv.ChucVu.Equals("Quản lý") select gv;
        }
        public IQueryable<Table_GiaoVien> layGiaovienThuong()
        {
            return from gv in db.Table_GiaoViens where gv.ChucVu.Equals("Giáo viên") select gv;
        }
        public Table_GiaoVien kiemTraTonTai(Table_GiaoVien gv)
        {
            return db.Table_GiaoViens.Where(d => d.MaGiaoVien == gv.MaGiaoVien).FirstOrDefault();
        }

        public int insertGV(Table_GiaoVien gv)
        {
            try
            {
                db.Table_GiaoViens.InsertOnSubmit(gv);
                db.SubmitChanges();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public int deleteGV(Table_GiaoVien gv)
        {
            try
            {
                Table_GiaoVien gv_canXoa = db.Table_GiaoViens.Where(d => d.MaGiaoVien == gv.MaGiaoVien).FirstOrDefault();
                if (gv != null)
                {
                    db.Table_GiaoViens.DeleteOnSubmit(gv_canXoa);
                    db.SubmitChanges();
                    return 1;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }
        //public int updateGV(Table_GiaoVien gv)
        //{
        //    try
        //    {
        //        db.SubmitChanges();
        //        return 1;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}
    }
}
