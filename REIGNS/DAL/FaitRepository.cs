﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

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
