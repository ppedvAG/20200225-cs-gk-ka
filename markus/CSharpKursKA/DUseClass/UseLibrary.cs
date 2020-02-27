using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DClass;

namespace DUseClass
{
    class UseLibrary
    {
        static void Main(string[] args)
        {
            MyClass newclass = new MyClass();
            newclass.SetFields("blabla",456);

            string str = newclass.GetFields();
            Console.WriteLine($"str: {str}"); // 0 und nicht NULL wegen myField2 = int

            MyClassWProps myclasswprops = new DClass.MyClassWProps("Max","Mustermann");
            Console.WriteLine($"Mein Name ist: {myclasswprops.Firstname} {myclasswprops.Lastname}");
            Console.ReadKey();
        }
    }
}
