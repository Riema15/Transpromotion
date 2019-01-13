namespace App
{
    partial class Accueil
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnJouer = new System.Windows.Forms.Button();
            this.txtAccueil = new System.Windows.Forms.Label();
            this.txtNomsGroupe = new System.Windows.Forms.Label();
            this.txtNbVie = new System.Windows.Forms.Label();
            this.txtNbMort = new System.Windows.Forms.Label();
            this.txtNbFait = new System.Windows.Forms.Label();
            this.valNbVie = new System.Windows.Forms.Label();
            this.valNbFait = new System.Windows.Forms.Label();
            this.valNbMort = new System.Windows.Forms.Label();
            this.txtSousTitre = new System.Windows.Forms.Label();
            this.txtDefi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJouer
            // 
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(293, 138);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(116, 49);
            this.btnJouer.TabIndex = 0;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = true;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // txtAccueil
            // 
            this.txtAccueil.AutoSize = true;
            this.txtAccueil.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccueil.Location = new System.Drawing.Point(169, 27);
            this.txtAccueil.Name = "txtAccueil";
            this.txtAccueil.Size = new System.Drawing.Size(353, 97);
            this.txtAccueil.TabIndex = 1;
            this.txtAccueil.Text = "Graduated";
            this.txtAccueil.Click += new System.EventHandler(this.txtAccueil_Click);
            // 
            // txtNomsGroupe
            // 
            this.txtNomsGroupe.AutoSize = true;
            this.txtNomsGroupe.Location = new System.Drawing.Point(223, 438);
            this.txtNomsGroupe.Name = "txtNomsGroupe";
            this.txtNomsGroupe.Size = new System.Drawing.Size(485, 17);
            this.txtNomsGroupe.TabIndex = 2;
            this.txtNomsGroupe.Text = "Créé par M.Gibert, M.Leleu, S.Rouveure, L.Vannel, A.De Barros, J.Vauchez";
            // 
            // txtNbVie
            // 
            this.txtNbVie.AutoSize = true;
            this.txtNbVie.Location = new System.Drawing.Point(136, 250);
            this.txtNbVie.Name = "txtNbVie";
            this.txtNbVie.Size = new System.Drawing.Size(165, 17);
            this.txtNbVie.TabIndex = 3;
            this.txtNbVie.Text = "Nombre de vies jouées : ";
            // 
            // txtNbMort
            // 
            this.txtNbMort.AutoSize = true;
            this.txtNbMort.Location = new System.Drawing.Point(136, 290);
            this.txtNbMort.Name = "txtNbMort";
            this.txtNbMort.Size = new System.Drawing.Size(207, 17);
            this.txtNbMort.TabIndex = 4;
            this.txtNbMort.Text = "Nombre de morts découvertes :";
            // 
            // txtNbFait
            // 
            this.txtNbFait.AutoSize = true;
            this.txtNbFait.Location = new System.Drawing.Point(136, 270);
            this.txtNbFait.Name = "txtNbFait";
            this.txtNbFait.Size = new System.Drawing.Size(256, 17);
            this.txtNbFait.TabIndex = 5;
            this.txtNbFait.Text = "Nombre de faits de cogniticien réussis :";
            // 
            // valNbVie
            // 
            this.valNbVie.AutoSize = true;
            this.valNbVie.Location = new System.Drawing.Point(307, 250);
            this.valNbVie.Name = "valNbVie";
            this.valNbVie.Size = new System.Drawing.Size(16, 17);
            this.valNbVie.TabIndex = 6;
            this.valNbVie.Text = "0";
            // 
            // valNbFait
            // 
            this.valNbFait.AutoSize = true;
            this.valNbFait.Location = new System.Drawing.Point(398, 270);
            this.valNbFait.Name = "valNbFait";
            this.valNbFait.Size = new System.Drawing.Size(16, 17);
            this.valNbFait.TabIndex = 7;
            this.valNbFait.Text = "0";
            // 
            // valNbMort
            // 
            this.valNbMort.AutoSize = true;
            this.valNbMort.Location = new System.Drawing.Point(349, 290);
            this.valNbMort.Name = "valNbMort";
            this.valNbMort.Size = new System.Drawing.Size(16, 17);
            this.valNbMort.TabIndex = 8;
            this.valNbMort.Text = "0";
            // 
            // txtSousTitre
            // 
            this.txtSousTitre.AutoSize = true;
            this.txtSousTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSousTitre.Location = new System.Drawing.Point(257, 205);
            this.txtSousTitre.Name = "txtSousTitre";
            this.txtSousTitre.Size = new System.Drawing.Size(192, 24);
            this.txtSousTitre.TabIndex = 9;
            this.txtSousTitre.Text = "Reigns version ENSC";
            // 
            // txtDefi
            // 
            this.txtDefi.AutoSize = true;
            this.txtDefi.Location = new System.Drawing.Point(139, 348);
            this.txtDefi.Name = "txtDefi";
            this.txtDefi.Size = new System.Drawing.Size(319, 17);
            this.txtDefi.TabIndex = 10;
            this.txtDefi.Text = "Et si vous essayiez d\'avoir ce fait de cogniticien : ";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDefi);
            this.Controls.Add(this.txtSousTitre);
            this.Controls.Add(this.valNbMort);
            this.Controls.Add(this.valNbFait);
            this.Controls.Add(this.valNbVie);
            this.Controls.Add(this.txtNbFait);
            this.Controls.Add(this.txtNbMort);
            this.Controls.Add(this.txtNbVie);
            this.Controls.Add(this.txtNomsGroupe);
            this.Controls.Add(this.txtAccueil);
            this.Controls.Add(this.btnJouer);
            this.Name = "Accueil";
            this.Size = new System.Drawing.Size(724, 474);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJouer;
        private System.Windows.Forms.Label txtAccueil;
        private System.Windows.Forms.Label txtNomsGroupe;
        private System.Windows.Forms.Label txtNbVie;
        private System.Windows.Forms.Label txtNbMort;
        private System.Windows.Forms.Label txtNbFait;
        private System.Windows.Forms.Label valNbVie;
        private System.Windows.Forms.Label valNbFait;
        private System.Windows.Forms.Label valNbMort;
        private System.Windows.Forms.Label txtSousTitre;
        private System.Windows.Forms.Label txtDefi;
    }
}
