using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    class CarteRepository : Repository
    {
        public IList<Carte> GetAll()
        {
            return Session.Query<Carte>().ToList();
        }

        public void Save(Carte carte)
        {
            Session.SaveOrUpdate(carte);
            Session.Flush();
        }
    }
}
