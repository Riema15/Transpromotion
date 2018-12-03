using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Partie
    {
        private int nbmAsso;
        private int nbmFamille;
        public int NbmAsso { get { return nbmAsso; } set { nbmAsso = value; } }
        public int NbmFamille
        {
            get { return nbmFamille; }
            set { nbmFamille = value; }
        }

        public IList<Domain.Fait> Faits { get; set; }

        public IList<Domain.Mort> Morts { get; set; }

        public Cycle VieActuelle { get; set; }

        public IList<Domain.Carte> Cartes { get; set; }

        public IList<Domain.Objet> Objets { get; set; }

        public IList<Domain.Effet> Effets { get; set; }

        public Partie()
        {
            NbmAsso = 0;
            NbmFamille = 0;
            Faits = new List<Fait>();
            Morts = new List<Mort>();
            VieActuelle = new Cycle();
            Objets = new List<Objet>();
            Effets = new List<Effet>();
            Cartes = new List<Carte>();
        }
        

    }
}