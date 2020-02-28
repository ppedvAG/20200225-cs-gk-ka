using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLibrary; // Manuell hinzugefügt


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

            

            MyClassWProps myclasswprops = new DLibrary.MyClassWProps("Jan","Ehmann");
            Console.WriteLine($"{myclasswprops.Firstname} {myclasswprops.Lastname}");


            //========================================
            Console.WriteLine("\n ### INHERITANCE ###");

            Random myRandom = new Random();
            Console.WriteLine($"Rückgabe von myRandom.Next( 2, 3): {myRandom.Next(2, 3)}");


            MyClassWInheritance myClassWInheritance = new MyClassWInheritance();
            Console.WriteLine($"Rückgabe von myClassWInheritance.NextMaxInclusive( 2, 3): {myClassWInheritance.NextMaxInclusive(2, 3)}");


            MyClWInhNCtor myClWInhNCtor = new MyClWInhNCtor("Kevin-Pascal", "Müller", "Dingenskirchen, Dingenstraße 0");
            Console.WriteLine($"Die Person heißt {myClWInhNCtor.Firstname} {myClWInhNCtor.Lastname} und wohnt in {myClWInhNCtor.Wohnort}");
            Console.WriteLine($"myClWInhNCtor.BeschreibeMich(): {myClWInhNCtor.BeschreibeMich()}");


            Console.ReadKey();

        }
    }
}
