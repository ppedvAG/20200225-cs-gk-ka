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
            #region M03

            Console.WriteLine("\n # DECLARING ARRAYS #");

            // ===========================================================
            Console.WriteLine("\n ### array w. constructor and literal ###");
            int[] zahlen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // ===========================================================
            Console.WriteLine("\n ### array w. constructor ###");
            double[] kommazahlen = new double[5];

            // ===========================================================
            Console.WriteLine("\n ### array w. literal ###");
            double[] doubleArray = { 4.2, 5.7, 6.12, 9.4875, 369.54, 258.45, 25.69 };


            Console.WriteLine("\n # CALLING ARRAYS #");

            // ===========================================================
            Console.WriteLine("\n ### calling the array ###");
            Console.WriteLine(zahlen); //System.Int32[]
            Console.WriteLine("kommazahlen[1]: {0}", kommazahlen[1]); // 0 - ist Default bei Value Type
            string[] stringArray = new string[3];
            Console.WriteLine("stringArray[1]: {0}", stringArray[1]); // NULL - ist Default bei Reference Type
            Console.WriteLine("NULL wird nicht angezeigt");


            Console.WriteLine("\n # ITERATING ARRAYS #");
            // ===========================================================
            Console.WriteLine("\n ### for loop ###");
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }
            // ===========================================================
            Console.WriteLine("\n ### while loop ###");
            int a = 0;
            while (a < zahlen.Length)
            {
                Console.WriteLine(zahlen[a]);
                a++;
            }

            // ===========================================================
            Console.WriteLine("\n ### for each iterator ###");
            foreach (var item in doubleArray)
            {
                Console.WriteLine(item); 
                //!!! die foreach Variable darf nicht zum Zwischenspeichern von unseren Werten gebraucht werden.
                //item ++ ist daher schlecht
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
