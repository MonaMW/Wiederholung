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
            Console.WriteLine("Gebe mir eine Zahl");
            string zahl1 = Console.ReadLine();

            Console.WriteLine("Gebe mir eine weitere Zahl");
            string zahl2 = Console.ReadLine();

            //wenn das Ergebnis nochmal gebraucht wird,dann Addition(zahl1, zahl2) in einer Variable speichern
            Console.WriteLine($"Die Summe von {zahl1} und {zahl2} ist: {Addition(zahl1, zahl2)}");

            Console.ReadLine();
        }
        
        static int Addition(string z1, string z2)
        {
            int summe = Convert.ToInt32(z1) + Convert.ToInt32(z2);
            return summe;
        }
    }
}
