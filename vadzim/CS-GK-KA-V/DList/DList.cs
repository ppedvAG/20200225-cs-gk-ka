using System;
using System.Collections.Generic;
// using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DList
{
    class DList
    {
        static void Main(string[] args)
        {

            #region M8

            Console.WriteLine("\n # DECLARING LISTS #");
            // ===========================================================
            Console.WriteLine("List<T>()-constructor");
            List<string> StringListe = new List<string>();

            
            Console.WriteLine("\n # USING LISTS ###");
            // ===========================================================
            Console.WriteLine("\n ### MyList.Add() ###");
            StringListe.Add("Eintrag1");
            StringListe.Add("Eintrag2");
            StringListe.Add("Eintrag3");
            StringListe.Add("Eintrag4");
            foreach (var item in StringListe)
            {
                Console.WriteLine($"item: {item}");
            }


            // ===========================================================
            Console.WriteLine("\n ### value of MyList ###");
            Console.WriteLine($"StringListe: {StringListe}");


            // ===========================================================
            Console.WriteLine("\n ### MyList.Count ###");
            Console.WriteLine($"StringListe.Count: {StringListe.Count}");


            // ===========================================================
            Console.WriteLine("\n ### MyList[i] ###");
            Console.WriteLine($"StringListe[2]: {StringListe[2]}");


            // ===========================================================
            Console.WriteLine("\n ### MyList.Remove(item) ###");
            StringListe.Remove("Eintrag2");
            Console.WriteLine("The List after Remove(\"Eintrag2\")");
            foreach (var item in StringListe)
            {
                Console.WriteLine($"item: {item}");
            }


            // ===========================================================
            Console.WriteLine("\n ### MyList.RemoveAt(n) ###");
            StringListe.RemoveAt(1);
            Console.WriteLine("The List after RemoveAt(1)");
            foreach (var item in StringListe)
            {
                Console.WriteLine($"item: {item}");
            }

            #endregion M8

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
