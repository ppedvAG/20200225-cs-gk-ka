using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2MiniRechner
{
    class MiniRechner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addieren von zwei ganzen Zahlen");
            Console.WriteLine("Geben Sie die erste Zahl ein.");
            string zahl1AlsString = Console.ReadLine();
            int gecastedString1 = int.Parse(zahl1AlsString);
            Console.WriteLine("Geben Sie die zweite Zahl ein.");
            string zahl2AlsString = Console.ReadLine();
            int gecastedString2 = int.Parse(zahl2AlsString);
            int ergebnis = gecastedString1 + gecastedString2;
            Console.WriteLine($"Die Summe ist: {ergebnis}");

            // Test
            Console.WriteLine("Test dritte Zahl");
            int test = int.Parse(Console.ReadLine());
            int ergebnis2 = ergebnis + test;
            Console.WriteLine(ergebnis2);
        }
    }
}
