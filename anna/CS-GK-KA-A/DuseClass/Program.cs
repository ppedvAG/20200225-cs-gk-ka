using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DClass; 

namespace DuseClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass(); // Obwohl wir keinen Konstruktor defininert hatten
            myclass.SetFields("blabla", 43);
            string str = myclass.GetFields();
            Console.WriteLine($"str: {str}, ");
            MyClassWProps myclasswprops = new MyClassWProps("Max", "Mustermann");

            Console.WriteLine($"{myclasswprops.Firstname} {myclasswprops.Lastname}");
            Console.ReadKey();
            
        }
    }
}

