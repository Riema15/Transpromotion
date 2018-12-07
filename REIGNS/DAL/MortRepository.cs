using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using System.Threading.Tasks;

namespace DAL
{
    public class MortRepository : Repository
    {
        public IList<Mort> GetAll()
        {
            return Session.Query<Mort>().ToList();
        }

        public void Save(Mort mort)
        {
            Session.SaveOrUpdate(mort);
            Session.Flush();
        }
    }
}
