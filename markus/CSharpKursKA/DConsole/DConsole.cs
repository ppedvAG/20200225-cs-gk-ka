﻿using System;
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
            Console.WriteLine("\n ### Convert.??? ###");
            Console.WriteLine("Ausgabe");

            // ===========================================================
            Console.WriteLine("\n ### Console.WriteLine(string,arg0) ###");
            int Alter = 40;
            string Stadt = "KA";
            Console.WriteLine("Max ist {0} Jahre alt und wohnt in {1}", Alter, Stadt);

            // ===========================================================
            Console.WriteLine("\n ### Console.Write() ###");
            Console.Write("Ausgabe2");
            // gibt den Parameter aus und der Cursor bleibt in der gleiche Zeile.

            // ===========================================================
            Console.WriteLine("\n ### Console.ReadLine() ###");
            Console.WriteLine("Geben Sie Ihren Namen ein: ");
            //string Name = Console.ReadLine();
            //Console.WriteLine("Sie heißen also {0}",Name);

            // ===========================================================
            Console.WriteLine("\n ### Console.OutputEncoding ###");
            Console.WriteLine("Eurozeichen: €"); // steht ?
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("\n ### Ausgabe mit Console.OutputEncoding = Encoding.UTF8 ###");
            Console.WriteLine("Eurozeichen: €"); // steht €

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
