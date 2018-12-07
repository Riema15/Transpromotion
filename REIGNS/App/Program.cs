using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    class Program
    {
        public static Partie MaPartie = new Partie();

        public static CarteRepository carteRep;
        public static ReponseRepository reponseRep;
        public static FaitRepository faitRep;
        public static MortRepository mortRep;
        public static EffetRepository effetRep;
        public static ObjetRepository objetRep;
        public static PersonnageRepository persoRep;



        static void Main(string[] args)
        {
            /*
            MaPartie.CartesEvent = carteRep.GetCarteEvent();
            MaPartie.CartesNoEvent = carteRep.GetCarteNotEvent();
            MaPartie.Objets = objetRep.GetAll();
            MaPartie.Faits = faitRep.GetAll();
            MaPartie.Morts = mortRep.GetAll();
            MaPartie.CartesSpeciales = carteRep.GetCartesSpeciales();
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Gestionnaire MonGestionnaire = new Gestionnaire();

            Application.Run(MonGestionnaire);
        }
    }
}
