using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05Fahrzeuge
{
    public class Flugzeug : FahrzeugLib, IRollbar, IEnumerable
    {
        public int AnzahlTriebwerke { get; set; }
        public int AnzahlRäder { get; set; }

        public List<string> PassagierListe { get; set; }

        // Damit können wir die Klasse iterierbar machen
        public string this[int i]
        {
            get
            {
                return PassagierListe[i];
            }
            set
            {
                PassagierListe[i] = value;
            }
        }

        public Flugzeug(string strName, int MaxV, int iPreis, int anzahlTriebwerke) : base(strName, MaxV, iPreis)
        {
            AnzahlTriebwerke = anzahlTriebwerke;
            this.AnzahlRäder = 10;
            PassagierListe = new List<string>() { "Anna", "Kevin-Pascal", "Hannes" };
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
        // Durch IEnumerable verlangte Methode
        public IEnumerator GetEnumerator()
        {
            foreach (var item in PassagierListe)
            {
                // return ((IEnumerable)PassagierListe).GetEnumerator();
                // Rendite, Ertrag
                // Mittels yield - kann in jedem Durchlauf der Schleife ein Wert zurückgegeben werden,
                // ohne dass die Methode danach abgebrochen wird.
                yield return item;
            }
        }
    }
}
