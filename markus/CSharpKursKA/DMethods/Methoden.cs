using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMethods
{
    class Methoden
    {
        public static double Addiere(double a, double b, double c = 2, double d = 2)
        {
            double summe = a + b + c + d;
            return summe;
        }
        // modifier returnvalue identifier (args){ body }
        // args sind immer neu angelegte Variablen
        public static int Addiere(int a, int b, int c = 1, int d = 1) // Kopf der Funktion
        { // Körper der Funktion
            int summe = a + b + c + d;
            return summe;
        }
        // Anahl von obligatorischen Argumenten muss unterschiedlich sein!
        //public static int Addiere(int a, int b, int c = 1) // Kopf der Funktion
        //{ // Körper der Funktion
        //    int summe = a + b + c;
        //    return summe;
        //}

        public static int AddiereBeliebigViele(params int[] summanden)
        {
            int summe = 0;
            foreach (var item in summanden)
            {
                summe += item; // Ist 'summe = summe + item;' aber in hässlich.
            }
            return summe;
        }

        public static int AddiereUndSubtrahiereUndMultipliziere(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            return a + b;
        }

        static void Main(string[] args)
        {
            #region M04
            // ===========================================================
            Console.WriteLine("\n # declaring Methods #");
            Console.WriteLine("\n ### siehe Code ###");
            // Public-Methoden müssen in der Klasse deklariert werden.            

            // ===========================================================
            Console.WriteLine("\n # calling Methods #");
            Console.WriteLine("\n ### Simple Call ###");
            var summe = Addiere(1, 2);
            Console.WriteLine(summe);

            Console.WriteLine("\n ### Call with Optional Args ###");
            summe = Addiere(1, 2, 3, 4);
            Console.WriteLine(summe);

            Console.WriteLine("\n ### Overloads ###");
            double summeD = Addiere(1.5, 6.8, 4.789, 265.6954268);
            Console.WriteLine(summeD);

            Console.WriteLine("\n ### Params ###");
            summe = AddiereBeliebigViele(3, 4, 5, 6, 7, 8);
            Console.WriteLine(summe);

            Console.WriteLine("\n ### Out ###");
            summe = AddiereUndSubtrahiereUndMultipliziere(3,12,out int diff,out int prod);
            Console.WriteLine($"Summe: {summe}");
            Console.WriteLine($"Differenz: {diff}");
            Console.WriteLine($"Produkt: {prod}");

            Console.WriteLine("\n ### TryParse mit '4567' ###");
            string zahl = "4567";
            if (double.TryParse(zahl,out double doubleFromString))
            {
                Console.WriteLine($"Parsing möglich, doubleFromString: {doubleFromString}");
            }

            Console.WriteLine("\n ### TryParse mit 'uuu' ###");
            zahl = "uuu";
            if (double.TryParse(zahl, out doubleFromString))
            {
                Console.WriteLine($"Parsing möglich, doubleFromString: {doubleFromString}");
            }
            Console.WriteLine(doubleFromString); // 0

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
