using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class Schiff : FahrzeugLib
    {
        public bool KannSchwimmen { get; set; }
        public Schiff(string strName, int MaxV, int iPreis, int AktuellV,bool kannSchwimmen) : base(strName, MaxV, iPreis, AktuellV)
        {
            KannSchwimmen = kannSchwimmen;
        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nKann Schwimmen: {KannSchwimmen}";
        }
    }
}
