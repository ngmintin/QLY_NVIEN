using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDOs
    {
        Qly_NvienEntities1 db = new Qly_NvienEntities1();
        public List<TRINHDO> getList()
        {
            return db.TRINHDO.ToList();
        }
    }
}
