﻿using System;
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
        public int NbmFamille { get { return nbmFamille; } set { nbmFamille = value; } }

        public int NbVie { get; set; }

        public IList<Domain.Fait> Faits { get; set; }

        public IList<Domain.Mort> Morts { get; set; }

        public Cycle VieActuelle { get; set; }

        public IList<Domain.Objet> Objets { get; set; }

        public IList<Domain.Evenement> Events { get; set; }

        public IList<Domain.Carte> CartesNoEvent { get; set; }

        public IList<Domain.Carte> CartesSpeciales { get; set; }

        public Partie()
        {
            NbmAsso = 0;
            NbmFamille = 0;
            NbVie = 0;
            Faits = new List<Fait>();
            Morts = new List<Mort>();
            VieActuelle = new Cycle();
            Objets = new List<Objet>();
            Events = new List<Evenement>();
            CartesNoEvent = new List<Carte>();
            CartesSpeciales = new List<Carte>();
        }
        

        public void NouveauCycle(IList<Effet> effets)
        {
            VieActuelle = new Cycle();
            NbVie++;
            VieActuelle.Effets = effets;
        }

        // Selon le jour qu'on est, renvoie -1 (rien de spécial) ou un chiffre entre 0 et 12 (semestre 1 seulement) pour un event, et 100+nb Jours passés pour les vacances
        public Evenement TestDebutEvent()
        {
            int nbJour = this.VieActuelle.NbJour;

            foreach (Evenement evenement in Events)
            {
                if (nbJour == evenement.JourHappen) { return evenement; }
            }
            return null;
        }

        // Renvoie -1 si pas mort, sinon le num de la carte spé de la mort
        public int TestJaugeMort()
        {
            int san = this.VieActuelle.JaugeSante;
            int sco = this.VieActuelle.JaugeScolaire;
            int sou = this.VieActuelle.JaugeSous;
            int soc = this.VieActuelle.JaugeSocial;
            if (san <= 0) return 388;
            else if (san >= 100) return 390;
            else if (sco <= 0) return 380;
            else if (sco >= 100) return 382;
            else if (sou <= 0) return 392;
            else if (sou >= 100) return 394;
            else if (soc <= 0) return 384;
            else if (soc >= 100) return 386;

            return -1;
        }

    }
}