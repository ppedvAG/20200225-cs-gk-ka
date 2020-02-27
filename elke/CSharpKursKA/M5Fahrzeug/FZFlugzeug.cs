using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class FZFlugzeug : M5FahrzeugClass, IRollbar
    {
        public string Flugzeugtyp { get; set; }
        public int AnzahlRäder { get; set; }

        public FZFlugzeug(string Name, int MaxG, int Preis, int AktG, string Zustand, string flugzeugtyp) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            this.Flugzeugtyp = flugzeugtyp;
            this.AnzahlRäder = 10;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für Flugzeug: Flugzeugtyp = {Flugzeugtyp}";
        }

        public void Crash()
        {
            Console.WriteLine("Du hat einen Vogel übersehen.");
            this.AnzahlRäder -= 2;//Räder werden um 2 verringert


        }
    }

}
