using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Evenement
    {
        public virtual int Id { get; set; }

        public virtual int JourHappen { get; set; }

        public virtual int NbCarteTirer { get; set; }

        public virtual string Nom { get; set; }

        public virtual List<Carte> CartesConcernees { get; set; }

        public Evenement() { }



    }
}
