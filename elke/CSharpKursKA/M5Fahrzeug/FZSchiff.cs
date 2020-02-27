using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class FZSchiff : M5FahrzeugClass
    {
        public string SchiffArt { get; set; }

        public FZSchiff(string Name, int MaxG, int Preis, int AktG, string Zustand, string schiffart) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            SchiffArt = schiffart;
        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für Schiff: SchiffArt = {SchiffArt}";
        }

    }
}
