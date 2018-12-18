using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using System.Threading.Tasks;

namespace DAL
{
    public class ObjetRepository : Repository
    {
        public IList<Objet> GetAll()
        {
            Console.WriteLine(Session.Query<Objet>().ToList());
            Console.WriteLine(Session.Query<Objet>());
            Console.WriteLine(Session.ToString());
            return Session.Query<Objet>().ToList();
        }

        public void Save(Object objet)
        {
            Session.SaveOrUpdate(objet);
            Session.Flush();
        }
    }
}
