using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class Flugzeug : FahrzeugLib,IRollbar
    {
        public int AnzahlTriebwerke { get; set; }
        public int AnzahlRäder { get ; set ; }

        public Flugzeug(string strName, int MaxV, int iPreis, int anzahlTriebwerke) : base(strName, MaxV, iPreis)
        {
            AnzahlTriebwerke = anzahlTriebwerke;
            this.AnzahlRäder = 10;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nAnzahl Triebwerke: {AnzahlTriebwerke}";
        }

        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg.");
            this.AnzahlTriebwerke--;
        }
    }
}
