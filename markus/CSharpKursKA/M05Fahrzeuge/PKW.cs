using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class PKW : FahrzeugLib,IRollbar
    {
        public int AnzahlRäder { get; set; }
        public int AnzahlTüren { get; set; }
        public void Crash()
        {
            Console.WriteLine("Du hast einen Baum übersehen.");
            this.AnzahlRäder--;
        }

        public PKW(string strName, int MaxV, int iPreis, int anzahlTüren) : base(strName,MaxV,iPreis)
        {
            AnzahlRäder = 4;
            AnzahlTüren = anzahlTüren;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nAnzahl Räder: {AnzahlRäder}";
        }

    }
}
