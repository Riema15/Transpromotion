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

        public IList<Domain.Objet> Objets { get; set; }

        public IList<Domain.Carte> CartesEvent { get; set; }

        public IList<Domain.Carte> CartesNoEvent { get; set; }

        public IList<Domain.Carte> CartesSpeciales { get; set; }

        public Partie()
        {
            NbmAsso = 0;
            NbmFamille = 0;
            Faits = new List<Fait>();
            Morts = new List<Mort>();
            VieActuelle = new Cycle();
            Objets = new List<Objet>();

            CartesEvent = new List<Carte>();
            CartesNoEvent = new List<Carte>();
            CartesSpeciales = new List<Carte>();
        }
        
        // Selon le jour qu'on est, renvoie -1 (rien de spécial) ou un chiffre entre 0 et 12 (semestre 1 seulement) pour un event, et 100+nb Jours passés pour les vacances
        public int TestDebutEvent()
        {
            int nbJour = this.VieActuelle.NbJour;

            // Arrivée à l'école
            if (nbJour == 0) { return 4; }
            // début transpromo transdi
            else if (nbJour == 2) { return 4; }
            // Soirée parrainnage
            else if (nbJour == 10) { return 4; }
            // WEI
            else if (nbJour == 25) { return 4; }
            // Repas de famille
            else if (nbJour == 35) // différent selon refus ou non
            {
                if (VieActuelle.OrganiserRepasFamille == true) { return 4; } // a déjà dit oui
                else { return 4; } // a refusé
            }
            //Vacances de toussaint
            else if (nbJour == 47) { return 101; }
            // Repas des régions
            else if (nbJour == 56) { return 4; }
            // Interpromo
            else if (nbJour == 65) { return 4; }
            // Gala
            else if (nbJour == 75) { return 4; }
            // Rallye des apparts
            else if (nbJour == 85) { return 4; }
            // Secret Santa
            else if (nbJour == 95) { return 4; }
            //Vacances de noël
            else if (nbJour == 105) { return 4; }
            // Transpromo soutenance
            else if (nbJour == 125) { return 4; }
            // Exam S1
            else if (nbJour == 135) { return 4; }


            return -1;
        }

        // Renvoie -1 si pas mort, sinon le num de la carte spé de la mort
        public int TestJaugeMort()
        {
            int san = this.VieActuelle.JaugeSante;
            int sco = this.VieActuelle.JaugeScolaire;
            int sou = this.VieActuelle.JaugeSous;
            int soc = this.VieActuelle.JaugeSocial;
            if ((san <= 0) && (san >= 100))
            {
                return 0;
            }
            if ((sco <= 0) && (sco >= 100))
            {
                return 0;
            }
            if ((sou <= 0) && (sou >= 100))
            {
                return 0;
            }
            if ((soc <= 0) && (soc >= 100))
            {
                return 0;
            }

            return -1;
        }

    }
}