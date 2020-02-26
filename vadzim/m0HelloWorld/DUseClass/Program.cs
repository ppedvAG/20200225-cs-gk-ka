using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DClass;

namespace DUseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass(); // obwohl wir keinen Konstruktor definiert hatten
            myclass.SetFields("blabla", 43);

            string str = myclass.GetFields();

            Console.WriteLine($"str: {str}, is str ein string {str is string}"); // 0 als string            

            MyClassWProps myclasswprops = new MyClassWProps("Max","Mustermann");
            Console.WriteLine($"{myclasswprops.Firstname} {myclasswprops.Lastname}");

            Console.ReadKey();
        }
    }
}
