using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DArrayFr
{
    class Program
    {
        static void Main(string[] args)
        {
            #region GK

            //=======================================
            Console.WriteLine("\n ## Declaring Arrays ##");

            // ==========================
            Console.WriteLine("\n ## array w. constructor and litteral ##");

            int[] zahlen = new int[] { 4, 6, 8 };


            // ==========================
            Console.WriteLine("\n ## array w. constructor ##");

            double[] kommazahlen = new double[5];


            // ==========================
            Console.WriteLine("\n ## array w. literal ##");

            double[] doubleArray = { 3.6, 2.8, 6.3 };


            Console.WriteLine("\n ## Calling Arrays ##");
            // ==========================
            Console.WriteLine("\n ##  calling the array ##");
            Console.WriteLine(zahlen); //

            Console.WriteLine("\n ##  calling one element in the array ##");
            Console.WriteLine("kommazahlen[2]: {0}", kommazahlen[2]);// 0 - ist default bei Value Type
            string[] stringArray = new string[3];
            Console.WriteLine("StringArray[1]:{0}", stringArray[1]); // null - ist Default bei Reference Type
            Console.WriteLine("null wird nicht gezeigt");
            //Console.WriteLine("stringArray[1]: {0}", stringArray[1].ToString[]]; // mit null darf man nicht arbeiten

            Console.WriteLine("# Iterating Arrays #");

            Console.WriteLine("\n ### for loop ###");

            for (int i = 0; i < zahlen.Length; i++) // um 1 erhöhen
            {

                Console.WriteLine(zahlen[i]);

            }



            int a = 0;

            while (a < zahlen.Length)
            {
                Console.WriteLine(zahlen[a]);
                a = a + 1;
            }



            foreach (var item in doubleArray)
            {

                Console.WriteLine(item);
                //item ++ ist 
                //!!! die foreach Variable darf nicht zum Zwischenspeichern von unseren Werten gebraucht werden - schlecht
            }

            #endregion 
        }
    }
}
