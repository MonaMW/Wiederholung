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
            int[] zahleneintraege = new int[] {45, 79, 22, 56, 83};

            Console.WriteLine(Summe(zahleneintraege));

            Console.ReadLine();
        }

        static int Summe(int[] intArray)
        {
            int summe = 0;
            foreach(int i in intArray)
            {
                summe += i;
            }
            return summe;
        }
    }
}
