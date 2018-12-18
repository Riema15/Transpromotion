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

        /*
        public static CarteRepository carteRep;
        public static ReponseRepository reponseRep;
        public static FaitRepository faitRep;
        public static MortRepository mortRep;
        public static EffetRepository effetRep;
        public static ObjetRepository objetRep;
        public static PersonnageRepository persoRep;
        public static EvenementRepository eventRep;
        */


        static void Main(string[] args)
        {

            /*
            // initialiser les repository
            carteRep = new CarteRepository();
            reponseRep = new ReponseRepository();
            faitRep = new FaitRepository();
            mortRep = new MortRepository();
            effetRep = new EffetRepository();
            objetRep = new ObjetRepository();
            persoRep = new PersonnageRepository();
            eventRep = new EvenementRepository();

            // les ranger dans la partie
            
            MaPartie.Objets = objetRep.GetAll();
            MaPartie.Faits = faitRep.GetAll();
            MaPartie.Morts = mortRep.GetAll();
            MaPartie.CartesSpeciales = carteRep.GetCartesSpeciales();
            MaPartie.CartesNoEvent = carteRep.GetCarteNotEvent();
            MaPartie.Events = eventRep.GetAll();

            /*
            Console.WriteLine("Exporting DB schema... ");

            Configuration cfg = new Configuration();
            cfg.Configure();
            // Update database according to mapping files and DB credentials
            new SchemaExport(cfg).Execute(true, true, false);

            Console.WriteLine("Done!");
            Console.ReadKey();
            */
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Gestionnaire MonGestionnaire = new Gestionnaire();

            Application.Run(MonGestionnaire);
            */

            Console.WriteLine("Liste des faits :");
            FaitRepository faitRep = new FaitRepository();
            Console.WriteLine(faitRep);
            IList<Fait> Faits = faitRep.GetAll();
            foreach (Fait fait in Faits)
            {
                Console.WriteLine(fait.Nom);
            }
            Console.WriteLine();

            Console.WriteLine("Liste des objets :");
            ObjetRepository obRep = new ObjetRepository();
            Console.WriteLine(obRep);
            IList<Objet> Objets = obRep.GetAll();
            foreach (Objet ob in Objets)
            {
                Console.WriteLine(ob.Nom);
            }
            Console.WriteLine();

            Console.WriteLine("Liste des morts :");
            MortRepository mortRep = new MortRepository();
            IList<Mort> Morts = mortRep.GetAll();
            foreach (Mort mort in Morts)
            {
                Console.WriteLine(mort.Nom);
            }
            Console.WriteLine();

            Console.WriteLine("Liste des effets :");
            EffetRepository effetRep = new EffetRepository();
            IList<Effet> Effets = effetRep.GetAll();
            foreach (Effet effet in Effets)
            {
                Console.WriteLine(effet.Nom);
            }
            Console.WriteLine();


            Console.WriteLine("Liste des evenements :");
            EvenementRepository eventRep = new EvenementRepository();
            IList<Evenement> Evenements = eventRep.GetAll();
            foreach (Evenement ev in Evenements)
            {
                Console.WriteLine(ev.Nom);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
