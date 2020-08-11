using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class Nguoidung_BAL_DLL
    {
        DB_QLTracNghiemDataContext db = new DB_QLTracNghiemDataContext();
        public Nguoidung_BAL_DLL() { }

        public IQueryable getMon()
        {
            return db.Table_NguoiDungs.Select(t => t);
        }
    }
}
