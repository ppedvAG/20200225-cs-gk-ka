using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ZahlenratespielFr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlenratespiel");
            Random generator = new Random();
            int zufallszahl = generator.Next(1, 4);
            int ratemalzahl = 0;
            Console.WriteLine("Erraten Sie eine int-Zahl zwischen 1 und 3: ");


            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein: ");
                ratemalzahl = int.Parse(Console.ReadLine());

                if (ratemalzahl == zufallszahl)
                {
                    Console.WriteLine("Super");

                }

                else if (ratemalzahl < zufallszahl)
                { Console.WriteLine("ihre zahl Kleiner"); }

                else { Console.WriteLine("ihre zahl Größer"); }


            } while (ratemalzahl != zufallszahl);
        }
    }
}
