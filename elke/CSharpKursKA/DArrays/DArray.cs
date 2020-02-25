using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DArray
{
    class DArray
    {
        static void Main(string[] args)
        {
            #region M3


            Console.WriteLine("\n # Anlegen von Arrays #");

            // ===========================================================
            Console.WriteLine("\n ### array with constructor and literals ###");
            int[] iaZahlen = new int[] { 1, 2, 3, 4, 5 };

            // ===========================================================
            Console.WriteLine("\n ### array with constructor ###");
            double[] daKommazahlen = new double[5];

            // ===========================================================
            Console.WriteLine("\n ### array with literal ###");
            double[] daArray = { 3.6, 4.5, 8.8 };


            // ===========================================================
            Console.WriteLine("\n # Coding / Aufrufen von Arrays #");
            // ===========================================================
            Console.WriteLine("\n ### calling the array ###");
            Console.WriteLine(iaZahlen);

            // ===========================================================
            Console.WriteLine("\n ### calling one element in the Array ###");
            Console.WriteLine(daKommazahlen[2]);
            Console.WriteLine("daKommazahlen[2]: {0}", daKommazahlen[2]); // 0 - ist Default bei Value Type
            string[] stringArray = new string[3];
            // Null darf nicht ausgeführt werden
            // Console.WriteLine("stringArray[1]", stringArray[1].ToString());// null

            // ===========================================================
            Console.WriteLine("\n # Interating Arrays #");
            // ===========================================================
            Console.WriteLine("\n ### for loop ###");
            for (int z = 0; z < iaZahlen.Length; z++)
            {
                //Was passiert bei jedem Durchlauf:
                Console.WriteLine(iaZahlen[z]);
            }

            Console.WriteLine("\n ### while ###");
            int i = 0;
            while (i < iaZahlen.Length)
            {
                Console.WriteLine(iaZahlen[i]);
                i++;
            }


            Console.WriteLine("\n ### foreach iterator ###");
            foreach(var item in daArray)
            {
                 Console.WriteLine(item);
                //Foreach-Variable darf nicht zum zwischenspeichern von eigenen Werten benutzt werden -> item++ kann nicht verwendet werden
            }












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
