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
        private Random random = new Random();
        private List<Button> listeBtnObjet;
        private List<Carte> cartesEvent;
  
        public EcranPrincipal()
        {
            InitializeComponent();
            listeBtnObjet = new List<Button> { btnObjet0, btnObjet1, btnObjet2, btnObjet3, btnObjet4, btnObjet5, btnObjet6, btnObjet7 };
            carteAVenir = new List<Carte>();
            txtNbJour.Text = 0.ToString();
            txtNomCycle.Text = Program.MaPartie.VieActuelle.Nom;
            cartesEvent = new List<Carte>();

            carteActuelle = ChoisirCarte();

            AfficherCarte(carteActuelle);
            AfficherJauge();
         
        } 

        // Methodes d'affichage

        public void AfficherCarte(Carte carte)
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
            txtNouveauFait.Text = "Nouveau fait : "+ fait.Nom;
        }

        public void EffacerFait()
        {
            txtNouveauFait.Text = "";
        }

        public void AfficherEffet(Effet effet)
        {
            if (effet.EffetSante > 0) imPlusSante.Visible = true;
            else if (effet.EffetSante < 0) imMoinsSante.Visible = true;

            if (effet.EffetSocial > 0) imPlusSocial.Visible = true;
            else if (effet.EffetSocial < 0) imMoinsSocial.Visible = true;

            if (effet.EffetSous > 0) imPlusSous.Visible = true;
            else if (effet.EffetSous < 0) imMoinsSous.Visible = true;

            if (effet.EffetScolaire > 0) imPlusScolaire.Visible = true;
            else if (effet.EffetScolaire < 0) imMoinsScolaire.Visible = true;

        }

        public void EffacerEffet(Effet effet)
        {
            imPlusSante.Visible = false;
            imMoinsSante.Visible = false;
            imPlusSous.Visible = false;
            imMoinsSous.Visible = false;
            imPlusScolaire.Visible = false;
            imMoinsScolaire.Visible = false;
            imPlusSocial.Visible = false;
            imMoinsSocial.Visible = false;

            foreach (Effet effet2 in Program.MaPartie.VieActuelle.Effets)
            {
                if (effet2.Actif == true)
                {
                    AfficherEffet(effet2);
                }
            }
        }

        public void AfficherObjet(Objet objet)
        {
            int i = 0;
            while (listeBtnObjet[i].Text != "") { i++; }
            listeBtnObjet[i].Text = objet.Nom;
        }

        public void EffacerObjet(Objet objet)
        {
            int i = 0;
            while (listeBtnObjet[i].Text != objet.Nom) { i++; }
            listeBtnObjet[i].Text = "";
        }

        // Fonctions utiles

        public void TestJaugeMort()/// A MODIF LA CARTE A AFFICHER
        {
            int x = Program.MaPartie.TestJaugeMort();
            if (x != -1)
            {
                AfficherCarte((Program.MaPartie.CartesSpeciales[x]));
                Mourir();
            }
        }

        public void Mourir()
        {
            //Réponse spécifique

            GroupBox mortLabel = new GroupBox();
            mortLabel.AutoSize = true;
            mortLabel.Location = new System.Drawing.Point(40, 216);
            mortLabel.Name = "txtMort";
            mortLabel.Size = new System.Drawing.Size(624, 95);
            mortLabel.Text = "VOUS ETES MORT";
            Button btnRetour = new Button();
            btnRetour.Text = "Revenir à l'accueil.";
            btnRetour.AutoSize = true;
            btnRetour.Location = new System.Drawing.Point(60, 226);
            btnRetour.Size = new System.Drawing.Size(30, 30);
            btnRetour.Name = "btnRetour";
            this.Controls.Add(mortLabel);
            this.Controls.Add(btnRetour);


            //Garder certains objets et pas d'autre
            foreach (Objet ob in Program.MaPartie.Objets)
            {
                if (ob.Id == 2) ob.Actif = false; // A VOI QUELS SONT LES ID D'OBJETS CONCERNES

            }

        } // Modif id objet a retirer

        public void AppliquerEffet()
        {
            foreach (Effet effet in Program.MaPartie.VieActuelle.Effets)
            {
                if (effet.Actif == true)
                {
                    Program.MaPartie.VieActuelle.JaugeSante += effet.EffetSante;
                    Program.MaPartie.VieActuelle.JaugeSous += effet.EffetSous;
                    Program.MaPartie.VieActuelle.JaugeSocial += effet.EffetSocial;
                    Program.MaPartie.VieActuelle.JaugeScolaire += effet.EffetScolaire;
                }
            }
            AfficherJauge();
        }      

        private void ChangerObjet(char[] chgtObjetChar)
        {
            // Nouvel Objet = "+id"
            if (chgtObjetChar[0] == '+')
            {
                Program.MaPartie.Objets[chgtObjetChar[1]].Actif = true;
                AfficherObjet(Program.MaPartie.Objets[chgtObjetChar[1]]);
            }
            // Perdre un objet = "-id"
            if (chgtObjetChar[0] == '-')
            {
                Program.MaPartie.Objets[chgtObjetChar[1]].Actif = false;
                EffacerObjet(Program.MaPartie.Objets[chgtObjetChar[1]]);
            }
        }

        private void NouveauFait(Fait fait)
        {

            AfficherFait(fait);
            // Nouvelle famille
            if ((fait.Id == 0) || (fait.Id == 0) || (fait.Id == 0) || (fait.Id == 0))
            {
                Program.MaPartie.NbmFamille++;
                //Si toute faite :
                if (Program.MaPartie.NbmFamille == 4)
                {
                    Program.MaPartie.Faits[0].Actif = true;
                    AfficherFait(Program.MaPartie.Faits[0]);
                }
            }

            // Nouvelle asso
            if ((fait.Id == 0) || (fait.Id == 0) || (fait.Id == 0) || (fait.Id == 0))
            {
                Program.MaPartie.NbmAsso++;
                //Si toute faite :
                if (Program.MaPartie.NbmAsso == 5)
                {
                    Program.MaPartie.Faits[0].Actif = true;
                    AfficherFait(Program.MaPartie.Faits[0]);
                }
            }
            fait.Actif = true;
        } // Modif fait id

        private void Vacances(int nbJourEnPlus) // REMP NUM CARTE VAC
        {
            Program.MaPartie.VieActuelle.NbJour += nbJourEnPlus;
            AfficherCarte(Program.MaPartie.CartesSpeciales[0]);  /// REMPLIR PAR LE NUM DE LA CARTE VAC
        }

        private List<Carte> DeterminerCartesEvent(Evenement evenement)
        {
            // choisir X cartes DIFFERENTS parmi les cartes de cet event
        }

        private Carte CarteParmiEvent()
        {

        }

        // Fonctions principales

        public void EffetReponse(Reponse rep)
        {
            EffacerFait();

            // Test de la mort (effet carte)
            if (rep.MortId != 0)
            {
                AfficherCarte(Program.MaPartie.CartesSpeciales[rep.MortId]);
                Program.MaPartie.Morts[rep.MortId].Actif = true;
                Mourir();
                return;
            }

            // Test de Fait de cogniticien
            if (rep.FaitId != -1)
            {
                if (Program.MaPartie.Faits[rep.FaitId].Actif == false)
                {
                    NouveauFait(Program.MaPartie.Faits[rep.FaitId]);
                }          
            }

            // Effet sur les jauges
            Program.MaPartie.VieActuelle.JaugeSante += rep.EffetSante;
            Program.MaPartie.VieActuelle.JaugeSous += rep.EffetSous;
            Program.MaPartie.VieActuelle.JaugeSocial += rep.EffetSocial;
            Program.MaPartie.VieActuelle.JaugeScolaire += rep.EffetScolaire;
            AfficherJauge();

            // Objet et Effet à modifier
            if (rep.ChgtEffet != "")
            {
                char[] chgtEffetChar = rep.ChgtEffet.ToCharArray();
                if (chgtEffetChar[0] == '+')
                {
                    Program.MaPartie.VieActuelle.Effets[chgtEffetChar[1]].Actif = true;
                    AfficherEffet(Program.MaPartie.VieActuelle.Effets[chgtEffetChar[1]]);
                }
                if (chgtEffetChar[0] == '-')
                {
                    Program.MaPartie.VieActuelle.Effets[chgtEffetChar[1]].Actif = false;
                    EffacerEffet(Program.MaPartie.VieActuelle.Effets[chgtEffetChar[1]]);
                }

            }
            if (rep.ChgtObjet != "")
            // Nouveau = "+id", Perte = "-id", Evolution = "-id1+id2"
            {
                char[] chgtObjetChar = rep.ChgtObjet.ToCharArray();
                bool suite = false;
                while (suite == false)
                {
                    ChangerObjet(chgtObjetChar);
                    if (chgtObjetChar.Length > 2) { chgtObjetChar.CopyTo(chgtObjetChar, 2); }
                    else { suite = true; }
                }
            }

            // La carte suivant immédiatement
            if (rep.CarteSuivante != -1)
            {
                AfficherCarte(Program.MaPartie.CartesSpeciales[rep.CarteSuivante]);
                return;
            }

            // Test de mort (Jauge)
            TestJaugeMort();

            // Fin des effets actifs
            foreach (Effet effet in Program.MaPartie.VieActuelle.Effets)
            {
                if (effet.Actif == true)
                {
                    if (random.Next(1, 4) == 1)
                    {
                        effet.Actif = false;
                        EffacerEffet(effet);
                    }
                }
            }

            // Les cartes qui suivront bientôt
            carteAVenir.Add(Program.MaPartie.CartesSpeciales[rep.CarteAVenir]);

            // Modification d'un bool de Cycle
            if (rep.BoolCycle != "")
            {
                char[] charBoolCycle = rep.BoolCycle.ToCharArray();
                if (charBoolCycle[0] == '+') { Program.MaPartie.VieActuelle.MettreVraiBoolCycle((int)charBoolCycle[1]); }
                else { Program.MaPartie.VieActuelle.MettreFauxBoolCycle((int)charBoolCycle[1]); }
            }

            carteActuelle = ChoisirCarte();
        }

        public Carte ChosirCarte()
        {
            if (cartesEvent.Count != 0)
            {

            }
            // nombre de jour augmente de 1(sauf scenario)
            // si scénraio en cours
            

            // si date spéciale : début évenement
            int numEvent = Program.MaPartie.TestDebutEvent();
            if (numEvent != -1)
            {
                //il s'agit de Vacances
                if (numEvent > 100) { Vacances(numEvent - 100); }

                //il s'agit d'un event : on récupère un certain nombre de cartes de cet event
                cartesEvent = DeterminerCartesEvent(Program.MaPartie.Events[numEvent]);

            }
            else
            {
                // si carte à venir : 1 chance sur 3
                if ((carteAVenir.Count != 0) && (random.Next(101) > 66))
                {
                    return carteAVenir[random.Next(carteAVenir.Count())];
                }

                // sinon aléatoire
                return Program.MaPartie.CartesNoEvent[random.Next(Program.MaPartie.CartesNoEvent.Count())];
            }
        }

        // Fonctions du form

        private void btnReponse1_Click(object sender, EventArgs e)
        {
            EffetReponse(carteActuelle.Rep1);
        }

        private void btnReponse2_Click(object sender, EventArgs e)
        {
            EffetReponse(carteActuelle.Rep2);
        }

        private void btnRetour_Clicl(object sender, EventArgs e)
        {
            Accueil userControlAccueil = new Accueil();
            Controls.Add(userControlAccueil);
        }

    }
}
