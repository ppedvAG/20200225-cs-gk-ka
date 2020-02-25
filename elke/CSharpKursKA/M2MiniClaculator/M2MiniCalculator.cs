using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2MiniCalculator
{
    class M2MiniClaculator
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte die erste Zahl eingeben: ");
            string sZahl1 = Console.ReadLine();
            int iZahl1 = int.Parse(sZahl1);

            Console.Write("Bitte die zweite Zahl eingeben: ");
            string sZahl2 = Console.ReadLine();
            int iZahl2 = int.Parse(sZahl2);

            int iSumme = iZahl1 + iZahl2;

            Console.WriteLine($"Die Summe der Zahlen ist: {iSumme}");
            Console.WriteLine($"Die Differenz der Zahlen ist: {iZahl1 - iZahl2}");

            Console.ReadKey();


        }
    }
}
