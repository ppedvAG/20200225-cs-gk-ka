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

            Console.WriteLine(myBMW.Beschreibemich());

            myBMW.Stoppemotor();

            Console.WriteLine(myBMW.Beschreibemich());

            Console.ReadKey();
        }
    }
}
