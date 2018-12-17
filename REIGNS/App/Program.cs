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

        public static CarteRepository carteRep;
        public static ReponseRepository reponseRep;
        public static FaitRepository faitRep;
        public static MortRepository mortRep;
        public static EffetRepository effetRep;
        public static ObjetRepository objetRep;
        public static PersonnageRepository persoRep;
        public static EvenementRepository eventRep;



        static void Main(string[] args)
        {
            MaPartie.CartesNoEvent = carteRep.GetCarteNotEvent();
            MaPartie.Objets = objetRep.GetAll();
            MaPartie.Faits = faitRep.GetAll();
            MaPartie.Morts = mortRep.GetAll();
            MaPartie.CartesSpeciales = carteRep.GetCartesSpeciales();
            MaPartie.Events = eventRep.GetAll();

            Console.WriteLine("Exporting DB schema... ");

            Configuration cfg = new Configuration();
            cfg.Configure();
            // Update database according to mapping files and DB credentials
            new SchemaExport(cfg).Execute(true, true, false);

            Console.WriteLine("Done!");
            Console.ReadKey();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Gestionnaire MonGestionnaire = new Gestionnaire();

            Application.Run(MonGestionnaire);
        }
    }
}
