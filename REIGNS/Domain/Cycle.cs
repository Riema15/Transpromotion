using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Cycle
    {
        private bool badgeAbime;
        private bool Ami;
        private int refusRepasFamille;
        private int formationJE;

        private List<string> listeNom = new List<string> { "Mathieu", "Pierre", "Tim" };

        private Random alea = new Random();

        public int JaugeSante { get; set; }

        public int JaugeScolaire { get; set; }

        public int JaugeSocial { get; set; }

        public int JaugeSous { get; set; }

        public int NbJour { get; set; }

        public string Nom { get; set; }



        public IList<Domain.Effet> Effets { get; set; }

        public Cycle()
        {
            JaugeSante = 50;
            JaugeScolaire = 50;
            JaugeSocial = 50;
            JaugeSous = 50;
            NbJour = 0;
            Nom = listeNom[alea.Next(0, listeNom.Count())];
            badgeAbime = false;
            formationJE = 0;
            Ami = false;
            refusRepasFamille = 0;
            Effets = new List<Effet>();
        }

    }
}