using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKeyValuePair
{
    class DKeyValuePair
    {
        static void Main(string[] args)
        {
            #region M8

            Console.WriteLine("\t # DECLARING KEY VALUE PAIRS #");
            // ===========================================================
            Console.WriteLine("\n ### constructor KeyValuePair<T1, T2>(key, value) ###");
            KeyValuePair<string, string> MyKeyValuePair = new KeyValuePair<string, string>("str1", "str2");


            Console.WriteLine("\n\n\t # USING KEY VALUE PAIRS #");
            // ===========================================================
            Console.WriteLine("\n ### value of keyvaluepair identifier ###");
            Console.WriteLine($"MyKeyValuePair: {MyKeyValuePair}");


            // ===========================================================
            Console.WriteLine("\n ### difference with an array ###");
            string[] testArr = new string[] { "str1", "str2" };
            Console.WriteLine($"testArr: {testArr}");


            // ===========================================================
            Console.WriteLine("\n ### MyKeyValuePair.Key ###");
            Console.WriteLine($"MyKeyValuePair.Key: {MyKeyValuePair.Key}");


            // ===========================================================
            Console.WriteLine("\n ### MyKeyValuePair.Value ###");
            Console.WriteLine($"MyKeyValuePair.Value: {MyKeyValuePair.Value}");

            #endregion M8

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
            #endregion MORE FANCY STUFF

            Console.ReadKey();
        }
    }
}
