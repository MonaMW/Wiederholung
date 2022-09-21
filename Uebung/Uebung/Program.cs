using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> azubiNamen = new List<string>() { "Nana", "Almond", "Norbert"};

            //List<string> NamesWithN = GiveMeTheNames(azubiNamen);

            //foreach(string name in NamesWithN)
            //{
            //    Console.WriteLine(name);
            //}

            Console.WriteLine("Gebe mir eine Zahl");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe mir eine weitere Zahl");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            //wenn das Ergebnis nochmal gebraucht wird,dann Addition(zahl1, zahl2) in einer Variable speichern
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist: {Addition(zahl1, zahl2)}");

            Console.ReadLine();
        }
        
        static int Addition(int z1, int z2)
        {
            int summe = z1 + z2;
            return summe;
        }

        //static List<string> GiveMeTheNames(List<string> AllTrainees)
        //{
        //    List<string> allTraineesWithN = new List<string>();

        //    foreach(string trainee in AllTrainees)
        //    {
        //        if (trainee.StartsWith("N"))
        //        {
        //            allTraineesWithN.Add(trainee);
        //        }
        //    }
        //    return allTraineesWithN;
        //}
    }
}
