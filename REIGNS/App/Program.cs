using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Domain;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace App
{
    class Program
    {
        
        public static Partie MaPartie = new Partie();

        
        
        public static ReponseRepository reponseRep;
        public static FaitRepository faitRep;
        public static MortRepository mortRep;
        public static EffetRepository effetRep;
        public static ObjetRepository objetRep;
        public static PersonnageRepository persoRep;
        public static EvenementRepository eventRep;
        public static CarteRepository carteRep;


        static void Main(string[] args)
        {                 
            // initialiser les repository
            
            reponseRep = new ReponseRepository();
            faitRep = new FaitRepository();
            mortRep = new MortRepository();
            effetRep = new EffetRepository();
            objetRep = new ObjetRepository();
            persoRep = new PersonnageRepository();
            eventRep = new EvenementRepository();
            carteRep = new CarteRepository();

            // les ranger dans la partie            
            MaPartie.CartesSpeciales = carteRep.GetCartesSpeciales();
            MaPartie.CartesNoEvent = carteRep.GetCarteNotEvent();
            MaPartie.Objets = objetRep.GetAll();
            MaPartie.Faits = faitRep.GetAll();
            MaPartie.Morts = mortRep.GetAll();
            MaPartie.Events = eventRep.GetAll(carteRep);
            
            Console.WriteLine(Lancement());
            Console.ReadKey();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Gestionnaire MonGestionnaire = new Gestionnaire();

            Application.Run(MonGestionnaire);
        }

        public static string Lancement()
        {
            if ((MaPartie.Objets.Count() > 0) && (MaPartie.Morts.Count() > 0) && (MaPartie.Faits.Count() > 0) && (MaPartie.CartesNoEvent.Count() > 0) && (MaPartie.CartesSpeciales.Count() > 0) && (MaPartie.Events.Count() > 0))
            {
                return "Tous les éléments ont été chargés correctement. Appuyer pour lancer le jeu.";
            }
            return "Tous les éléments n'ont pas été chargés correctement.";
        }

    }
}
