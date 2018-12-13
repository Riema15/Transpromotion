using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class EvenementRepository : Repository
    {
        public IList<Evenement> GetAll()
        {
            return Session.Query<Evenement>().ToList();
        }


        public void Save(Evenement evenement)
        {
            Session.SaveOrUpdate(evenement);
            Session.Flush();
        }

    }
}
