using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            string bestand = "test.txt";
            SchrijfPersoon(LeesPersoon(), bestand);
            //ToonPersoon();
            Console.ReadKey();
        }
        Persoon LeesPersoon()
        {
            Persoon p = new Persoon();
            Console.Write("Voer je naam in: ");
            p.Naam = Console.ReadLine();
            Console.Write("Voer je woonplaats in: ");
            p.Woonplaats = Console.ReadLine();
            Console.Write("Voer je leeftijd in: ");
            p.Leeftijd = int.Parse(Console.ReadLine());
            return p;
        }
        void ToonPersoon(Persoon p)
        {
            Console.WriteLine("Naam: " + p.Naam);
            Console.WriteLine("Woonplaats: " + p.Woonplaats);
            Console.WriteLine("Leeftijd: " + p.Leeftijd);
        }
        void SchrijfPersoon(Persoon p, string bestandsNaam)
        {
            StreamWriter writer = new StreamWriter(bestandsNaam);
            writer.WriteLine(p.Naam);
            writer.WriteLine(p.Woonplaats);
            writer.WriteLine(p.Leeftijd);
            writer.Close();
        }
        Persoon LeesPersoon(string bestandsNaam)
        {
            StreamReader reader = new StreamReader(bestandsNaam);
            Console.WriteLine
        }
    }
}
