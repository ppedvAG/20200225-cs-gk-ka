using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{

    public class FZPkw : M5FahrzeugClass, IRollbar
    {
        public int AnzahlTüren{ get; set; }

        public int AnzahlRäder { get; set; }

        public FZPkw(string Name, int MaxG, int Preis, int AktG, string Zustand, int anzahltüren) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            this.AnzahlTüren = anzahltüren;
            //Da nicht im Konstruktor -> fest vorgeben
            this.AnzahlRäder = 4;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für PKE: AnzahlTüren = {AnzahlTüren}";
        }

        public void Crash()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Du hat einen Baum übersehen.");
            //this.AnzahlRäder = this.AnzahlRäder - 1;
            this.AnzahlRäder--;//Räder werden um 1 verringert

        }
    }
}
