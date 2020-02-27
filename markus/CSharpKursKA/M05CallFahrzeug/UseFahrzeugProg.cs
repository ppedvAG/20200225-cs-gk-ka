using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M05Fahrzeuge;

namespace M05CallFahrzeug
{
    class UseFahrzeugProg
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Bitte Fahrzeugname eingeben: ");
            //string FName = Console.ReadLine();
            //Console.Write("Bitte MaxGeschwindigkeit eingeben: ");
            //int FMaxGeschw = int.Parse(Console.ReadLine());
            //Console.Write("Bitte Preis eingeben: ");
            //int FPreis = int.Parse(Console.ReadLine());
            //Console.Write("Bitte aktuelle Geschwindigkeit eingeben: ");
            //int FAktuellV = int.Parse(Console.ReadLine());
            //Console.Write("Bitte Anfangs-Zustand eingeben (\"Stehend=0, Fahrend=1\"): ");
            //int FZustand = int.Parse(Console.ReadLine());
            //Fahrzeug fahrzeug = new Fahrzeug(FName, FMaxGeschw, FPreis, FAktuellV, FZustand);
            FahrzeugLib fahrzeug = new FahrzeugLib("BMW", 200, 20000);
            FahrzeugLib flugzeug = new Flugzeug("Boeing",900,9500000,3);
            FahrzeugLib pkw = new PKW("Audi",250,35000,5);
            FahrzeugLib schiff = new Schiff("Titanic",60,2500000,true);

            //Console.WriteLine($"Name: {fahrzeug.Name}");
            //Console.WriteLine($"Max Geschw: {fahrzeug.MaxGeschwindigkeit}");
            //Console.WriteLine($"Preis: {fahrzeug.Preis}");
            //Console.WriteLine($"Aktuelle Geschw: {fahrzeug.AktuelleGeschwindigkeit}");
            //Console.WriteLine($"Zustand: {fahrzeug.Zustand}");

            Console.WriteLine(fahrzeug.BeschreibeMich());
            Console.WriteLine("\n###########################");
            Console.WriteLine(flugzeug.BeschreibeMich());
            Console.WriteLine("\n###########################");
            Console.WriteLine(pkw.BeschreibeMich());
            Console.WriteLine("\n###########################");
            Console.WriteLine(schiff.BeschreibeMich());

            Console.WriteLine();
            Console.WriteLine("\n###########################");

            bool beenden = true;
            do
            {


                Console.WriteLine();
                Console.WriteLine("Was soll mit dem Fahrzeug passieren?");
                Console.WriteLine("1 = Motor stoppen");
                Console.WriteLine("2 = Motor starten");
                Console.WriteLine("3 = Beschleunigen");
                Console.WriteLine("4 = Habe fertig");
                int Antwort = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (Antwort)
                {
                    case 1:
                        fahrzeug.StoppeMotor();
                        Console.WriteLine($"Aktueller Zustand: {fahrzeug.Zustand}");
                        break;
                    case 2:
                        fahrzeug.StarteMotor();
                        Console.WriteLine($"Aktueller Zustand: {fahrzeug.Zustand}");
                        break;
                    case 3:
                        fahrzeug.Beschleunigen();
                        Console.WriteLine($"Aktuelle Geschw: {fahrzeug.AktuelleGeschwindigkeit} km/h");
                        break;
                    case 4:
                        beenden = false;
                        break;
                }

            } while (beenden);
        }
    }
}
