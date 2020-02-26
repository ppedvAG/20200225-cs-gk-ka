using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3Zahlenratespiel
{
    class Zahlenratespiel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZAHLENRATESPIEL");
            Random generator = new Random();
            int zufallszahl = generator.Next(1, 4);
            int ratemalzahl = 0;
            Console.WriteLine("Erraten Sie eine int-Zahl zwischen 1 und 3");


            int anzahl = 0;
            
            do
            {
                Console.WriteLine("Geben Sie Ihre Zahl ein.");
                ratemalzahl = int.Parse(Console.ReadLine());
                anzahl++;

                if (ratemalzahl == zufallszahl)
                {
                    Console.WriteLine("Treffer!");
                }
                else if (ratemalzahl < zufallszahl)
                {
                    Console.WriteLine("Ihre Zahl ist zu klein.");
                }
                else if (ratemalzahl > zufallszahl)
                {
                    Console.WriteLine("Ihre Zahl ist zu groß.");
                }

            } while (ratemalzahl != zufallszahl);

            Console.WriteLine($"Sie haben {anzahl} Versuche gebraucht.");
        }
    }
}
