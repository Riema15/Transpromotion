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


        public Accueil()
        {
            InitializeComponent();
            valNbFait.Text = ""+((List<Fait>)Program.MaPartie.Faits).Count(x => x.Actif == true);
            valNbMort.Text = "" + ((List<Mort>)Program.MaPartie.Morts).Count(x => x.Actif == true);
            valNbVie.Text = "" + Program.MaPartie.NbVie;

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Program.MaPartie.NouveauCycle(Program.effetRep.GetAll());
            EcranPrincipal userControlEcranPrinp = new EcranPrincipal();
            ((Gestionnaire)this.Parent).ChangeControl(userControlEcranPrinp);
        }
        
    }
}
