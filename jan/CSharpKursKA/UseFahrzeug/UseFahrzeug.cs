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
            MyFahrzeugClass myFahrzeug = new MyFahrzeugClass("BMW", 200, 1000000, 0, "stehend");

            myFahrzeug.StarteMotor();
            myFahrzeug.Beschleunige(150);
            myFahrzeug.Beschleunige(70);



            string Satz = myFahrzeug.BeschreibeMich();
            Console.WriteLine(Satz);

            Console.ReadKey();
        }
    }
}
