using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des objets :");
            ObjetRepository objetRep = new ObjetRepository();
            IList<Objet> objets = objetRep.GetAll();
            foreach(Objet ob in objets)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine();




            Console.WriteLine("Liste des cartes :");
            CarteRepository carteRep = new CarteRepository();
            IList<Carte> cartes = carteRep.GetAll();
            foreach (Carte carte in cartes)
            {
                Console.WriteLine(carte);
            }
            Console.WriteLine();

            Console.WriteLine("Liste des evenements :");
            EvenementRepository eventRep = new EvenementRepository();
            IList<Evenement> Evenements = eventRep.GetAll();
            foreach (Evenement ev in Evenements)
            {
                Console.WriteLine(ev);
            }
            Console.WriteLine();
        }
    }
}
