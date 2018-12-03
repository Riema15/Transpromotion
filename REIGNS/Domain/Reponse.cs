using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Reponse
    {
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }

        public virtual int EffetSante { get; set; }

        public virtual int EffetScolaire { get; set; }

        public virtual int EffetSous { get; set; }

        public virtual int EffetSocial { get; set; }

        public virtual int CarteSuivante { get; set; }

        public virtual string ChgtObjet { get; set; }
        public virtual string ChgtEffet { get; set; }

        public virtual int FaitId { get; set; }

        public virtual int MortId { get; set; }

        public Reponse() { }

    }
}