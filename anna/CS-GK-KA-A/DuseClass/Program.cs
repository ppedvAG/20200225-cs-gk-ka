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



            Random myRandom = new Random();
            myRandom.Next(2, 3);
            Console.WriteLine($"Rückgabe von myRandom.Next(2,5): {myRandom.Next(2, 3)}");

            MyClassWInheritence myClassWInheritence = new MyClassWInheritence();
            myClassWInheritence.NextInclusive(2, 3);
            Console.WriteLine($"Rückgabe von myClassWInheritence.NextInclusive(2,3): {myClassWInheritence.NextInclusive(2, 3)}");

            MyClWInhNCtor myClWInhNCtor = new MyClWInhNCtor("Kevin", "Müller", "Dingenskirchens, Zirkel 11");
            Console.WriteLine($"{myClWInhNCtor.BeschreibeMich()}");

          


            Console.ReadKey();
            




        }
    }
}

