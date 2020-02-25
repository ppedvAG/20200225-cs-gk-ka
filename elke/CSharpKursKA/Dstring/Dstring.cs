using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dstring
{
    class Dstring
    {
        static void Main(string[] args)
        {
            #region M2

            // ===========================================================
            Console.WriteLine("\n ### string.literals ###");
            Console.WriteLine("Variante1: Doppelte Anführungszeichen");
            string sAlter = "sechzehn";
            string sStadt = "Pforzheim";

            // ===========================================================
            Console.WriteLine("\n ### string possible values ###");
            Console.WriteLine("theoretisch könnte ein String 1,073,741,823 Zeichen lang sein.");
            //Besser mit Dateien arbeiten, als mit großen Strings

            // ===========================================================
            Console.WriteLine("\n ### string operators ###");
            Console.WriteLine("string = string + string"); // concatinieren
            Console.WriteLine(sAlter + sStadt is string);//

            Console.WriteLine("string = string + int"); // implizites casting
            int iJahr = 2020;
            Console.WriteLine("Stadt + Jahr {0}", sStadt + iJahr );
            Console.WriteLine(sStadt + iJahr is string);

            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante2: $\"some text { }\" (interpolatet Strings)");
            string sSatz = $"Stadt + Jahr is string : { sStadt + iJahr is string} und noch ein Text {true}";
            Console.WriteLine(sSatz);

            // ===========================================================
            Console.WriteLine("\n ### escape sequenzen ###");
            Console.WriteLine("vor dem Tabulator \t nach dem Tabulator ");
            Console.WriteLine("c:\\Programme\\temp\\ew.txt");


            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante3: verbatin Strings"); // übernimmt alle Leerzeichen und Zeilenumbrüche

            sSatz = @"vor dem tab       nach dem Tab
                    nach dem Zeichenumbruch";
            Console.WriteLine(sSatz);


            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante4: verbatin mit interpolationStrings"); // 
            sSatz = $@"vor dem tab       nach dem Tab {iJahr}
                    nach dem Zeichenumbruch";
            Console.WriteLine(sSatz);





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
