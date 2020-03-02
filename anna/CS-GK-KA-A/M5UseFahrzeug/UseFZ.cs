using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fahrzeug;


namespace M5UseFahrzeug
{
    class UseFZ
    {
        static void Main(string[] args)
        {
            Fahrzeug myBMW = new Fahrzeug("BMW", 200, 500000, 100, Fahrzeug.Zustand.Stehend);
            Console.WriteLine($"{myBMW.Name}");
            int geschw = myBMW.Beschleunige(50);

            Console.WriteLine($"{geschw}");

            myBMW.Startemotor();

            Console.WriteLine($"myBMW.Beschreibemich(): {myBMW.Beschreibemich()}");

            myBMW.Stoppemotor();

            Console.WriteLine($"myBMW.Beschreibemich(): {myBMW.Beschreibemich()}");

            Flugzeug myBoeing = new Flugzeug("Boeing", 1000, 50000, 500, Fahrzeug.Zustand.Fahrend, "USA");
            Console.WriteLine($"myBoeing.Beschreibemich(): {myBoeing.Beschreibemich()}");

            Schiff Titanik = new Schiff("Titanik", 5000, 100000, 500, Fahrzeug.Zustand.Fahrend, "USA");
            Console.WriteLine($"Titanik.Beschreibemich(): {Titanik.Beschreibemich()}");


            PKW Opel = new PKW("Opel", 200, 10000, 500, Fahrzeug.Zustand.Fahrend, "Germany");
            Console.WriteLine($"Opel.Beschreibemich(): {Opel.Beschreibemich()}");

            Flugzeug flieger1 = new Flugzeug("Boeing", 800, 3000000, 500, Fahrzeug.Zustand.Stehend, "USA", 9000, 800);

            foreach(var item in flieger1)
            {
                Console.WriteLine($"item:{item}");
            }
            string testeArrayÄhnlichkeit = flieger1[2];
            Console.WriteLine($"testeArrayÄhnlichkeit:{testeArrayÄhnlichkeit}");



            Console.ReadKey();   
        }
    }
}
