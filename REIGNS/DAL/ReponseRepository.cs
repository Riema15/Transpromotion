using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class ReponseRepository : Repository
    {
        public IList<Reponse> GetAll()
        {
            return Session.Query<Reponse>().ToList();
        }

        public void Save(Reponse reponse)
        {
            Session.SaveOrUpdate(reponse);
            Session.Flush();
        }
    }
}
