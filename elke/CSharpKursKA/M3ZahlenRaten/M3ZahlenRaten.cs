using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ZahlenRaten
{
    class M3ZahlenRaten
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahlenraten Spiel");
            Random generator = new Random(); // neue Instanz von Random-Klasse
            int zufallszahl = generator.Next(1, 4);
            int rateZahl = 0;
            Console.WriteLine("Errate eine Ganzzahl zwischen 1 und 3:");
            rateZahl = int.Parse(Console.ReadLine());

            do
            {
                if (rateZahl < zufallszahl)
                {
                    Console.WriteLine("Die Zahl ist zu klein noch einmal:");
                    rateZahl = int.Parse(Console.ReadLine());
                    //continue;
                }

                if (rateZahl > zufallszahl)
                {
                    Console.WriteLine("Die Zahl ist zu groß noch einmal:");
                    rateZahl = int.Parse(Console.ReadLine());
                    //continue;
                }

                if (rateZahl == zufallszahl)
                {
                    break;
                }
            } while (rateZahl != zufallszahl);
            Console.WriteLine("Du hast die Zahl erraten");

            Console.ReadKey();


        }
    }
}
