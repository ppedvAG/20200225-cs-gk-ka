using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddelegate
{
    class Program
    {

        #region step1
        //Bsp-Methoden zur Demo der Delegates


        public static int Addiere(int a, int b)
        {

            Console.WriteLine("Addiere");
            return a + b;

        }
        public static int Substrahiere(int a, int b)
        {

            Console.WriteLine("Substrahieren");
            return a - b;

        }



        #endregion

        #region Callbacks in C# 


        public static void FühreAus(Func<int, int, int> auszuführendeMethode)

        {
            int result = auszuführendeMethode(23, 43);
            Console.WriteLine("result aus Führeaus" + result);
        }


        #region Lists & Delegates Step 1 

        public static bool SucheStadtMith(string stadt)

        {
            return stadt.StartsWith("H");



        }



        #endregion


        #region step2

        //Delegate ist eine Variable oder Klasse, in der man Funktionen mit gleichen Methodenkopf speichern kann. 
        //und eigene Delegate-Typen müssen vorher definiert werden

        public delegate int MyDelegate(int a, int b);
        #endregion

        static void Main(string[] args)
        {

            #region step3

            //den Delgaten einsetzen 
            MyDelegate delegateVariable = new MyDelegate(Addiere);

            //den Delegaten ausführen 
            int ergebnis = delegateVariable(2, 3);
            Console.WriteLine(ergebnis);


            //Neuzuweisung der Variable 
            delegateVariable = Substrahiere;
            ergebnis = delegateVariable(5, 2);
            Console.WriteLine(ergebnis);


            //Hinzufügen einer weiteren Methode zur Variable 


            delegateVariable += Addiere;

            //Ausgeführt werden die Methoden in gleichen Reihenfolge wie sie hinzugefügt worden sind 

            //Aber nur Return von der letzten können wir abfangen 

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

            Func<int, int, int> meinFunc = Addiere;

            meinFunc += Substrahiere;
            Console.WriteLine(meinFunc(34, 32));

            #endregion

            Console.WriteLine("Führeaus(meinfunc):");
            FühreAus(meinFunc);

            Console.WriteLine("Führeaus(meinfunc):");
            FühreAus(meinFunc);


            FühreAus(meinFunc);
            FühreAus(Addiere);




            #region Lists & Delegates Step 2

            List<string> Städteliste = new List<string>() { "Bremen", "Karlsruhe", "Hamburg" };
            string gefundenStadt = Städteliste.Find(SucheStadtMith);



            Console.WriteLine(gefundenStadt);

            //Übergabe einer Methode als anonyme Methode

            gefundenStadt = Städteliste.Find(delegate (string stadt)
            {
                return stadt.StartsWith("K");
            });


            Console.WriteLine(gefundenStadt);


            //Übergabe einer Methode als Arrow Function /Pfeilfunktion/ Lambda

            gefundenStadt = Städteliste.Find( (string stadt) => { return stadt.StartsWith("B"); });
            Console.WriteLine(gefundenStadt);

            ///wenn die Pfeilfunktion nur einen Argumenten bekommt, dann die runden Klammern optional 
            /////wenn in der Funkltion nur eine Anweisung ausgefüht wird, dann return 
            ///und die geschweiften Klammern sind auch optional 
            gefundenStadt = Städteliste.Find(stadt => stadt.StartsWith("B"));
            Städteliste = Städteliste.OrderBy(stadt => gefundenStadt[0]).ToList();

            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }
            //Vorteil von Pfeilfunktion 
            //Wenn wir die Methode Addiere vorhin nicht degfiniert hätten: 
            meinFunc = (a, b) => a + b; 
             


            #endregion


            Console.ReadKey();
        }

    }
    #endregion
}