using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMethods
{
    class DMethods

    {
        public static double Addiere(double a, double b, double c = 0, double d = 0)
        {
            double summe = a + b + c + d;
            return summe;
        }


        // modifier returnvalue identifier (args) { body }
        // args sind immer neu angelegte Variablen
        public static int Addiere(int a, int b, int c = 0, int d = 0) // Kopf der Funktion
        { // Körper der Funktion
            int summe = a + b + c + d;
            return summe;
        }

        // Anzahl von obligatorischen Argumenten muss unterschiedlich sein!
        //public static int Addiere(int a, int b, int c = 1)
        //{
        //    int summe = a + b + c;
        //    return summe;
        //}

        public static int AddiereBeliebigViele(params int[] summanden)
        {
            int summe = 0;
            foreach (var item in summanden)
            {
                // summe = summe + item;
                summe += item;
            }
            return summe;
        }

        public static int AddiereUndSubtrahiereUndMultipliziere(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
        }


        static void Main(string[] args)
        {
            #region M4

            // ===========================================================
            Console.WriteLine("\n ### declaring methods ###");
            Console.WriteLine("siehe code");
            //Public-Methoden wie alle anderen müssen in Klasse (nicht in der Main-Methode z.B.) deklariert werden.

            Console.WriteLine("# calling methods #");
            // ===========================================================
            Console.WriteLine("\n ### simple call ###");

            var summe = Addiere(2, 2);
            // variante mit int wurde genommen, obwohl Deklaration von double voransteht
            Console.WriteLine(summe is int); // True

            Console.WriteLine("\n ### call with optional args ###");
            summe = Addiere(2, 2, 2, 2);
            Console.WriteLine(summe);

            Console.WriteLine("\n ### overloads ###");
            double summeD = Addiere(2.3, 2.3);
            Console.WriteLine("summeD is double {0}", summeD is double);

            Console.WriteLine("\n ### params ###");
            summe = AddiereBeliebigViele(4, 5, 3, 4, 2, 4);
            Console.WriteLine(summe); // 22

            Console.WriteLine("\n ### out ###");
            summe = AddiereUndSubtrahiereUndMultipliziere(3, 12, out int diff, out int prod);
            Console.WriteLine($"summe: {summe }, diff: {diff}, prod: {prod}");

            string zahlAlsString = "uuu";
            Console.WriteLine("Parsen Versuch: ");
            if (double.TryParse(zahlAlsString, out double doubleFromStr))
            {
                Console.WriteLine($"Parsing möglich, doubleFromStr: {doubleFromStr}");
            }
            Console.WriteLine(doubleFromStr); // 0

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
