using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{

    public class PKW : Fahrzeug, IRollbar
    {


        public int AnzahlTüren { get; set; }
        public int AnzahlRäder { get; set; }



        public string Land { get; set; }

        public PKW(string name, int gm, int p, int ga, Zustand z, string land, int anzTüren) : base(name, gm, p, ga, z)
        {
            Land = land;
            this.AnzahlTüren = anzTüren;
            this.AnzahlRäder = 4;
        }


        public void Crash()

        { Console.WriteLine("Du hast einen Baum übersehen");
            this.AnzahlRäder--;
        }

        public override string Beschreibemich()
        {
            return base.Beschreibemich() + $"PKWprop Land: {Land}";
        }

    }
}
