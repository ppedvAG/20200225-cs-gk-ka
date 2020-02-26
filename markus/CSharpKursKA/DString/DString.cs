using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbool
{
    class Program
    {
        static void Main(string[] args)
        {
            #region M02

            // ===========================================================
            Console.WriteLine("\n ### string.literals ###");
            Console.WriteLine("Variante 1: doppelte Anführungszeichen");
            string Alter = "sechsundzwanzig";
            string Stadt = "Mannheim";

            // ===========================================================
            Console.WriteLine("\n ### string possible values ###");
            Console.WriteLine("\n ### theoretisch könnte ein string 1,073,741,823 Zeichen lang sein ###");

            // ===========================================================
            Console.WriteLine("\n ### string operators ###");
            Console.WriteLine("string = string + string"); // concatinate
            Console.WriteLine(Alter + Stadt is string); // True

            Console.WriteLine("string = string + int"); //casting implicit
            int Jahr = 2000;
            Console.WriteLine(Stadt + Jahr);
            Console.WriteLine("Stadt + Jahr is string: {0}", Stadt + Jahr is string); //true

            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("Variante 2: $\"some text { }\" (interpolated strings)");
            Console.WriteLine($"Stadt + Jahr is string: {Stadt + Jahr is string} und noch text {true}");

            // ===========================================================
            Console.WriteLine("\n ### escape sequenzen ###");
            Console.WriteLine("vor dem Tabulator \t nach dem Tabulator");
            Console.WriteLine("C:\\Programme\\irgendwas.docx");

            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("\n ### Variante 3: verbatim strings ###");
            string Satz = @"vor dem tab     nach dem Tab
nach dem Zeilenumbruch";
            Console.WriteLine(Satz); // übernimmt whitespaces und ähnlichen Kram

            // ===========================================================
            Console.WriteLine("\n ### string literals ###");
            Console.WriteLine("\n ### Variante 4: verbatim strings mit interpolation ###");
            Satz = $@"vor dem tab     nach dem Tab {Jahr}
nach dem Zeilenumbruch {Stadt}";
            Console.WriteLine(Satz); // übernimmt whitespaces und ähnlichen Kram


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
