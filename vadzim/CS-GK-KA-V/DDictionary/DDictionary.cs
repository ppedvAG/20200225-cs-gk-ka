using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDictionary
{
    class DDictionary
    {
        static void Main(string[] args)
        {
            #region M8

            Console.WriteLine("\n # DECLARING DICTIONARIES #");
            // ===========================================================
            Console.WriteLine("\n ### constructor Dictionary<T1, T2>() ###");
            Dictionary<string, string> StringStringDict = new Dictionary<string, string>();


            Console.WriteLine("\n # USING DICTIONARIES #");
            // ===========================================================
            Console.WriteLine("\n ### MyDictionary.Add() ###");
            StringStringDict.Add("key1String", "value1String");
            StringStringDict.Add("key2String", "value2String");
            StringStringDict.Add("key3String", "value3String");
            StringStringDict.Add("key4String", "value4String");
            Console.WriteLine("Our Dictionary after the last command(s):");
            foreach (var item in StringStringDict)
            {
                Console.WriteLine($"item: {item}");
            }
            foreach (var item in StringStringDict)
            {
                Console.WriteLine($"item.GetType(): {item.GetType()}");
            }
            // Siehe im Beispiel DKeyValuePair, wie man die einzelnen Schlüssel bzw. Werte ausgegeben bekommt

            // ===========================================================
            Console.WriteLine("\n ### test: adding wrong pair ###");
            // StringStringDict.Add(4, "value4String"); // gets underlined
            Console.WriteLine("not possible");


            // ===========================================================
            Console.WriteLine("\n ### index in dictionary ###");
            Console.WriteLine("StringStringDict[\"key3String\"]: {0}", StringStringDict["key3String"]);


            // ===========================================================
            Console.WriteLine("\n ### MyDictionary.ContainsKey() ###");
            Console.WriteLine("StringStringDict.ContainsKey(\"keyString\"): {0}, StringStringDict.ContainsKey(\"key2String\"): {1}", StringStringDict.ContainsKey("keyString"), StringStringDict.ContainsKey("key2String"));


            // ===========================================================
            Console.WriteLine("\n ### MyDictionary.ContainsValue() ###");
            Console.WriteLine("StringStringDict.ContainsValue(\"value2String\"): {0}, StringStringDict.ContainsKey(\"valueString\"): {1}", StringStringDict.ContainsValue("value2String"), StringStringDict.ContainsKey("valueString"));
            
            
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
            #endregion

            Console.ReadKey();
        }
    }
}
