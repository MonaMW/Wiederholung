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
            Console.WriteLine("Gebe eine Zahl ein");
            float zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe einen Operator ein");
            string mathOperator = Console.ReadLine();

            Console.WriteLine("Gebe eine weitere Zahl ein");
            float zahl2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Das Ergebnis ist: {Calculate(zahl1, zahl2, mathOperator)}");

            Console.ReadLine();
        }

        static float Calculate(float z1, float z2, string op)
        {
            float summe = 0;

            switch (op)
            {
                case "+":
                    summe = z1 + z2;
                    break;
                case "-":
                    summe = z1 - z2;
                    break;
                case "*":
                    summe = z1 * z2;
                    break;
                case "/":
                    summe = z1 / z2;
                    break;
                case "%":
                    summe = z1 % z2;
                    break;
            }
            
            return summe;
        }
    }
}
