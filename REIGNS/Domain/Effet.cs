using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Effet
    {
        public virtual int EffetSante { get; set; }

        public virtual int EffetSocial { get; set; }

        public virtual int EffetScolaire { get; set; }

        public virtual int EffetSous { get; set; }

        public virtual int Id { get; set; }

        public virtual string Nom { get; set; }

        public virtual bool Actif { get; set; }

        public Effet() { }

    }
}