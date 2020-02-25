using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2MiniRechner
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------Eingabe------------------------------
            Console.WriteLine("### MiniRechner ###");
            Console.Write("Bitte geben Sie die erste Zahl ein: ");
            int iZahl1 = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie die zweite Zahl ein: ");
            int iZahl2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //----------------------------Berechnungen------------------------------
            Console.WriteLine($"Ergebnis der Addition: {iZahl1 + iZahl2}");
            Console.WriteLine($"Ergebnis der Subtraktion: {iZahl1 - iZahl2}");
            Console.WriteLine($"Ergebnis der Multiplikation: {iZahl1 * iZahl2}");
            Console.WriteLine($"Ergebnis der Division: {iZahl1 / iZahl2} mit Rest {iZahl1 % iZahl2}");

            Console.ReadKey();

        }
    }
}
