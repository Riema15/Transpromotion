using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Cycle
    {
        public bool BadgeAbime { get; set; }
        public bool Ami { get; set; }
        public bool OrganiserRepasFamille { get; set; }
        public int NbRefusRepasFamille { get; set; }
        public int FormationJE { get; set; }


        public void MettreVraiBoolCycle(int numBoolEnQuestion)
        {
            if (numBoolEnQuestion==1) { BadgeAbime = true; }
            else if (numBoolEnQuestion == 2) { Ami = true; }
            else if (numBoolEnQuestion == 3) { OrganiserRepasFamille = true; } // ligne pas possible
            else if (numBoolEnQuestion == 4) { FormationJE++; }
        }

        public void MettreFauxBoolCycle(int numBoolEnQuestion)
        {
            if (numBoolEnQuestion == 1) { BadgeAbime = false; }
            else if (numBoolEnQuestion == 2) { Ami = false; }
            else if (numBoolEnQuestion == 3) { OrganiserRepasFamille = false; }
        }

        private List<string> listeNom = new List<string> { "Mathieu", "Pierre", "Tim", "Félix" };

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
            NbJour = -1;
            Nom = listeNom[alea.Next(0, listeNom.Count())];
            BadgeAbime = false;
            FormationJE = 0;
            Ami = false;
            OrganiserRepasFamille = true;
            Effets = new List<Effet>();
        }

        
    }
}