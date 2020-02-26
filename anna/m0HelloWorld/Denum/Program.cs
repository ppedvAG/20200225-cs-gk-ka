using System;

namespace Denum
{
    class Program
    {

        enum Pizzagröße { KLein, Mittel, Groß, Family };

        enum Wochentag { Mo = 1, Di, Mi, Do, Fr, Sa, So }

        //Enum muss außer der Methoden deklariert werden
        static void Main(string[] args)
        {
            #region M2

            Console.WriteLine("\n ### declaration of enums ###");


            Console.WriteLine("\n ### calling of enums ###");
            Pizzagröße PiGr = Pizzagröße.Mittel;
            Console.WriteLine("Ich hab Pizza der Größe {0} gewählt.", PiGr);
            Pizzagröße PiGr2 = (Pizzagröße)(2);
            Console.WriteLine("- und ich hab {0} gewählt.", PiGr2);


            // ===========================================================

            #endregion


            ///Enumeratoren sind selbst-definierte Datentypen mit festgelegten möglichen Zuständen. 
            ///Jeder Zustand ist dabei an einen Int-Wert gekoppelt (Casting möglich). 
            ///

            //Variablen von dem Datentyp Pizzagröße dürfen nur die aufgelisteten Werte bekommen. 

            // ############################################################################
            // #############################################################################
            // #############################################################################


            #region M3

            Console.Write("Geben Sie Wochentag ein:");
            Wochentag WoTag = (Wochentag)(int.Parse(Console.ReadLine()));
            // Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr}");


            switch (WoTag)

            {
                case Wochentag.Mo:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr}");
                    break;

                case Wochentag.Di:
                case Wochentag.Mi:

                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr2}");
                    break;


                case Wochentag.Fr:

                    Pizzagröße PiGr3 = (Pizzagröße)(3);
                Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr3}");
               break;

               default:

                    Console.WriteLine("Die Preise etscprechen den PGr");
                    break;
            }




            #endregion

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
