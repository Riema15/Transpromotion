namespace App
{
    partial class EcranPrincipal
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
            this.txtNomPerso = new System.Windows.Forms.GroupBox();
            this.txtCarteContenu = new System.Windows.Forms.Label();
            this.txtSante = new System.Windows.Forms.Label();
            this.valSante = new System.Windows.Forms.Label();
            this.valSocial = new System.Windows.Forms.Label();
            this.txtSocial = new System.Windows.Forms.Label();
            this.valScolaire = new System.Windows.Forms.Label();
            this.txtScolaire = new System.Windows.Forms.Label();
            this.valSous = new System.Windows.Forms.Label();
            this.txtSous = new System.Windows.Forms.Label();
            this.btnReponse1 = new System.Windows.Forms.Button();
            this.btnReponse2 = new System.Windows.Forms.Button();
            this.txtNomCycle = new System.Windows.Forms.Label();
            this.txtNbJour = new System.Windows.Forms.Label();
            this.valNbJour = new System.Windows.Forms.Label();
            this.btnObjet0 = new System.Windows.Forms.Button();
            this.btnObjet1 = new System.Windows.Forms.Button();
            this.btnObjet2 = new System.Windows.Forms.Button();
            this.btnObjet5 = new System.Windows.Forms.Button();
            this.btnObjet4 = new System.Windows.Forms.Button();
            this.btnObjet3 = new System.Windows.Forms.Button();
            this.btnObjet7 = new System.Windows.Forms.Button();
            this.btnObjet6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomPerso.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomPerso
            // 
            this.txtNomPerso.Controls.Add(this.txtCarteContenu);
            this.txtNomPerso.Location = new System.Drawing.Point(40, 146);
            this.txtNomPerso.Name = "txtNomPerso";
            this.txtNomPerso.Size = new System.Drawing.Size(624, 127);
            this.txtNomPerso.TabIndex = 0;
            this.txtNomPerso.TabStop = false;
            this.txtNomPerso.Text = "Nom";
            // 
            // txtCarteContenu
            // 
            this.txtCarteContenu.AutoSize = true;
            this.txtCarteContenu.Location = new System.Drawing.Point(27, 37);
            this.txtCarteContenu.Name = "txtCarteContenu";
            this.txtCarteContenu.Size = new System.Drawing.Size(56, 17);
            this.txtCarteContenu.TabIndex = 0;
            this.txtCarteContenu.Text = "Coucou";
            // 
            // txtSante
            // 
            this.txtSante.AutoSize = true;
            this.txtSante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSante.Location = new System.Drawing.Point(80, 94);
            this.txtSante.Name = "txtSante";
            this.txtSante.Size = new System.Drawing.Size(67, 20);
            this.txtSante.TabIndex = 1;
            this.txtSante.Text = "Santé : ";
            // 
            // valSante
            // 
            this.valSante.AutoSize = true;
            this.valSante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSante.Location = new System.Drawing.Point(153, 90);
            this.valSante.Name = "valSante";
            this.valSante.Size = new System.Drawing.Size(20, 24);
            this.valSante.TabIndex = 2;
            this.valSante.Text = "0";
            // 
            // valSocial
            // 
            this.valSocial.AutoSize = true;
            this.valSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSocial.Location = new System.Drawing.Point(299, 90);
            this.valSocial.Name = "valSocial";
            this.valSocial.Size = new System.Drawing.Size(20, 24);
            this.valSocial.TabIndex = 4;
            this.valSocial.Text = "0";
            // 
            // txtSocial
            // 
            this.txtSocial.AutoSize = true;
            this.txtSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSocial.Location = new System.Drawing.Point(226, 94);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(70, 20);
            this.txtSocial.TabIndex = 3;
            this.txtSocial.Text = "Social : ";
            // 
            // valScolaire
            // 
            this.valScolaire.AutoSize = true;
            this.valScolaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valScolaire.Location = new System.Drawing.Point(463, 90);
            this.valScolaire.Name = "valScolaire";
            this.valScolaire.Size = new System.Drawing.Size(20, 24);
            this.valScolaire.TabIndex = 6;
            this.valScolaire.Text = "0";
            // 
            // txtScolaire
            // 
            this.txtScolaire.AutoSize = true;
            this.txtScolaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScolaire.Location = new System.Drawing.Point(385, 94);
            this.txtScolaire.Name = "txtScolaire";
            this.txtScolaire.Size = new System.Drawing.Size(85, 20);
            this.txtScolaire.TabIndex = 5;
            this.txtScolaire.Text = "Scolaire : ";
            // 
            // valSous
            // 
            this.valSous.AutoSize = true;
            this.valSous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valSous.Location = new System.Drawing.Point(608, 90);
            this.valSous.Name = "valSous";
            this.valSous.Size = new System.Drawing.Size(20, 24);
            this.valSous.TabIndex = 8;
            this.valSous.Text = "0";
            // 
            // txtSous
            // 
            this.txtSous.AutoSize = true;
            this.txtSous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSous.Location = new System.Drawing.Point(535, 94);
            this.txtSous.Name = "txtSous";
            this.txtSous.Size = new System.Drawing.Size(62, 20);
            this.txtSous.TabIndex = 7;
            this.txtSous.Text = "Sous : ";
            // 
            // btnReponse1
            // 
            this.btnReponse1.Location = new System.Drawing.Point(117, 279);
            this.btnReponse1.Name = "btnReponse1";
            this.btnReponse1.Size = new System.Drawing.Size(228, 95);
            this.btnReponse1.TabIndex = 9;
            this.btnReponse1.Text = "ok1";
            this.btnReponse1.UseVisualStyleBackColor = true;
            // 
            // btnReponse2
            // 
            this.btnReponse2.Location = new System.Drawing.Point(403, 279);
            this.btnReponse2.Name = "btnReponse2";
            this.btnReponse2.Size = new System.Drawing.Size(228, 95);
            this.btnReponse2.TabIndex = 10;
            this.btnReponse2.Text = "ok2";
            this.btnReponse2.UseVisualStyleBackColor = true;
            // 
            // txtNomCycle
            // 
            this.txtNomCycle.AutoSize = true;
            this.txtNomCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCycle.Location = new System.Drawing.Point(126, 34);
            this.txtNomCycle.Name = "txtNomCycle";
            this.txtNomCycle.Size = new System.Drawing.Size(123, 32);
            this.txtNomCycle.TabIndex = 11;
            this.txtNomCycle.Text = "TonNom";
            // 
            // txtNbJour
            // 
            this.txtNbJour.AutoSize = true;
            this.txtNbJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbJour.Location = new System.Drawing.Point(421, 44);
            this.txtNbJour.Name = "txtNbJour";
            this.txtNbJour.Size = new System.Drawing.Size(139, 20);
            this.txtNbJour.TabIndex = 12;
            this.txtNbJour.Text = "Nombre de jour : ";
            // 
            // valNbJour
            // 
            this.valNbJour.AutoSize = true;
            this.valNbJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valNbJour.Location = new System.Drawing.Point(566, 40);
            this.valNbJour.Name = "valNbJour";
            this.valNbJour.Size = new System.Drawing.Size(20, 24);
            this.valNbJour.TabIndex = 13;
            this.valNbJour.Text = "0";
            // 
            // btnObjet0
            // 
            this.btnObjet0.Location = new System.Drawing.Point(130, 400);
            this.btnObjet0.Name = "btnObjet0";
            this.btnObjet0.Size = new System.Drawing.Size(43, 41);
            this.btnObjet0.TabIndex = 14;
            this.btnObjet0.Text = "O0";
            this.btnObjet0.UseVisualStyleBackColor = true;
            // 
            // btnObjet1
            // 
            this.btnObjet1.Location = new System.Drawing.Point(192, 400);
            this.btnObjet1.Name = "btnObjet1";
            this.btnObjet1.Size = new System.Drawing.Size(43, 41);
            this.btnObjet1.TabIndex = 15;
            this.btnObjet1.Text = "O1";
            this.btnObjet1.UseVisualStyleBackColor = true;
            // 
            // btnObjet2
            // 
            this.btnObjet2.Location = new System.Drawing.Point(256, 400);
            this.btnObjet2.Name = "btnObjet2";
            this.btnObjet2.Size = new System.Drawing.Size(43, 41);
            this.btnObjet2.TabIndex = 16;
            this.btnObjet2.Text = "O2";
            this.btnObjet2.UseVisualStyleBackColor = true;
            // 
            // btnObjet5
            // 
            this.btnObjet5.Location = new System.Drawing.Point(439, 400);
            this.btnObjet5.Name = "btnObjet5";
            this.btnObjet5.Size = new System.Drawing.Size(43, 41);
            this.btnObjet5.TabIndex = 19;
            this.btnObjet5.Text = "O5";
            this.btnObjet5.UseVisualStyleBackColor = true;
            // 
            // btnObjet4
            // 
            this.btnObjet4.Location = new System.Drawing.Point(375, 400);
            this.btnObjet4.Name = "btnObjet4";
            this.btnObjet4.Size = new System.Drawing.Size(43, 41);
            this.btnObjet4.TabIndex = 18;
            this.btnObjet4.Text = "O4";
            this.btnObjet4.UseVisualStyleBackColor = true;
            // 
            // btnObjet3
            // 
            this.btnObjet3.Location = new System.Drawing.Point(313, 400);
            this.btnObjet3.Name = "btnObjet3";
            this.btnObjet3.Size = new System.Drawing.Size(43, 41);
            this.btnObjet3.TabIndex = 17;
            this.btnObjet3.Text = "O3";
            this.btnObjet3.UseVisualStyleBackColor = true;
            // 
            // btnObjet7
            // 
            this.btnObjet7.Location = new System.Drawing.Point(564, 400);
            this.btnObjet7.Name = "btnObjet7";
            this.btnObjet7.Size = new System.Drawing.Size(43, 41);
            this.btnObjet7.TabIndex = 21;
            this.btnObjet7.Text = "O7";
            this.btnObjet7.UseVisualStyleBackColor = true;
            // 
            // btnObjet6
            // 
            this.btnObjet6.Location = new System.Drawing.Point(500, 400);
            this.btnObjet6.Name = "btnObjet6";
            this.btnObjet6.Size = new System.Drawing.Size(43, 41);
            this.btnObjet6.TabIndex = 20;
            this.btnObjet6.Text = "O6";
            this.btnObjet6.UseVisualStyleBackColor = true;
            // 
   
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnObjet7);
            this.Controls.Add(this.btnObjet6);
            this.Controls.Add(this.btnObjet5);
            this.Controls.Add(this.btnObjet4);
            this.Controls.Add(this.btnObjet3);
            this.Controls.Add(this.btnObjet2);
            this.Controls.Add(this.btnObjet1);
            this.Controls.Add(this.btnObjet0);
            this.Controls.Add(this.valNbJour);
            this.Controls.Add(this.txtNbJour);
            this.Controls.Add(this.txtNomCycle);
            this.Controls.Add(this.btnReponse2);
            this.Controls.Add(this.btnReponse1);
            this.Controls.Add(this.valSous);
            this.Controls.Add(this.txtSous);
            this.Controls.Add(this.valScolaire);
            this.Controls.Add(this.txtScolaire);
            this.Controls.Add(this.valSocial);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.valSante);
            this.Controls.Add(this.txtSante);
            this.Controls.Add(this.txtNomPerso);
            this.Name = "EcranPrincipal";
            this.Size = new System.Drawing.Size(717, 474);
            this.txtNomPerso.ResumeLayout(false);
            this.txtNomPerso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txtNomPerso;
        private System.Windows.Forms.Label txtSante;
        private System.Windows.Forms.Label valSante;
        private System.Windows.Forms.Label valSocial;
        private System.Windows.Forms.Label txtSocial;
        private System.Windows.Forms.Label valScolaire;
        private System.Windows.Forms.Label txtScolaire;
        private System.Windows.Forms.Label valSous;
        private System.Windows.Forms.Label txtSous;
        private System.Windows.Forms.Label txtCarteContenu;
        private System.Windows.Forms.Button btnReponse1;
        private System.Windows.Forms.Button btnReponse2;
        private System.Windows.Forms.Label txtNomCycle;
        private System.Windows.Forms.Label txtNbJour;
        private System.Windows.Forms.Label valNbJour;
        private System.Windows.Forms.Button btnObjet0;
        private System.Windows.Forms.Button btnObjet1;
        private System.Windows.Forms.Button btnObjet2;
        private System.Windows.Forms.Button btnObjet5;
        private System.Windows.Forms.Button btnObjet4;
        private System.Windows.Forms.Button btnObjet3;
        private System.Windows.Forms.Button btnObjet7;
        private System.Windows.Forms.Button btnObjet6;
        private System.Windows.Forms.Button button1;
    }
}
