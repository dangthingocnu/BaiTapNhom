using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class KetQua_BAL_DLL
    {
        private DB_QLTracNghiemDataContext db;

        public KetQua_BAL_DLL()
        {
            db = new DB_QLTracNghiemDataContext();
        }

        public IQueryable getKetQua()
        {
            return from kq in db.Table_KetQuas
                   join ts in db.Table_ThiSinhs on kq.MaThiSinh equals ts.MaThiSinh
                   join mt in db.Table_MonThis on kq.MaMon equals mt.MaMon
                  
                   select
                       new { ts.MaThiSinh, ts.HoTen, ts.Lop, ts.NgaySinh, ts.Truong, kq.Diem, mt.TenMon, kq.NgayThi }; 
        }
        public IQueryable layKQDat()
        {
            return from kq in db.Table_KetQuas
                   join ts in db.Table_ThiSinhs on kq.MaThiSinh equals ts.MaThiSinh 
                   join mt in db.Table_MonThis on kq.MaMon equals mt.MaMon
                   where kq.Diem >= 5
                   select
                       new { ts.MaThiSinh, ts.HoTen, ts.Lop, ts.NgaySinh, ts.Truong,kq.Diem, mt.TenMon, kq.NgayThi }; 
                       
        }
        public IQueryable layKQTruot()
        {
            return from kq in db.Table_KetQuas
                   join ts in db.Table_ThiSinhs on kq.MaThiSinh equals ts.MaThiSinh
                   join mt in db.Table_MonThis on kq.MaMon equals mt.MaMon
                   where kq.Diem < 5
                   select
                       new { ts.MaThiSinh, ts.HoTen, ts.Lop, ts.NgaySinh, ts.Truong, kq.Diem, mt.TenMon, kq.NgayThi };

        }
       
    }
}
