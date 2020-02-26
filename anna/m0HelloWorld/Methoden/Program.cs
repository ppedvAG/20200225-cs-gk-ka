using System;

namespace Methoden
{
    class Program
    {

        //modifier returnvalue identifier (args){body}
        public static int Addiere(int a, int b, int c = 0, int d = 0)

        {
            int summe = a + b + c + d;
            return summe;

        }


        //Anzahl von obligatorischen Argumenten muss unterschiedlich sein
        //public static int Addiere(int a, int b, int c = 1)

        //{
        //    int summe = a + b + c;
        //    return summe;

        //}



        public static double Addiere(double a, double b, double c = 0, double d=0) {

            double summe = a + b + c + d;
            return summe;
        }


        public static int AddiereBeliebigViele(params int[] summanden) 
        {
            int summe = 0;
            foreach (var item in summanden)

            { //summe = summe + item
                summe += item;
                    }

            return summe;
        }


        public static int AddiereUndSubstrahiereundMultiplizieren(int a, int b, out int differenz, out int produkt)
        {
            differenz = a - b;
            produkt = a * b;
            int summe = a + b;
            return summe;
        
        }
        static void Main(string[] args)
        {


            Console.WriteLine("\n declare methods");

            // Public-Methoden wie alle anderen müssen direkt in Klasse (nicht in der Main-Methode z.B.) deklariert werden. 

            int summe = Addiere(2, 2);
            Console.WriteLine(summe);

            summe = Addiere(2, 2, 2, 2);
            Console.WriteLine(summe);

           double summe1 = Addiere(2.3, 2, 2, 2);
            Console.WriteLine(summe1);


            summe = AddiereBeliebigViele(4, 5, 3, 4, 2, 4);
            Console.WriteLine(summe); // 22

            ///Zwischenergebnisse zeigen 
      
            summe = AddiereUndSubstrahiereundMultiplizieren(3, 12, out int diff, out int prod);
            Console.WriteLine($"summe: {summe}, diff: {diff}, prod: {prod}");

            string zahl = "345";
            if (double.TryParse(zahl, out double doubleFromStr))
            { Console.WriteLine($"Parsing möglich, doubleFromStr: {doubleFromStr}"); }

            Console.WriteLine(doubleFromStr);

        }
    }
}
