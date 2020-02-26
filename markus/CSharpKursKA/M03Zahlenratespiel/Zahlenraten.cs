using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M03Zahlenratespiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZAHLENRATESPIEL");
            Random generator = new Random();
            int zufallszahl = generator.Next(1,4);
            int ratemalzahl = 0;
            Console.Write("Erraten Sie eine int-Zahl zwischen 1 und 3: ");
            ratemalzahl= int.Parse(Console.ReadLine());

            while (ratemalzahl!=zufallszahl)
            {
                if (ratemalzahl > zufallszahl)
                {
                    Console.WriteLine("Deine Zahl ist zu hoch. Probiers nochmal.");
                    Console.Write("Neuer Versuch: ");
                    ratemalzahl = int.Parse(Console.ReadLine());
                }
                else if(ratemalzahl < zufallszahl)
                {
                    Console.WriteLine("Deine Zahl ist zu niedrig. Probiers nochmal");
                    Console.Write("Neuer Versuch: ");
                    ratemalzahl = int.Parse(Console.ReadLine());
                }
                    
            }

            Console.WriteLine("Glückwunsch! Du hast richtig geraten! :)");
            Console.ReadKey();

        }
    }
}
