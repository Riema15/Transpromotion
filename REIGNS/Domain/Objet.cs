using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Objet 
    {
        public virtual string Image { get; set; }

        public virtual bool Actif { get; set; }

        public virtual string Nom { get; set; }

        public virtual int Id { get; set; }

        public Objet() { }
    }
}