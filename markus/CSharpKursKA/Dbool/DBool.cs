﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbool
{
    class DBool
    {
        static void Main(string[] args)
        {
                        #region M02

            // ===========================================================
            Console.WriteLine("\n ### bool literals ###");
            Console.WriteLine("true / false");

            // ===========================================================
            Console.WriteLine("\n ### bool operators ###");
            bool myB1 = true;
            bool myB2 = false;
            bool myB3 = true;

            // ===========================================================
            Console.WriteLine("\n ### bool operators: == ###");
            Console.WriteLine(myB1 == myB2); // false

            // ===========================================================
            Console.WriteLine("\n ### bool operators: || ###");
            Console.WriteLine(myB1 || myB3); // true

            // ===========================================================
            Console.WriteLine("\n ### bool operators: ^ ###"); // xor oder exclusive or
            Console.WriteLine(myB1 ^ myB3); //Ergebnis: false
            //Resultat ist true, nur wenn ein Wert true ist.

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
