using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class Accueil : UserControl
    {
        Random random = new Random();

        public Accueil()
        {

            InitializeComponent();
            valNbFait.Text = ""+((List<Fait>)Program.MaPartie.Faits).Count(x => x.Actif == true);
            valNbMort.Text = "" + ((List<Mort>)Program.MaPartie.Morts).Count(x => x.Actif == true);
            valNbVie.Text = "" + Program.MaPartie.NbVie;

            List<Fait> liste = ((List<Fait>)Program.MaPartie.Faits).FindAll(x => x.Actif == false);

            if (liste.Count > 1)
            {
                Fait fait = liste[random.Next(liste.Count - 1)];
                txtDefi.Text += fait.Nom + " : " + fait.Description;
            }
            else { txtDefi.Text = ""; }

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Program.MaPartie.NouveauCycle(Program.effetRep.GetAll());
            EcranPrincipal userControlEcranPrinp = new EcranPrincipal();
            ((Gestionnaire)this.Parent).ChangeControl(userControlEcranPrinp);
        }

        private void txtAccueil_Click(object sender, EventArgs e)
        {

        }
    }
}
