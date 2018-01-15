using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tunnikontroll_vol2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kohalik Peetri Pizza");
            Console.WriteLine("Volta tänaval, 24h");
            Console.WriteLine("----------------------------------");
            double hindKokku = 0;
            double hind = 0;

            do
            {
                hind = SetNumber("Sisesta hind, vajuta number üks, et väljuda: ");
                hindKokku = hindKokku + hind;
            }

            while (hind != 1);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Kokku: €{hindKokku}");

            double ale = hindKokku * 0.15;
            Console.WriteLine($"15% alega: €{hindKokku - ale}");
            Console.ReadLine();

            double SetNumber(string tekst)

            {
                double parse;
                Console.Write(tekst);
                string sisend = Console.ReadLine();
                while (!double.TryParse(sisend, out parse)) 

                {
                    Console.WriteLine("Hinna viga, sisesta numbrid");
                    Console.Write(tekst);
                    sisend = Console.ReadLine();
                }

                return double.Parse(sisend);
            }
        }
    }
}
