using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DClass; // Manuell hinzugefügt


namespace DUseClass
{
    class UseClass
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.SetFields("blabla", 43);
            
            string str = myclass.GetFields();

            Console.WriteLine($"str: {str}"); // 0

            

            MyClassWProps myclasswprops = new DClass.MyClassWProps("Jan","Ehmann");
            Console.WriteLine($"{myclasswprops.Firstname} {myclasswprops.Lastname}");


            Console.ReadKey();

        }
    }
}
