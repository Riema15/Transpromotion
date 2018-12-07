using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class PersonnageRepository : Repository
    {
        public IList<Personnage> GetAll()
        {
            return Session.Query<Personnage>().ToList();
        }

        public void Save(Personnage perso)
        {
            Session.SaveOrUpdate(perso);
            Session.Flush();
        }
    }
}
