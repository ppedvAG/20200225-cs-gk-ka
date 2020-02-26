using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DClass; // wurde zuerst über referenzen eingebunden, das using muss manuell gemacht werden

namespace DUseClass
{
    class DUseClass
    {
        static void Main(string[] args)
        {
            TestClass1 myClass = new TestClass1();
            //Werte Füllen
            myClass.SetFields("Hello World ", 22) ;

            //Werte Lesen
            string str = myClass.sGetFields();
            Console.WriteLine($"str: {str} ist ein string? {str is string}");//Ergebnis 0 da str + integer

            TestClassProperties myClassProperties = new DClass.TestClassProperties("Max", "Mustermann");
            Console.WriteLine($"Inhalt der Properties FirstName {myClassProperties.FirstName} and LastName {myClassProperties.LastName}");
            

            Console.ReadKey();
        }
    }
}
