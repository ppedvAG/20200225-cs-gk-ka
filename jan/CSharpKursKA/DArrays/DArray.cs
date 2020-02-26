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

            Console.WriteLine("# DECLARING ARRAYS #");
            // ===========================================================
            Console.WriteLine("\n ### array with constructor and literal ###");
            int[] zahlen = new int[] { 4, 6, 8 };


            // ===========================================================
            Console.WriteLine("\n ### array with constructor ###");
            double[] kommazahlen = new double[5];


            // ===========================================================
            Console.WriteLine("\n ### array with literal ###");
            double[] doubleArray = { 3.6, 2.8, 6.3 };



            Console.WriteLine("# CALLING ARRAYS #");
            // ===========================================================
            Console.WriteLine("\n ### calling the array ###");
            Console.WriteLine(zahlen); //


            // ===========================================================
            Console.WriteLine("\n ### calling one element in the array ###");
            Console.WriteLine("kommazahlen[2]: {0}", kommazahlen[2]); // 0 - ist Default bei Value Type
            string[] stringArray = new string[3];
            Console.WriteLine("stringArray[1]: {0}", stringArray[1]); // null - ist Default bei Reference Type
            Console.WriteLine("null wird nicht angezeigt");
            // Console.WriteLine("stringArray[1]: {0}, stringArray[1].ToString()); // mit null darf man nicht arbeiten



            Console.WriteLine("# ITERATING ARRAYS #");
            // ===========================================================
            Console.WriteLine("\n ### for loop ###");
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }


            // ===========================================================
            Console.WriteLine("\n ### while loop ###");
            // while(Bedingung)
            // Anweisung
            int j = 0;
            while(j < zahlen.Length)
            {
                Console.WriteLine(zahlen[j]);
                j++;
            }


            // ===========================================================
            Console.WriteLine("\n ### foreach iterator ###");
            foreach (var item in doubleArray)
            {
                Console.WriteLine(item);
                // item++ ist schlecht
                // !!! die foreach Variable darf nicht zum Zwischenspeichern von unseren Werten gebraucht werden
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
