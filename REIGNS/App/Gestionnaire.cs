using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class Gestionnaire : Form
    {

                
        public Gestionnaire()
        {
            InitializeComponent();
            Accueil userControlAccueil = new Accueil();
            Controls.Add(userControlAccueil);
        }
                     
        private void Gestionnaire_Load(object sender, EventArgs e)
        {        }


        public void ChangeControl(UserControl control)
        {
            if (this.Controls.Count != 0)
            {
                this.Controls.Clear();
            }
            this.Controls.Add(control);
        }


    }
}
