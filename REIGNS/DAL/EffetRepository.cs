using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class EffetRepository : Repository
    {
        public IList<Effet> GetAll()
        {
            return Session.Query<Effet>().ToList();
        }

        public void Save(Effet effet)
        {
            Session.SaveOrUpdate(effet);
            Session.Flush();
        }
    }
}
