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
            Fahrzeug fahrzeug = new Fahrzeug("BMW", 200, 20000, 0, 0);

            Console.WriteLine($"Name: {fahrzeug.Name}");
            Console.WriteLine($"Max Geschw: {fahrzeug.MaxGeschwindigkeit}");
            Console.WriteLine($"Preis: {fahrzeug.Preis}");
            Console.WriteLine($"Aktuelle Geschw: {fahrzeug.AktuelleGeschwindigkeit}");
            Console.WriteLine($"Zustand: {fahrzeug.Zustand}");

            Console.WriteLine();
            Console.WriteLine("###########################");
            Console.WriteLine();


            Console.WriteLine("Was soll mit dem Fahrzeug passieren?");
            Console.WriteLine("1 = Motor stoppen");
            Console.WriteLine("2 = Motor starten");
            Console.WriteLine("3 = Beschleunigen");
            int Antwort = int.Parse(Console.ReadLine());

            switch (Antwort)
            {
                case 1 :
                    fahrzeug.StoppeMotor();
                    Console.WriteLine($"Aktueller Zustand: {fahrzeug.Zustand}");
                    break;
                case 2:
                    fahrzeug.StarteMotor();
                    Console.WriteLine($"Aktueller Zustand: {fahrzeug.Zustand}");
                    break;
                case 3:
                    fahrzeug.Beschleunigen();
                    Console.WriteLine($"Aktuelle Geschw: {fahrzeug.AktuelleGeschwindigkeit}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
