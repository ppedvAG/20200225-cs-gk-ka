using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{

    public class FZPkw : M5FahrzeugClass
    {
        public int AnzahlTüren{ get; set; }

        public FZPkw(string Name, int MaxG, int Preis, int AktG, string Zustand, int anzahltüren) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            AnzahlTüren = anzahltüren;
        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für PKE: AnzahlTüren = {AnzahlTüren}";
        }


    }
}
