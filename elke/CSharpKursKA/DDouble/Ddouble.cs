﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDouble
{
    class DDouble
    {
        static void Main(string[] args)
        {
            #region MXX

            // ===========================================================
            Console.WriteLine("\n ### Convert.??? ###");

            Console.Write("Geben Sie eine Double Zahl ein: ");
            double dInput = double.Parse(Console.ReadLine()); // Eingabe mit Punkt -> Punkt wird entfernt / Eingabe mit Komma funktioniert
            Console.WriteLine(dInput);

            string ichwilleindouble = "3.55";
            double dblFromString = double.Parse(ichwilleindouble, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("dblfromStr: {0}", dblFromString);
            

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