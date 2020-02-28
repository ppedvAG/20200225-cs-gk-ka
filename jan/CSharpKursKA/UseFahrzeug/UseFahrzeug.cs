using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFahrzeug; //Manuell

namespace UseFahrzeug
{
    class UseFahrzeug
    {
        static void Main(string[] args)
        {
            MyFahrzeugClass myFahrzeug = new MyFahrzeugClass("Fahrzeug", 100, 1000, 0, "stehend");

            myFahrzeug.StarteMotor();
            myFahrzeug.Beschleunige(150);
            myFahrzeug.Beschleunige(70);

            string Satz = myFahrzeug.BeschreibeMich();
            Console.WriteLine(Satz);


            PKW pkw = new PKW("BMW", 200, 1000000, 0, "stehend", 3);
            Console.WriteLine(pkw.BeschreibeMich());

            Schiff schiff = new Schiff("Titanic", 30, 1000000000, 0, "stehend", 100);
            Console.WriteLine(schiff.BeschreibeMich());

            
            
            Flugzeug flieger1 = new Flugzeug("Boeing", 1000, 10000000, 0, "stehend", 10000);
            // Console.WriteLine(flugzeug.BeschreibeMich());

            // Verwendung von IEnumerable
            foreach (var item in flieger1)
            {
                Console.WriteLine($"item: {item}");
            }

            string testeArrayÄhnlichkeit = flieger1[2];
            Console.WriteLine($"testeArrayÄhnlichkeit: {testeArrayÄhnlichkeit}");


            Console.ReadKey();
        }
    }
}
