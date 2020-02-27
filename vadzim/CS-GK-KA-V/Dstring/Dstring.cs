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
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 1: doppelte Anführungszeichen");
            string Alter = "sechsundzwanzig";
            string Stadt = "Mannheim";


            // ===========================================================
            Console.WriteLine("\n ### string possible values ###");
            Console.WriteLine("theoretisch könnte ein string 1,073,741,823 Zeichen lang sein");
            // versuchen Sie lieber diese Grenzen nicht auszutesten


            // ===========================================================
            Console.WriteLine("\n ### string operators ###");
            Console.WriteLine("string = string + string"); // concatinate
            Console.WriteLine(Alter + Stadt is string); // True

            Console.WriteLine("string = string + int"); // casting implicit
            int Jahr = 2000;
            Console.WriteLine(Stadt + Jahr);
            Console.WriteLine("Stadt + Jahr is string: {0}", Stadt + Jahr is string); // true


            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 2: $\"some text { }\" (interpolated strings)");
            string Satz = $"Stadt + Jahr is string: {Stadt + Jahr is string} und noch text { true }";
            Console.WriteLine(Satz);


            // ===========================================================
            Console.WriteLine("\n ### escape sequenzen ###");
            Console.WriteLine("vor dem Tabulator \t nach dem Tabulator");
            Console.WriteLine("C:\\Programme\\irgendwas.doc");


            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 3: verbatim strings");
            Satz = @"vor dem tab        nach dem tab
nach dem Zeilenumbruch";
            Console.WriteLine(Satz);
            // übernimmt whitespaces und ähnlichen Kram


            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 4: kombi verbatim & interpolation strings");
            Satz = $@"vor dem tab        nach dem tab {Jahr}
nach dem Zeilenumbruch";
            Console.WriteLine(Satz);









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
