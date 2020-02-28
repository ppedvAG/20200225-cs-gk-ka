using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddelegate
{
    class Ddelegate
    {

        #region step1
        // Bsp-Methoden zur Demo der Delegates
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addieren");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtrahieren");
            return a - b;
        }

        #endregion


        #region step2
        // Delegate ist eine Variable / Klasse,
        // in der man Funktionen mit gleichem Methodenkopf speichern kann.
        // Eigene Delegate-Typen müssen vorher definiert werden.
        public delegate int MyDelegate(int a, int b);
        #endregion


        #region Callbacks in C# way
        public static void FühreAus(Func<int, int, int> auszuführendeMethode)
        {
            int result = auszuführendeMethode(23, 43);
            Console.WriteLine("result aus Führe aus " + result);
        }
        #endregion


        #region Lists & Delegates Step 1
        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }
        #endregion


        static void Main(string[] args)
        {
            #region step3
            // den Delegaten einsetzen
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            // den Delegaten ausführe
            int ergebnis = delegateVariable(2, 3);
            Console.WriteLine(ergebnis);

            // Neuzuweisung der Variable
            delegateVariable = Subtrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine(ergebnis);

            // Hinzufügen einer weiteren Methode zu der Variale
            delegateVariable += Addiere;
            // Ausgeführt werden die Methoden in gleicher Reihenfolge wie Hinzugefügt worden sind
            // Aber nur Return von der letzten können wir abfangen
            ergebnis = delegateVariable(4, 4);
            Console.WriteLine(ergebnis);
            #endregion


            #region Iteration of delegates
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }
            #endregion


            #region Delete Function from Delegate
            delegateVariable -= Addiere;
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }

            delegateVariable = null;
            #endregion


            #region eingebaute Delegaten
            Console.WriteLine("eingebaute Delegaten");
            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahiere;
            Console.WriteLine(meinFunc(34,32));
            #endregion

            Console.WriteLine("FühreAus");
            FühreAus(meinFunc);
            FühreAus(Addiere);


            #region Lists & Delegates Step 2
            List<string> Städteliste = new List<string>() { "Karlsruhe", "Hamburg", "Bremen" };
            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);

            // Übergabe einer Methode als anonyme Methode
            gefundeneStadt = Städteliste.Find(
                    delegate (string stadt)
                    {
                        return stadt.StartsWith("K");
                    }
                    );
            Console.WriteLine(gefundeneStadt);


            // Übergabe einer Methode als Arrow Function / Pfeilfunktion / Lambda
            gefundeneStadt = Städteliste.Find( (string stadt) => { return stadt.StartsWith("B"); });
            Console.WriteLine(gefundeneStadt);
            // Wenn die Pfeilfunktion nur ein Argument bekommt, dann ist die runde Klammer optional
            // und die geschweifte Klammer ist auch optional
            gefundeneStadt = Städteliste.Find( stadt => stadt.StartsWith("B"));
            Console.WriteLine(gefundeneStadt);

            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
            #endregion


            // Vorteil von Pfeilfunktionen
            // Wenn wir die Methode Addiere nicht definiert hätten:
            meinFunc = (a, b) => a + b;


            Console.ReadKey();
        }
    }
}
