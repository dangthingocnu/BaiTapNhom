using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class ThiSinh_BAL_DLL
    {
        DB_QLTracNghiemDataContext db = new DB_QLTracNghiemDataContext();
        public ThiSinh_BAL_DLL() { }

        public IQueryable getThiSinh()
        {
            //return db.Table_ThiSinhs.Select(t => t);

            return from sp in db.Table_ThiSinhs
                   join l in db.Table_Nganhs
                   on sp.MaNganh equals l.MaNganh
                   select new
                   {
                       sp.MaThiSinh,
                       sp.HoTen,
                       sp.DiaChi,
                       sp.NgaySinh,
                       sp.Truong,
                      
                       sp.Lop,
                      
                   };
        }
    }
}
