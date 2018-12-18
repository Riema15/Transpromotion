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
        public IList<Evenement> GetAll(CarteRepository carteRep)
        {
            IList<Evenement> liste = Session.Query<Evenement>().ToList();
            
            foreach (Evenement ev in liste)
            {
                ev.CartesConcernees = ((List<Carte>)carteRep.GetAll()).FindAll(x => x.NumEvent == ev.Id);
                Console.WriteLine("nom;"+ev.Nom + " id:" + ev.Id+" nbCarte:"+ev.CartesConcernees.Count);
            }
            return Session.Query<Evenement>().ToList();
        }


        public void Save(Evenement evenement)
        {
            Session.SaveOrUpdate(evenement);
            Session.Flush();
        }

    }
}
