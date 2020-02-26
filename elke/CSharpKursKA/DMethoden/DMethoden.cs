using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMethoden
{
    class Dmethoden
    {
        //Modifier returnvalue identifier (args) {Body}
        
        public static int Addieren(int a, int b, int c = 0, int d = 0)//Kopf der Funktion
        {   //Körper der Funktion
            int summe = a + b + c + d;
            return summe;
        }

        //Anzahl von obligatorischen Argumenten muss unterschiedlich sein
        //Deklaration ist falsch da der Kompiler nicht weiss, welche er Verwenden soll
        //public static int Addieren(int a, int b, int c = 1)//Kopf der Funktion
        //{   //Körper der Funktion
        //    int summe = a + b + c;
        //    return summe;
        //}

        public static double Addieren(double a, double b, double c = 0, double d = 0)
        {
            double summe = a + b + c + d;
            return summe;
        }

        public static int AddiereBeliebigViele(params int [] summanden)

        {
            int summe = 0;
            foreach (var item in summanden)
            {
                summe += item;
                //summe = summe + item
            }
            return summe;
        }

        public static int AddSubMulti(int a, int b, out int differenz, out int produkt)
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
            Console.WriteLine("\n ### declaring methods oben ###");
            //Public Methoden müssen direkt in der Classe nicht in der Main declariert und angelegt werden

            // ===========================================================
            Console.WriteLine("\n ### calling Methods ###");
            // ===========================================================
            Console.WriteLine("\n ### simple call  ###");

            var summe = Addieren(2, 2); // var = Datentyp wird nicht festgelegt auf double oder int sondern kann alles sein
            Console.WriteLine(summe is int);

            summe = Addieren(3, 3, 3, 3);
            Console.WriteLine(summe);

            // ===========================================================
            Console.WriteLine("\n ### call mit options  ###");

            summe = AddiereBeliebigViele(4, 5, 6,7,8,9,1,2,3,4);
            Console.WriteLine($"Das ist die Summe {summe}");

            // ===========================================================
            Console.WriteLine("\n ### params  ###");

            double Dsumme = Addieren(1.1, 2.2, 3.3);
            Console.WriteLine(Dsumme);
            Console.WriteLine("Dsumme is double {0}", Dsumme is double);

            Console.WriteLine($"Das ist die Summe {summe}");

   
            
            Console.WriteLine("\n ### out  ###");
            summe = AddSubMulti(2, 12, out int diff, out int prod);

            Console.WriteLine($"Das ist die Summe {summe}, das ist die Differenz {diff} das ist das Produkt {prod}");


            string zahlalsstring = "345";
            //TryParse -> versuch zu Parsen und parse dann 
            if (double.TryParse(zahlalsstring, out double doubleFromString))
            {
                Console.WriteLine($"Parsing möglich und durchgeführt, doubleFromString: {doubleFromString}");
            }

            string zahlalsstring2 = "uuu";
            //TryParse -> versuch zu Parsen und parse dann 
            if (double.TryParse(zahlalsstring2, out double doubleFromString2))
            {
                Console.WriteLine($"Parsing möglich und durchgeführt, doubleFromString: {doubleFromString2}");
            }

            Console.WriteLine(doubleFromString2); //default ist 0



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
