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
            newclass.SetFields("blabla", 456);

            string str = newclass.GetFields();
            Console.WriteLine($"str: {str}"); // 0 und nicht NULL wegen myField2 = int

            MyClassWProps myclasswprops = new DClass.MyClassWProps("Max", "Mustermann");
            Console.WriteLine($"Mein Name ist: {myclasswprops.Firstname} {myclasswprops.Lastname}");

            //========================================
            Console.WriteLine("\n ### INHERITANCE ###");

            Random myRandom = new Random();
            Console.WriteLine($"Rückgabe von myRandom.Next(): {myRandom.Next(2, 3)}");

            MyClassWInheritance myClassWInheritance = new MyClassWInheritance();
            Console.WriteLine($"Rückgabe von myClassWInheritance.NextInclusive(): {myClassWInheritance.MaxInclusive(2, 3)}");

            //========================================
            Console.WriteLine("\n ### INHERITANCE & CONSTRUCTOR : BASE ###");
            MyClassWInhNCtor myClassWInhNCtor = new MyClassWInhNCtor("Kevin-Pascal", "Müller", "Köln, Musterstraße 0");
            Console.WriteLine($"Inhalt der myClassWInhNCtor: {myClassWInhNCtor.BeschreibeMich()}");

            Console.ReadKey();
        }
    }
}
