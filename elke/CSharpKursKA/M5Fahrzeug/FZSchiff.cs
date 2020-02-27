using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class FZSchiff : M5FahrzeugClass, IBeladbar
    {
        public string SchiffArt { get; set; }
        public int Beladbar { get; set; }


        public M5FahrzeugClass Ladung { get; set; }

        public FZSchiff(string Name, int MaxG, int Preis, int AktG, string Zustand, string schiffart) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            SchiffArt = schiffart;
            this.Beladbar = 0;

        }
        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für Schiff: SchiffArt = {SchiffArt}";
        }

        public void Belade (M5FahrzeugClass fz) 
        {
            if (this.Ladung == null)
            {
                this.Ladung = fz;
                Console.WriteLine($"Ladung erfolgreich. {fz.sName} durch {this.Ladung.sName}");
            }
            else
            {
                Console.WriteLine($"Ladung fehlgeschlagen. {this.sName} / {this.Ladung.sName}");

            }
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladung erfolgreich. {this.Ladung.sName}");

            }
            else
            {
                Console.WriteLine($"Entladung nicht erfolgreich. {this.Ladung.sName}");

            }
        }
    }
}
