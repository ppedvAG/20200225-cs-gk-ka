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

        enum Wochentag { Mo=1, Di, Mi, Do, Fr, Sa, So };

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
            Console.WriteLine("- Und ich hab {0} genommen.", PiGr2);


            #endregion

            #region M3

            Console.Write("Geben Sie den Wochentag als Zahl 1 bis 7 ein ");
            Wochentag WoTag = (Wochentag)(int.Parse(Console.ReadLine()));
            


            switch (WoTag)
            {
                case Wochentag.Mo:
                    PiGr = (Pizzagröße)(2);
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot gibt es die Größe {PiGr} zum Preis der Größe Klein");
                    break;

                case Wochentag.Di: case Wochentag.Mi: case Wochentag.Do:
                    PiGr = (Pizzagröße)(1);
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot gibt es die Größe {PiGr} zum Preis der Größe Klein");
                    break;

                case Wochentag.Fr:
                    PiGr = (Pizzagröße)(3);
                    Console.WriteLine($"Der gewählte Tag ist {WoTag}, im Angebot gibt es die Größe {PiGr} zum Preis der Größe Klein");
                    break;

                default:
                    Console.WriteLine("Am Wochenende gibt es keine Angebote");
                    break;
            }


            Console.ReadKey();

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
