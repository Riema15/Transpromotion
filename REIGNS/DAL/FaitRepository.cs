using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using System.Threading.Tasks;

namespace DAL
{
    public class FaitRepository : Repository
    {
        public IList<Fait> GetAll()
        {            
            return Session.Query<Fait>().ToList();
        }

        public void Save(Fait fait)
        {
            Session.SaveOrUpdate(fait);
            Session.Flush();
        }
    }
}
