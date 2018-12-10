using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Carte
    {


        public virtual Personnage Personnage { get; set; }
     

        public virtual Reponse Rep1 { get; set; }

        public virtual Reponse Rep2 { get; set; }

        public virtual int Id { get; set; }

        public virtual string Text { get; set; }

        // objet possibles est un string de type"3,4" pour l'indiquer l'objet d'id 3 sur cette carte amène la carte 4
        public virtual string ObjetPossible { get; set; }
        
        public virtual int NumEvent { get; set; }

        public Carte() { }
    }
}