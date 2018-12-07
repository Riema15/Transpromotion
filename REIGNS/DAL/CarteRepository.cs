using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class CarteRepository : Repository
    {
        public IList<Carte> GetAll()
        {
            return Session.Query<Carte>().ToList();
        }

        public IList<Carte> GetCarteEvent()
        {
            return Session.Query<Carte>().ToList();
        }

        public IList<Carte> GetCarteNotEvent()
        {
            return Session.Query<Carte>().ToList();
        }

        public IList<Carte> GetCartesSpeciales()
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
