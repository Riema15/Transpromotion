using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Personnage
    {
        public virtual int Id { get; set; }

        public virtual string NomPerso { get; set; }

        public virtual string Image { get; set; }

        public virtual string Couleur { get; set; }

        public virtual int Annee { get; set; }

        public virtual string Bureau { get; set; }

        public virtual bool EtreParrain { get; set; }
        public Personnage() { }

    }
}