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

        public void MajNbJour()
        {
            valNbJour.Text = Program.MaPartie.VieActuelle.NbJour.ToString();
        }

        // Fonctions utiles

        public void TestJaugeMort()
        {
            int idMort = Program.MaPartie.TestJaugeMort();
            if (idMort != -1)
            {
                AfficherCarte((((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == idMort)));
            }
        }

        public void Mourir()
        {
            //Réponse spécifique

            /*
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
            btnRetour.Click += new System.EventHandler(this.btnRetour_Click);

            this.Controls.Add(mortLabel);
            this.Controls.Add(btnRetour);
            */

            this.btnReponse1.Click -= new System.EventHandler(this.btnReponse1_Click);
            this.btnReponse1.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnReponse2.Click -= new System.EventHandler(this.btnReponse2_Click);
            this.btnReponse2.Click += new System.EventHandler(this.btnRetour_Click);

            //Garder certains objets et pas d'autre
            foreach (Objet ob in Program.MaPartie.Objets)
            {
                // RIEN A GARDER POUR L'INSTANT
                 ob.Actif = false; 
            }
            
        } 

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
            if (chgtObjetChar.Length > 1)
            {
                int idObjet = 0;

                // Nouvel Objet = "+id"
                if (chgtObjetChar[0] == '+')
                {
                    for (int i = 0; i < chgtObjetChar.Length; i++)
                    {
                        idObjet += ((int)chgtObjetChar[i + 1]) * ((int)Math.Pow(10, i));
                        i++;
                    }
                    Program.MaPartie.Objets[chgtObjetChar[idObjet]].Actif = true;
                    AfficherObjet(Program.MaPartie.Objets[chgtObjetChar[idObjet]]);
                }
                // Perdre un objet = "-id"
                if (chgtObjetChar[0] == '-')
                {
                    for (int i = 0; i < chgtObjetChar.Length; i++)
                    {
                        idObjet += ((int)chgtObjetChar[i + 1]) * ((int)Math.Pow(10, i));
                        i++;
                    }
                    Program.MaPartie.Objets[chgtObjetChar[idObjet]].Actif = false;
                    EffacerObjet(Program.MaPartie.Objets[chgtObjetChar[idObjet]]);
                }
            }
        }

        private void NouveauFait(Fait fait)
        {

            AfficherFait(fait);
            // Nouvelle famille
            if ((fait.Id == 1) || (fait.Id == 2) || (fait.Id == 3) || (fait.Id == 4) || (fait.Id == 5))
            {
                Program.MaPartie.NbmFamille++;
                //Si toute faite :
                if (Program.MaPartie.NbmFamille == 5)
                {
                    Fait fait2 = ((List<Fait>)Program.MaPartie.Faits).Find(x => x.Id == 6);
                    fait2.Actif = true;
                    AfficherFait(fait2);
                }
            }

            // Nouvelle asso
            if ((fait.Id == 7) || (fait.Id == 8) || (fait.Id == 9) || (fait.Id == 10))
            {
                Program.MaPartie.NbmAsso++;
                //Si toute faite :
                if (Program.MaPartie.NbmAsso == 4)
                {
                    Fait fait2 = ((List<Fait>)Program.MaPartie.Faits).Find(x => x.Id == 11);
                    fait2.Actif = true;
                    AfficherFait(fait2);
                }
            }
            fait.Actif = true;
        } // Modif fait id

        private Carte Vacances(int nbJourEnPlus) // REMP NUM CARTE VAC
        {
            Program.MaPartie.VieActuelle.NbJour += nbJourEnPlus;
            MajNbJour();
            //modif jauge
            if (Program.MaPartie.VieActuelle.JaugeSante>75) { Program.MaPartie.VieActuelle.JaugeSante -= 10; }
            else if (Program.MaPartie.VieActuelle.JaugeSante<25) { Program.MaPartie.VieActuelle.JaugeSante += 10; }
            if (Program.MaPartie.VieActuelle.JaugeScolaire >75) { Program.MaPartie.VieActuelle.JaugeScolaire -= 10; }
            else if (Program.MaPartie.VieActuelle.JaugeScolaire < 25) { Program.MaPartie.VieActuelle.JaugeScolaire += 10; }
            if (Program.MaPartie.VieActuelle.JaugeSous > 75) { Program.MaPartie.VieActuelle.JaugeSous -= 10; }
            else if (Program.MaPartie.VieActuelle.JaugeSous < 25) { Program.MaPartie.VieActuelle.JaugeSous += 10; }
            if (Program.MaPartie.VieActuelle.JaugeSocial > 75) { Program.MaPartie.VieActuelle.JaugeSocial -= 10; }
            else if (Program.MaPartie.VieActuelle.JaugeSocial < 25) { Program.MaPartie.VieActuelle.JaugeSocial += 10; }

            return Program.MaPartie.CartesSpeciales[0];  /// REMPLIR PAR LE NUM DE LA CARTE VAC
        }
        
        private void DeterminerCartesEvent(Evenement evenement)
        {
            // choisir X cartes DIFFERENTS parmi les cartes de cet event

            cartesEvent.Clear();
            List<Carte> listeCartesConcernees = new List<Carte>(evenement.CartesConcernees);
            int xRandom;
            for (int i =0; i< evenement.NbCarteTirer; i++)
            {
                xRandom = random.Next(listeCartesConcernees.Count);
                cartesEvent.Add(listeCartesConcernees[xRandom]);
                listeCartesConcernees.RemoveAt(xRandom);
            }
        }

        private Carte CarteParmiEvent()
        {
            if (cartesEvent.Count != 0)
            {
                int position = random.Next(cartesEvent.Count);
                Carte carte = cartesEvent[position];
                cartesEvent.RemoveAt(position);
                return carte;
            }
            return null;
        }

        private int UtiliserObjet(int idObjet)
        {
            // Recoit l'id d'un objet et renvoie un id de carte si l'objet est utilisable. Renvoie -1 sinon.
            if (idObjet != -1)
            {
                // récupérer tous les objets possibles dans un tableau de string
                string [] split = carteActuelle.ObjetPossible.Split(new char[] { '&' });
                //Pour chaque objet possible
                foreach (string objetPossibleString in split)
                {
                    char[] objetPossibleChar = objetPossibleString.ToCharArray();
                    if (objetPossibleChar[0]==idObjet)
                    {
                        // l'objet a une application sur cette carte !
                        int idCarte = 0;
                        for (int i=0; i<objetPossibleChar.Length; i++)
                        {
                            idCarte += ((int)objetPossibleChar[i + 1]) * ((int)Math.Pow(10, i));
                        }
                        return idCarte;
                    }
                }
            }
            return -1;
        }

        // Fonctions principales

        public void EffetReponse(Reponse rep)
        {
            EffacerFait();

            // Test de la mort (effet carte)
            if (rep.MortId != 0)
            {
                AfficherCarte(((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == rep.MortId));
                ((List<Mort>)Program.MaPartie.Morts).Find(x => x.Id == rep.MortId).Actif = true;
                Mourir();
                return;
            }

            // Test de Fait de cogniticien
            if (rep.FaitId != -1)
            {
                if (Program.MaPartie.Faits[rep.FaitId].Actif == false)
                {
                    NouveauFait(((List<Fait>)Program.MaPartie.Faits).Find(x => x.Id == rep.FaitId));
                }          
            }

            // Effet sur les jauges
            Program.MaPartie.VieActuelle.JaugeSante += rep.EffetSante;
            Program.MaPartie.VieActuelle.JaugeSous += rep.EffetSous;
            Program.MaPartie.VieActuelle.JaugeSocial += rep.EffetSocial;
            Program.MaPartie.VieActuelle.JaugeScolaire += rep.EffetScolaire;
            AfficherJauge();

            // Effet à modifier 
            //ATTENTION CE CODE NE FONCTIONNE QUE TANT QUIL NY A PAS DEFFET D'ID SUP A 9
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

            // Objet à modifier
            if (rep.ChgtObjet != "")
            // Nouveau = "+id", Perte = "-id", Evolution = "-id1+id2"
            {
                // Pour chaque objet
                string[] split = rep.ChgtObjet.Split(new char[] { '&' });
                foreach (string chgtObjetString in split)
                {
                    char[] chgtObjetChar = chgtObjetString.ToCharArray();
                    ChangerObjet(chgtObjetChar);
                }
            }

            // La carte suivant immédiatement
            if (rep.CarteSuivante != -1)
            {
                AfficherCarte(((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == rep.CarteSuivante));
                return;
            }

            // Test de mort (Jauge)
            TestJaugeMort();

            // Fin des effets actifs AU PIF
            foreach (Effet effet in Program.MaPartie.VieActuelle.Effets)
            {
                if (effet.Actif == true)
                {
                    if (random.Next(1, 5) == 1)
                    {
                        effet.Actif = false;
                        EffacerEffet(effet);
                    }
                }
            }

            // Les cartes qui suivront bientôt
            if (rep.CarteAVenir != 0)
            { carteAVenir.Add(((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == rep.CarteAVenir)); }

            // Modification d'un bool de Cycle
            if (rep.BoolCycle != "")
            {
                char[] charBoolCycle = rep.BoolCycle.ToCharArray();
                if (charBoolCycle[1] != '3')
                {
                    if (charBoolCycle[0] == '+')
                    {
                        Program.MaPartie.VieActuelle.MettreVraiBoolCycle((int)charBoolCycle[1]);
                    }
                    else { Program.MaPartie.VieActuelle.MettreFauxBoolCycle((int)charBoolCycle[1]); }
                }
                else // repas de famille
                {
                    // Il a refusé d'organiser
                    if (charBoolCycle[0] == '-')
                    {
                        Program.MaPartie.VieActuelle.NbRefusRepasFamille++;
                    }
                    if (Program.MaPartie.VieActuelle.NbRefusRepasFamille == 3)
                    {
                        carteAVenir.Remove(carteAVenir.Find(x => x.Id == 0));
                        carteAVenir.Add(((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == 0));
                    }
                    //Il a accepté d'organiser
                    if (charBoolCycle[0] == '+')
                    {
                        carteAVenir.Remove(carteAVenir.Find(x => x.Id == 0));
                        carteAVenir.Add(((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == 0));
                    }
                }
           }

            carteActuelle = ChoisirCarte();
        }

        public Carte ChoisirCarte()
        {
            // si scénraio en cours
            if (cartesEvent.Count != 0)
            {
                Carte carte = CarteParmiEvent();
                if (carte != null) { return carte; }
            }

            // si date spéciale : début évenement
            Evenement evenement = Program.MaPartie.TestDebutEvent();
            if (evenement != null)
            {
                //il s'agit de Vacances 
                if (evenement.Id > 100) { return Vacances(evenement.NbCarteTirer); }

                else
                {
                    if ((evenement.Id != 8) || (evenement.Id != 10)) // event pas fini encore
                    {
                        //il s'agit d'un event : on récupère un certain nombre de cartes de cet event
                        DeterminerCartesEvent(evenement);
                        return CarteParmiEvent();
                    }

                }
            }
            // else {

            // nombre de jour augmente de 1
            Program.MaPartie.VieActuelle.NbJour++;
            MajNbJour();

            // si carte à venir : 1 chance sur 3
            if ((carteAVenir.Count != 0) && (random.Next(101) > 66))
            {
                return carteAVenir[random.Next(carteAVenir.Count())];
            }

            // sinon aléatoire
            return Program.MaPartie.CartesNoEvent[random.Next(Program.MaPartie.CartesNoEvent.Count())];

            //}
        }

        public void EffetObjet(string txtBtn)
        {
            // Si un objet est rentré dans ce btn
            if (txtBtn != "")
            {
                // Récupérer l'id de l'objet
                int idObjet = -1;
                foreach (Objet objet in Program.MaPartie.Objets)
                {
                    if (txtBtn == objet.Nom) { idObjet = objet.Id; }
                }

                // récupérer l'id de la carte suivante si l'objet peut être utilisé
                int idCarte = UtiliserObjet(idObjet);
                // Si utilisable
                if (idCarte != -1)
                {
                    carteActuelle = ((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x =>x.Id == idCarte);
                    AfficherCarte(carteActuelle);
                }

            }
        }

        // Fonctions du form

        private void btnReponse1_Click(object sender, EventArgs e)
        {
            EffetReponse(carteActuelle.Rep1);
            AfficherCarte(carteActuelle);
        }

        private void btnReponse2_Click(object sender, EventArgs e)
        {
            // Effet de la réponse sur jauge, objet, etc + Nouvelle carte actuelle
            EffetReponse(carteActuelle.Rep2);
            // Afficher cette nouvelle carte
            AfficherCarte(carteActuelle);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            AfficherCarte(((List<Carte>)Program.MaPartie.CartesSpeciales).Find(x => x.Id == carteActuelle.Rep1.CarteSuivante));

            this.btnReponse1.Click -= new System.EventHandler(this.btnFin_Click);
            this.btnReponse1.Click += new System.EventHandler(this.btnRetour_Click);
            this.btnReponse2.Click -= new System.EventHandler(this.btnFin_Click);
            this.btnReponse2.Click += new System.EventHandler(this.btnRetour_Click);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil userControlAccueil = new Accueil();
            Controls.Add(userControlAccueil);
        }

        private void btnObjet0_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet0.Text);
        }

        private void btnObjet1_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet1.Text);
        }

        private void btnObjet2_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet2.Text);
        }

        private void btnObjet3_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet3.Text);
        }

        private void btnObjet4_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet4.Text);
        }

        private void btnObjet5_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet5.Text);
        }

        private void btnObjet6_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet6.Text);
        }

        private void btnObjet7_Click(object sender, EventArgs e)
        {
            EffetObjet(btnObjet7.Text);
        }

    }
}
