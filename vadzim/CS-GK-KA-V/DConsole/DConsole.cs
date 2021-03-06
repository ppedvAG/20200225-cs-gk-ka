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
            Console.WriteLine("\n ### Console.WriteLine() ###");
            // schreibt die Parameter zum Default-Output
            // bei der Konsole-App ist es die Konsole cmd
            // ein anderes Output könnte die Messagebox sein
            // snippet dafür: cw
            Console.WriteLine("ausgabe");


            // ===========================================================
            Console.WriteLine("\n ### Console.WriteLine(string, arg0, arg1) ###");
            int Alter = 40;
            string Stadt = "KA";
            Console.WriteLine("Max ist {0} Jahre alt und wohnt in {1}", Alter, Stadt);


            // ===========================================================
            Console.WriteLine("\n ### Console.Write() ###");
            Console.Write("ausgabe2");
            // gibt den Parameter aus und der Kursor bleibt in der gleichen Zeile


            // ===========================================================
            Console.WriteLine("\n ### Console.ReadLine() ###");
            // Console.WriteLine("Geben Sie Ihren Namen ein: ");
            // string Name = Console.ReadLine();
            // Console.WriteLine("Sie heißen also {0}", Name);


            // ===========================================================
            Console.WriteLine("\n ### Console.OutputEncoding ###");
            Console.WriteLine("Eurozeichen: €"); // steht ?
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Eurozeichen mit Encoding.UTF8: €"); // steht €


            #endregion

            // #############################################################################
            // #############################################################################
            // #############################################################################

            #region MORE FANCY STUFF

            // ===========================================================

            //Vorzeitiges Beenden der Konsolenapplikation
            Environment.Exit(0);
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
