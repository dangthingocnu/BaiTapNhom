using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class LoaiCauHoi_BAL_DLL
    {
        DB_QLTracNghiemDataContext db = new DB_QLTracNghiemDataContext();
        public LoaiCauHoi_BAL_DLL() { }

        public IQueryable getLoai()
        {
            return db.Table_LoaiCauHois.Select(t => t);
        }
    }
}
