using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class Flugzeug : Fahrzeug, IRollbar
    {

        public string Land { get; set; }


        public int MaxFlugHöhe { get; set; }

        public int AnzahlRäder { get; set; }

        public Flugzeug(string name, int gm, int p, int ga, Zustand z, string land, int maxFH, int maxG) : base(name, gm, p, ga, z, maxG)
        {
            Land = land;


            this.MaxFlugHöhe = maxFH;
            this.AnzahlRäder = 10; 
        }


        public void Crash()

        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;


        }
        public override string Beschreibemich()
        {
            return base.Beschreibemich() + $"Flugzeugprop Land: {Land}";
        }



    }
}
