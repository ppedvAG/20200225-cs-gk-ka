using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dint
{
    class Dint
    {
        static void Main(string[] args)
        {
            #region M02

            // ===========================================================
            Console.WriteLine("\n ### int literale ###");
            int myInt1 = 4;
            int myInt2 = -3;

            Console.WriteLine("\n # int possible values #");
            // ===========================================================
            Console.WriteLine("\n ### int.MinValue possible values ###");
            Console.WriteLine($"int.MinValue: {int.MinValue}");
            Console.WriteLine("\n ### int.MaxValue possible values ###");
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");

            // ===========================================================
            Console.WriteLine("\n ### int.parse() ###");
            Console.Write("Geben Sie eine Zahl ein: ");
            string ZahlAlsString = Console.ReadLine();
            int GecastedString = int.Parse(ZahlAlsString);
            Console.WriteLine($"gecastedString is int: {GecastedString.GetType()}");
            Console.WriteLine($"gecastedString is int: {GecastedString is int}"); //true

            // ===========================================================
            Console.WriteLine("\n ### (int)kommazahl ###");
            double kommazahl = 45.23;
            int ganzzahl = (int)kommazahl;
            Console.WriteLine($"ganzzahl: {ganzzahl}");


            #endregion

            // #############################################################################
            // #############################################################################
            // #############################################################################

            #region MORE FANCY STUFF

            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            // ===========================================================
            #endregion

            Console.ReadKey();
        }
    }
}
