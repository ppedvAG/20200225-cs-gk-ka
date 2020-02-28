using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDelegate
{
    class DDelegate
    {
        #region step1
        //Beispiel-Methode zur Demo der Delegates
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addiere");
            return a + b;
            }

        public static int Subtrahieren(int a, int b)
        {
            Console.WriteLine("Subtrahieren");
            return a - b;
        }

        #endregion

        #region step2
        //Delegate ist eine Variable / Klasse
        //in der man Funmtionen mit gleichen Methoden speicher kann.
        //eigene Delegate-Typen müssen veorher definiert werden.
        public delegate int MyDelegate(int a, int b);
        #endregion

        #region Callbacks in C# way
        public static void FühreAus(Func<int, int, int> auszuführendeMethode)
        {
            auszuführendeMethode(23, 43);

            int result = auszuführendeMethode(23, 43);
            Console.WriteLine($"Ergebnis result: {result}");
        }
        #endregion

        #region Lists and Delegates Step1
        public static bool SucheStadtMitH(string stadt)
        {
            return stadt.StartsWith("H");
        }

        

        #endregion

        static void Main(string[] args)
        {

            #region step3
            //Den Delegaten nutzen / einsetzen
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            //Delegaten ausführen
            int ergebnis = delegateVariable(2, 3);
            Console.WriteLine($"\n Das Ergebnis Addition  {ergebnis}");

            //Neuzuweisung der Variable
            delegateVariable = Subtrahieren;
            ergebnis = delegateVariable(3, 2);
            Console.WriteLine($"\n Das Ergebnis iSubtraktion {ergebnis}");

            //Hinzufügen einer weiteren Methode zu der Variablen
            delegateVariable += Addiere;
            
            //Ausgeführt werden die Methoden in der gleiche n Reihenfolge, wie sie hinzugefügt wurden
            //aber nur Return der letzten kann abgefangen werden
            ergebnis = delegateVariable(4,4);
            Console.WriteLine($"\n Das Ergebnis  {ergebnis}");
            #endregion

            
            #region Iteration of delegates
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine($"\n Der Inhalt der Liste  {item.Method}");
            }
            #endregion

            #region Delete Function from Delegate
            delegateVariable -= Addiere;
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine($"\n Der Inhalt der Liste  {item.Method}");
            }

            //Delegate wird geleert
            delegateVariable = null;
            #endregion

            #region Build in (eingebaute) Delegaten
            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahieren;
            Console.WriteLine($"\n meinFunc von 34, 32: {meinFunc(34,32)}");

            #endregion

            #region Delegates Ausführen der Funktion
            Console.WriteLine($"\n Führe aus der Funktion meinFunc");
            FühreAus(meinFunc);

            Console.WriteLine($"\n Führe aus Addieren");
            FühreAus(Addiere);

            #endregion


            #region List and Delegates Step2

            List<string> StädteListe = new List<string>() { "Bremen", "Karlsruhe", "Hamburg" };

            string gefundeneStadt = StädteListe.Find(SucheStadtMitH);
            Console.WriteLine($"\n Gefunden Stadt: {gefundeneStadt}");

            //Übergabe einer Methode als anonyme Methode
            gefundeneStadt = StädteListe.Find(
                delegate (string stadt)
                {
                    return stadt.StartsWith("K");
                }
                );
            Console.WriteLine($"\n neue gefunden Stadt: {gefundeneStadt}");

            //Übergabe einer Methode als Arrow Function => Pfeilfunktion / Lambda
            gefundeneStadt = StädteListe.Find((string stadt) => { return stadt.StartsWith("B"); });
            Console.WriteLine($"\n neue gefunden Stadt: {gefundeneStadt}");

            //Wenn die Pfeilfunktion nur ein Argument bekommt, dann sind die runden Klammern optional
            // und die geschewiften Klammern ebenfalls
            gefundeneStadt = StädteListe.Find(stadt =>  stadt.StartsWith("B"));
            Console.WriteLine($"\n neue gefunden Stadt: {gefundeneStadt}");

            StädteListe = StädteListe.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in StädteListe)
            {
                Console.WriteLine($"\n Ausgabe der Liste: {item}");

            }


            #endregion

            //Vorteil von Pfeilfunktionen
            //wenn wir die Methode  Addieren nicht definiert hätten
            meinFunc = (a, b) => a + b;


            Console.ReadKey();

        }
    }
}
