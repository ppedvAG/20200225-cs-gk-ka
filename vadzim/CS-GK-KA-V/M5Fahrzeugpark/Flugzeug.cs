using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    public class Flugzeug : Fahrzeug, IRollbar, IEnumerable 
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRäder { get; set; }

        // Array<string> test = new Array<string>();

        public List<string> Passagierliste { get; set; }

        // damit können wir die Klasse iterierbar machen
        // Durch Iterieren, angewendet an der Klasse selbst, wollen wir hier die Einträge aus der Liste ausgeben
        public string this[int i]
        {
            get { return Passagierliste[i];  }
            set { Passagierliste[i] = value; }
        }

        public Flugzeug(string name, int maxG, int preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRäder = 10;
            Passagierliste = new List<string>() { "Anna", "Kevin-Pascal", "Hannes" };
        }
        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;
        }

        // durch IEnumerable verlangte Methode
        // bei myFlugzeug[i] automatisch aufgerufene Methode
        // wir wollen die Namen aus der Liste ausgeben
        public IEnumerator GetEnumerator()
        {
            // return ((IEnumerable)Passagierliste).GetEnumerator();
            foreach (var item in Passagierliste)
            { //Rendite, Ertrag 
                // Mittels yield - kann in jedem Durchlauf der Schleife ein Wert zurückgegeben werden,
                // ohne dass die Methode danach abgebrochen wird
                yield return item;
            }
        }
    }
}
