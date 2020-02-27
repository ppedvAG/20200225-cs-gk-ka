using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class Schiff : Fahrzeug, IBeladbar
    {

        public Fahrzeug Ladung { get; set; }

        public enum SchiffsTreibstoff { Diesel, Dampf, Wind, Muskelkraft };

        public SchiffsTreibstoff Treibstoff { get; set; }

        public Schiff(string name, int maxG, int preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)

        { this.Treibstoff = treibstoff; }


        public void Belade(Fahrzeug fz)
        {
            if (this.Ladung == null)
            {
                this.Ladung = fz;
                Console.WriteLine($"Ladevorgang von '{fz.Name}' auf '{this.Name}' erfolgreich");
            }
            else
            {
                Console.WriteLine($"Ladeplatz von '{this.Name}' bereits durch '{this.Ladung.Name}' erfolgreich");
            }
        }

        public string Land { get; set; }

        public Schiff(string name, int gm, int p, int ga, Zustand z, string land) : base(name, gm, p, ga, z)
        {
            Land = land;
        }

        public override string Beschreibemich()
        {
            return base.Beschreibemich() + $"Schiffprop Land: {Land}";
        }

    }
}
