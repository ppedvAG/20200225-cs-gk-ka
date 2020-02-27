using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    public class Schiff : Fahrzeug, IBeladbar
    {
        public enum SchiffsTreibstoff { 
            Diesel, 
            Dampf, 
            Wind, 
            Muskelkraft 
        }
        public SchiffsTreibstoff Treibstoff { get; set; }
        public Fahrzeug Ladung { get; set; }
        public Schiff(string name, int maxG, int preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
        }
        public void Belade(Fahrzeug fz)
        {
            if (this.Ladung == null)
            {
                this.Ladung = fz;
                Console.WriteLine($"Ladevorgang von '{fz.Name}' auf '{this.Name}' erfolgreich.");
            }
            else
            {
                Console.WriteLine($"Ladeplatz auf  '{this.Name}' bereits durch '{this.Ladung.Name}' belegt.");
            }
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladevorgang von '{this.Ladung.Name}' erfolgreich.");
                this.Ladung = null;
            }
            else
            {
                Console.WriteLine($"'{this.Name}' hat keine Ladung geladen.");
            }
        }

    }
}
