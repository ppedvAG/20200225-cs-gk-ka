using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DConsole
{
    class DConsole
    {
        static void Main(string[] args)
        {
            #region M1

            // ===========================================================
            Console.WriteLine("\n ### reine Ausgabe Console.WriteLine ###");// 
            Console.WriteLine("Ausgabe");

            Console.WriteLine("\n ### Definition der Console.WriteLine(string, arg0) ###");// 
            int Alter = 40;
            string Stadt = "KA";
            Console.WriteLine("Max ist {0} Jahre alt und wohnt in {1}", Alter, Stadt);

            Console.WriteLine("\n ### Definition der Console.Write() ###");// mit CR Write ohne CR Cursor bleibt in der Zeile stehen
            Console.Write("Ausgabe2");

            //Console.WriteLine("\n ### Definition der Console.ReadLine() ###");// 
            //Console.WriteLine("Bitte den Namen eingeben: ");
            //string sName = Console.ReadLine();
            //Console.WriteLine("Sie heißen: {0}", sName);
            
            Console.WriteLine("\n ### Console.OutputEncoding ###");// 
            Console.OutputEncoding = Encoding.UTF8; //
            Console.WriteLine("Eurozeichen mit Encoding.UTF8: €"); // 


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
