using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class CauHoi_BAL_DLL
    {
        private DB_QLTracNghiemDataContext db;

        public CauHoi_BAL_DLL()
        {
            db = new DB_QLTracNghiemDataContext();
        }

        public IQueryable layTatCauHoi()
        {
            return db.Table_CauHois.Select(n => n);
        }
        
        
    }
}
