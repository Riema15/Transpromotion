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

        public int JaugeSante { get; set; }

        public int JaugeScolaire { get; set; }

        public int JaugeSocial { get; set; }

        public int JaugeSous { get; set; }

        public int NbJour { get; set; }

        public string Nom { get; set; }

        public IList<Domain.Carte> CartesScenario { get; set; }

    }
}