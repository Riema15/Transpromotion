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
    public partial class EcranPrincipal : UserControl
    {
        private Carte carteActuelle;
        private List<Carte> carteAVenir;
  
        public EcranPrincipal()
        {
            InitializeComponent();
            carteAVenir = new List<Carte>();
            txtNbJour.Text = 0.ToString();
            txtNomCycle.Text = Program.MaPartie.VieActuelle.Nom;

            //carteActuelle = ChoisirCarte();

            AfficherCarte(carteActuelle);
            AfficherJauge();
         
        }


        public void  AfficherCarte(Carte carte)
        {
            //Afficher les informatiosn propres à la carte
            txtNomPerso.Text = carte.Personnage.NomPerso;
            txtCarteContenu.Text = carte.Text;

            //Afficher les réponses possibles    
            btnReponse1.Text = carte.Rep1.Text;
            btnReponse2.Text = carte.Rep2.Text;
        }

        public void AfficherJauge()
        {
            valSante.Text = Program.MaPartie.VieActuelle.JaugeSante.ToString();
            valScolaire.Text = Program.MaPartie.VieActuelle.JaugeScolaire.ToString();
            valSous.Text = Program.MaPartie.VieActuelle.JaugeSous.ToString();
            valSocial.Text = Program.MaPartie.VieActuelle.JaugeSocial.ToString();

        }

        public void AfficherFait(Fait fait)
        {
            //afficher nom + desc
        }

        public void TestJaugeMort()
        {
            int san = Program.MaPartie.VieActuelle.JaugeSante;
            int sco = Program.MaPartie.VieActuelle.JaugeScolaire;
            int sou = Program.MaPartie.VieActuelle.JaugeSous;
            int soc = Program.MaPartie.VieActuelle.JaugeSocial;
            if ((san<=0)&&(san>=100)) 
            {
                AfficherCarte((Program.MaPartie.CartesSpeciales[0]));
                Mourir();
            }
            if ((sco <= 0) && (sco >= 100))
            {
                AfficherCarte((Program.MaPartie.CartesSpeciales[1]));
                Mourir();
            }
            if ((sou <= 0) && (sou >= 100))
            {
                AfficherCarte((Program.MaPartie.CartesSpeciales[2]));
                Mourir();
            }
            if ((soc <= 0) && (soc >= 100))
            {
                AfficherCarte((Program.MaPartie.CartesSpeciales[3]));
                Mourir();
            }
        }
        public void Mourir()
        {
            //Réponse spécifique

            //Garder certains objets et pas d'autre

            //Puis revenir écran 
        }

        public void EffetReponse(Reponse rep)
        {
            // Test de la mort (effet carte)
            if (rep.MortId!=0)
            {
                AfficherCarte(Program.MaPartie.CartesSpeciales[rep.MortId]);
                Program.MaPartie.Morts[rep.MortId].Actif = true;
                Mourir();
                return;
            }

            // Test de Fait de cogniticien
            if (rep.FaitId!=-1)
            {
                AfficherFait(Program.MaPartie.Faits[rep.FaitId]);
                Program.MaPartie.Faits[rep.FaitId].Actif = true;
            }

            // Effet sur les jauges
            Program.MaPartie.VieActuelle.JaugeSante += rep.EffetSante;
            Program.MaPartie.VieActuelle.JaugeSous += rep.EffetSous;
            Program.MaPartie.VieActuelle.JaugeSocial += rep.EffetSocial;
            Program.MaPartie.VieActuelle.JaugeScolaire += rep.EffetScolaire;
            AfficherJauge();

            // Objet et Effet à modifier
            if (rep.ChgtEffet!="")
            {

            }
            if (rep.ChgtObjet != "")
            {

            }


             // La carte suivant immédiatement
            if (rep.CarteSuivante!=-1)
            {
                AfficherCarte(Program.MaPartie.CartesSpeciales[rep.CarteSuivante]);
                return;
            }

            // Test de mort (Jauge)
            TestJaugeMort();

            // Les cartes qui suivront bientôt
            carteAVenir.Add(Program.MaPartie.CartesSpeciales[rep.CarteAVenir]);
        }

        public void AppliquerEffet()
        {

        }
        //public Carte ChosirCarte()
        //{

        // nombre de jour augmente de 1 (sauf scenario)
        // si scénraio en cours (utiliser lindice de l'event)
        //si date spéciale
        // si carte à venir
        //sinon aléatoire

        //}
    }
}
