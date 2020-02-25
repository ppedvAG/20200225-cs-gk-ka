using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenratespiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZAHLENRATESPIEL");
            Random generator = new Random();
            int zufallszahl = generator.Next(1, 4);
            int ratemalzahl = 0;
            do
            {
                Console.WriteLine("Erraten Sie eine int-Zahl zwischen 1 und 3: ");
                ratemalzahl = int.Parse(Console.ReadLine());
                if (zufallszahl == ratemalzahl)
                {
                    Console.WriteLine("Sie haben die Zahl erraten");
                }
                else if (zufallszahl < ratemalzahl)
                {
                    Console.WriteLine("Zufallszahl ist kleiner als Sie denken");

                }
                else
                {
                    Console.WriteLine("Zufallszahl ist größer als Sie denken");
                }
            } while (zufallszahl != ratemalzahl);
        }
    }
}
