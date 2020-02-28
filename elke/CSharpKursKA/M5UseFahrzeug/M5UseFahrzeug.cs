using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fahrzeug;

namespace M5UseFahrzeug
{
    class M5UseFahrzeug
    {
        static void Main(string[] args)
        {
            M5FahrzeugClass myFahrzeug = new M5FahrzeugClass("Fahrzeug1",150,500,100,"stehend");

            Console.WriteLine($"Name: {myFahrzeug.sName}");
            Console.WriteLine($"MaxGesch: {myFahrzeug.iMaxGeschwindigkeit}");
            Console.WriteLine($"Preis: {myFahrzeug.iPreis}");
            Console.WriteLine($"aktuelle Geschwindigkeit: {myFahrzeug.iaktGeschwindigkeit}");
            Console.WriteLine($"Zustand: {myFahrzeug.sZustand}");

            myFahrzeug.StarteMotor();
            Console.WriteLine($"Zustand: {myFahrzeug.sZustand}");

            myFahrzeug.StoppeMotor();
            Console.WriteLine($"Zustand: {myFahrzeug.sZustand}");

            //Console.Write("Bitte geben Sie eine Beschleunigung ein: ");
            //int newkmh = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Beschleunigung: {newkmh} neue Geschwindigkeit: { myFahrzeug.Beschleunigung(newkmh)}");

            FZFlugzeug myFZFlugzeug = new FZFlugzeug("Flugzeug1", 150, 500, 100, "stehend", "Boing");
            

            
            Console.WriteLine($"Flugzeug: {myFZFlugzeug.BeschreibeMich()}");
            foreach (var item in myFZFlugzeug.Passagierliste)
            {
                Console.WriteLine($"Eintrag: {item}");
            }

            FZPkw myFZPkw  = new FZPkw("PKW1", 150, 500, 100, "stehend", 6);
            Console.WriteLine($"PKW: {myFZPkw.BeschreibeMich()}");

            FZSchiff myFZSchiff = new FZSchiff("PKW1", 150, 500, 100, "stehend", "Kreuzer");
            Console.WriteLine($"Schiff: {myFZSchiff.BeschreibeMich()}");


            Console.ReadKey();

        }
    }
}
