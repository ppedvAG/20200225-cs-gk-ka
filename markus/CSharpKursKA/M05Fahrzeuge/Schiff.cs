using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class Schiff : FahrzeugLib, IBeladbar
    {
        public bool KannSchwimmen { get; set; }
        public FahrzeugLib Ladung { get; set; }

        public Schiff(string strName, int MaxV, int iPreis, bool kannSchwimmen) : base(strName, MaxV, iPreis)
        {
            KannSchwimmen = kannSchwimmen;
        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $"\nKann Schwimmen: {KannSchwimmen}";
        }

        public void Beladen(FahrzeugLib fz)
        {
            if (this.Ladung == null)
            {
                this.Ladung = fz;
                Console.WriteLine($"Ladevorgang von '{fz.Name}' auf '{this.Name}' erfolgreich.");
            }
            else
            {
                Console.WriteLine($"Ladeplatz auf '{this.Name}' bereits durch '{fz.Name}' belegt.");
            }
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladevorgang von '{this.Name}' erfolgreich.");
                this.Ladung = null;
            }
            else
            {
                Console.WriteLine($"'{this.Name}' hat keine Ladung geladen.");
            }
        }
    }
}
