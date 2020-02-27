using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class Flugzeug : FahrzeugLib
    {
        public int AnzahlTriebwerke { get; set; }
        public Flugzeug(string strName, int MaxV, int iPreis, int AktuellV,int anzahlTriebwerke) : base(strName, MaxV, iPreis, AktuellV)
        {
            AnzahlTriebwerke = anzahlTriebwerke;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nAnzahl Triebwerke: {AnzahlTriebwerke}";
        }
    }
}
