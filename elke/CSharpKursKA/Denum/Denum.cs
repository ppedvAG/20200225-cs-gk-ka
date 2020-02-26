using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denum
{
    class DEnum
    {
        //Enumeratoren sind selbst definierte Datentypen, mit festgelegten Zuständen
        //Jeder Zustand ist dabei an einen Integerwert gekoppelt (Casting möglich)
        enum Pizzagröße {Klein, Mittel, Groß, Family};
        //Variablen von dem Datentyp Pizzagröße dürfen nur die aufgelisteten Werte bekommen
        //Innerhalb von Methoden können keine ENUMS deklariert werden.

        enum Wochentage {Mo=1, Di, Mi, Do, Fr, Sa, So };


        static void Main(string[] args)
        {

            #region M2

            // ===========================================================
            Console.WriteLine("\n ### Declaration of enums ###");
            //siehe Code über der Main-Methode


            // ===========================================================
            Console.WriteLine("\n ### calling of enums ###");
            Pizzagröße PiGr = Pizzagröße.Mittel;
            Console.WriteLine("Ich habe mir eine Pizza von der Größe {0} bestellt", PiGr);

            //Enum gecastet
            Pizzagröße PiGr2 = (Pizzagröße)(2);
            Console.WriteLine("Und ich möchte eine Pizza von der Größe {0} bestellt", PiGr2);


            #endregion


            #region M3
            //Switch
            Console.Write("Geben Sie eine Wochentag ein: ");
            Wochentage wTag = (Wochentage)(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Der gewählte Tag ist {wTag}, im Angebot {PiGr}");


            switch (wTag)
            {
                case Wochentage.Mo:
                    Console.WriteLine($"Das Angebot des Tages {wTag}, im Angebot {PiGr}");
                    break;

                case Wochentage.Di: case Wochentage.Mi:
                    Console.WriteLine($"Das Angebot des Tages {wTag}, im Angebot {PiGr2}");
                    break;
                case Wochentage.Do:
                    Pizzagröße PiGr3 = (Pizzagröße)(3);
                    Console.WriteLine($"Das Angebot des Tages {wTag}, im Angebot {PiGr3}");
                    break;

                case Wochentage.Fr:
                    Console.WriteLine($"Das Angebot des Tages {wTag}, im Angebot {Pizzagröße.Family}");
                    break;
              //case mit Pattern-Matching
                case var tmpWotag when (tmpWotag> Wochentage.Fr):
                    Console.WriteLine($"Das Angebot des Tages {wTag}, im Angebot {Pizzagröße.Family}");
                    break;

                default:
                    Console.WriteLine("Die Preise entsprechen den Pizzagrößen.");
                    break;
            }

            // ===========================================================
            Console.WriteLine("\n ### Enum ###");

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
