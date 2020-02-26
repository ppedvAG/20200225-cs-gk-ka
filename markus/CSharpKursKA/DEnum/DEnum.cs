using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEnum
{
    class DEnum
    {
        // Enumeratoren sind selbst definierte Datentypen mit festgelegten möglichen Zuständen.
        // Jeder Zustand ist dabei an einen Int-Wert gekoppelt (Casting möglich).
        // ===========================================================
        enum Pizzagröße { Klein, Mittel, Groß, Family };
        //ENUMS werden außerhalb von Methoden deklariert
        enum Wochentag { Mo = 1, Di = 2, Mi, Do, Fr, Sa, So };
        static void Main(string[] args)
        {
            #region M02
            Console.WriteLine("\n # Declaration of Enums #");
            // Siehe den Code über der Main Methode
            // ===========================================================
            Console.WriteLine("\n ### Calling of enums ###");
            Pizzagröße PiGr = Pizzagröße.Mittel;
            Console.WriteLine($"Ich habe mir eine Pizza von der Größe {PiGr} gegönnt.");
            Pizzagröße PiGr2 = (Pizzagröße)(2);
            Console.WriteLine($" - Und ich habe {PiGr2} genommen.");
            #endregion

            #region M03
            Console.WriteLine("\n # Switch #");
            // ===========================================================
            Console.WriteLine("\n ### Anlage Wochentag###");
            Console.Write("Geben Sie den Wochentag ein :");
            Wochentag WoTag = (Wochentag)(int.Parse(Console.ReadLine()));
            Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot {PiGr}");

            Console.WriteLine("\n ### Switch  ###");
            switch (WoTag)
            {
                case Wochentag.Mo: case Wochentag.Di:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag} und im Angebot {Pizzagröße.Family}.");
                    break;
                case Wochentag.Mi: case Wochentag.Do:
                    Console.WriteLine($"Der gewählte Tag ist {WoTag} und im Angebot {Pizzagröße.Groß}.");
                    break;
                case var TestWoTag when (TestWoTag > Wochentag.Do): //Case When mit Pattern Matching
                    Console.WriteLine($"Das Wochenendangebot sind Pizzas der Größe {Pizzagröße.Mittel}.");
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
