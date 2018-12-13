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

        public IList<Carte> GetCarteNotEvent()
        {
            IList<Carte> toutes = GetAll();
            return (IList<Carte>) ((List<Carte>)toutes).FindAll(x => x.Id == -1);
        }

        public IList<Carte> GetCartesSpeciales()
        {
            IList<Carte> toutes = GetAll();
            return (IList<Carte>)((List<Carte>)toutes).FindAll(x => x.Id == -100);
        }

        public void Save(Carte carte)
        {
            Session.SaveOrUpdate(carte);
            Session.Flush();
        }
    }
}
