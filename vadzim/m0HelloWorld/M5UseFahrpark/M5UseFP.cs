using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fahrzeugpark;

namespace M5UseFahrpark
{
    class M5UseFP
    {
        static void Main(string[] args)
        {
            Fahrzeug auto1 = new Fahrzeug("Opel Astra", 30000, 200);
            Console.WriteLine(auto1.BeschreibeMich());
            auto1.StarteMotor();
            auto1.StarteMotor();
            auto1.StarteMotor();
            Console.WriteLine(auto1.BeschreibeMich());
            auto1.Parke();
            Console.WriteLine(auto1.BeschreibeMich());
            auto1.StarteMotor();
            auto1.StarteMotor();
            Console.WriteLine(auto1.BeschreibeMich());
            Console.ReadKey();
        }
    }
}
