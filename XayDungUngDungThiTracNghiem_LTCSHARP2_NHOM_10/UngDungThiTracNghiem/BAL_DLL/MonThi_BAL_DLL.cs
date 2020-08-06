using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL_DLL
{
    public class MonThi_BAL_DLL
    {
        DB_QLTracNghiemDataContext db = new DB_QLTracNghiemDataContext();
        public MonThi_BAL_DLL() { }

        public IQueryable getMon()
        {
            return db.Table_MonThis.Select(t => t);
        }
    }
}
