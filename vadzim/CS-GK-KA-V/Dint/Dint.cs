﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dint
{
    class Dint
    {
        static void Main(string[] args)
        {
            #region M2

            // ===========================================================
            Console.WriteLine("\n ### int literals ###");
            int myInt1 = 4;
            int myInt2 = -3;


            Console.WriteLine("# int possible values #");
            // ===========================================================
            Console.WriteLine("\n ### int.MinValue ###");
            Console.WriteLine($"int.MinValue: {int.MinValue}");
            Console.WriteLine("\n ### int.MaxValue ###");
            Console.WriteLine($"int.MaxValue: {int.MaxValue}");


            // ===========================================================
            Console.WriteLine("\n ### int.Parse() ###");
            Console.Write("Geben Sie eine Zahl ein: ");
            string zahlAlsString = Console.ReadLine();
            int gecastedString = int.Parse(zahlAlsString);
            Console.WriteLine($"gecastedString is int: {gecastedString is int}"); // true
            Console.WriteLine($"gecastedString.GetType(): {gecastedString.GetType()}"); // System.Int32


            // ===========================================================
            Console.WriteLine("\n ### (int)kommazahl ###");
            double kommazahl = 45.23;
            int ganzezahl = (int)kommazahl;
            Console.WriteLine($"ganzezahl: {ganzezahl}");


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