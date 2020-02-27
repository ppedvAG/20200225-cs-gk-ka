using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class PKW : FahrzeugLib
    {
        public int AnzahlRäder { get; set; }

        public PKW(string strName, int MaxV, int iPreis, int AktuellV, int anzahlRäder) : base(strName,MaxV,iPreis,AktuellV)
        {
            AnzahlRäder = anzahlRäder;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nAnzahl Räder: {AnzahlRäder}";
        }
    }
}
