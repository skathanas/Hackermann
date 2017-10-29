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

            Random rnd = new Random();
            int Number2 = rnd.Next(1, 100);

            START:
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata.");

            string input = Console.ReadLine();
            int Number1 = int.Parse(input);


            bool hasNotGuessed = true;
            while (hasNotGuessed)
            {
                while (Number2 > Number1)
                {
                    Console.WriteLine("Number on suurem");
                    hasNotGuessed = false;
                    goto START;
                }

                while (Number2 < Number1)
                {
                    Console.WriteLine("Number on väiksem");
                    hasNotGuessed = false;
                    goto START;
                }

                while (Number2 == Number1)
                {
                    Console.WriteLine("Arvasid numbri ära!");
                    hasNotGuessed = true;
                    break;
                }
            }

            Console.WriteLine("Vajuta anykey'd");

            Console.ReadLine();
        }
    }
}
