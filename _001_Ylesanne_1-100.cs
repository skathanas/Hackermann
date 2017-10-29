using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Numbrikeiss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata.");

            string input = Console.ReadLine();
            int Number1 = int.Parse(input);


            int Number2 = 50;

            bool hasNotGuessed = true;
            while (hasNotGuessed)
            {
                if (Number2 < Number1)
                {
                    Console.WriteLine("Number on suurem");
                    hasNotGuessed = false;
                }

                if (Number2 > Number1)
                {
                    Console.WriteLine("Number on väiksem");
                    hasNotGuessed = false;
                }

                if (Number2 == Number1)
                {
                    Console.WriteLine("Õige number!");
                    hasNotGuessed = true;
                    Console.WriteLine("Vajuta anykey'd");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Vajuta anykey'd");

            Console.ReadLine();
        }
    }
}
