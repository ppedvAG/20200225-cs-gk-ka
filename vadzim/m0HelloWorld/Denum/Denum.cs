using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denum
{
    class Denum
    {
        // ENUMERATOREN sind selbst-definierte Datentypen mit festgelegten möglichen Zuständen.
        // Jeder Zustand ist dabei an einen Int-Wert gekoppelt (Casting möglich)
        enum Pizzagröße { Klein, Mittel, Groß, Family };
        // Variablen von dem Datentyp Pizzagröße dürfen nur die aufgelisteten Werte bekommen
        // enums werden außerhalb von Methoden deklariert

        enum Wochentag { Mo = 1, Di, Mi, Do, Fr, Sa, So }

        static void Main(string[] args)
        {
            #region M2


            // ===========================================================
            Console.WriteLine("\n ### declaration of enums ###");
            // siehe den Code über der Main-Methode

            // ===========================================================
            Console.WriteLine("\n ### calling of enums ###");
            Pizzagröße PiGr = Pizzagröße.Mittel;
            Console.WriteLine("Ich hab mir ne Pizza von der Größe {0} gewählt.", PiGr);
            Pizzagröße PiGr2 = (Pizzagröße)(2);
            Console.WriteLine("- Und ich hab {0} genommen", PiGr2);

            #endregion

            #region M3
            // switch

            Console.Write("Geben Sie Wochentag ein");
            Wochentag WoTag = (Wochentag)(int.Parse(Console.ReadLine()));
            


            switch (WoTag)
            {
                case Wochentag.Mo:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr}");
                    break;
                case Wochentag.Di: 
                case Wochentag.Mi:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr2}");
                    break;
                case Wochentag.Do:
                case Wochentag.Fr:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {Pizzagröße.Klein}");
                    break;
                case Wochentag.Sa:
                case Wochentag.So:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {Pizzagröße.Family}");
                    break;
                default:
                    Console.WriteLine("Die Preise entsprechen den Pizzagrößen");
                    break;
            }

            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            int a = 11;
            switch (a)
            {
                case 5:
                    Console.WriteLine("a = 5");
                    break;
                //a wird in b eingelegt (zu überprüfende Variable wir für Bedingungsprüfung vorbereitet)
                //und mittels when auf eine Eigenschaft geprüft
                case int b when b > 10:
                    Console.WriteLine("a > 10");
                    break;
                default:
                    Console.WriteLine("a ist irgendwas");
                    break;
            }
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
