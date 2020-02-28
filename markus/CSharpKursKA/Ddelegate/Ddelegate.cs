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
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("### Addieren ###");
            return a + b;
        }
        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("### Subtrahieren ###");
            return a - b;
        }
        #endregion

        #region step2
        // Delegate ist eine Variable / Klasse, in der man Funktionen mit gleichen Methodenkopf speichern kann.
        // Eigene Delegate Typen müssen vorher definiert werden.
        public delegate int MyDelegate(int a, int b);
        #endregion

        #region Callbacks in C# way
        public static void FühreAus(Func<int, int, int> auszuführendeMethode)
        {
            auszuführendeMethode(23, 43);
        }
        #endregion

        #region Lists & Delegates
        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }
        #endregion
        static void Main(string[] args)
        {
            #region step3
            // Den Delegaten einsetzen.
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            // Delegaten ausführen
            int ergebnis = delegateVariable(5, 8);
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");

            // Neuzuweisung der Variable
            delegateVariable = Subtrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");

            // Hinzufügen einer weiteren Methode zu der Variable
            delegateVariable += Addiere;
            // Ausgeführt werden die Methoden in glecher Reihenfolge wie sie hinzugefügt worden sind.
            // Aber nur den Return der letzten Methode können wir abfangen.
            ergebnis = delegateVariable(4, 4);
            Console.WriteLine($"Das Ergebnis ist: {ergebnis}");
            #endregion

            Console.WriteLine();


            #region Iteration of delegates
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }
            #endregion

            Console.WriteLine();

            #region Delete Function from Delegate
            // Entfernen einer weiteren Methode zu der Variable
            delegateVariable += Addiere;
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }
            delegateVariable = null;
            #endregion

            Console.WriteLine();

            #region eingebaute Delegaten
            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahiere;
            Console.WriteLine(meinFunc(42, 35));
            #endregion

            Console.WriteLine();
            FühreAus(meinFunc);

            Console.WriteLine();
            FühreAus(Addiere);

            #region Lists & Delegates Step 2
            Console.WriteLine();
            List<string> Städteliste = new List<string>() {  "Karlsruhe", "Hamburg","Bremen" };
            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine($"Die Stadt heißt: {gefundeneStadt}");

            // Übergabe einer Methode als anonyme Methode
            gefundeneStadt = Städteliste.Find(
                delegate (string stadt)
                {
                    return stadt.StartsWith("K");
                }
                );
            Console.WriteLine($"Die Stadt heißt: {gefundeneStadt}");

            // Übergabe einer Methode als Arrow Function / Pfeilfunktion / Lambda
            // Original
            //gefundeneStadt = Städteliste.Find((string stadt) => {return stadt.StartsWith("B"); } );
            // Falls nur ein Argument können dir runden Klammern weg
            // Falls nur eine Anweisung dann return und {} weg
            gefundeneStadt = Städteliste.Find( stadt => stadt.StartsWith("B"));
            Console.WriteLine($"Die Stadt heißt: {gefundeneStadt}");

            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
            #endregion

            // Vorteil von Pfeilfunktionen
            // Wenn wir die Methoden Addieren vorhin nicht definiert hätten:
            meinFunc = (a, b) => a + b;

            Console.ReadKey();
        }
    }
}
