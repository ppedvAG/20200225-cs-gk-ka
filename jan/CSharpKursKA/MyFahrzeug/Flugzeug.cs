using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrzeug
{
    public class Flugzeug : MyFahrzeugClass, IRollbar, IEnumerable
    {
        public int MaximalHöhe { get; set; }
        public int AnzahlRäder { get; set; }

        // Array<string> test = new Array<string>();
        public List<string> Passagierliste { get; set; }

        // damit können wir die Klasse iterierbar machen
        // Durch Iterieren, angewendet and der Klasse selbst, wollen wir hier die Einträge aus der Liste ausgeben
        public string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }

        public Flugzeug(string Nm, int MG, int Pr, int AG, string Zs, int maximalHöhe) : base(Nm, MG, Pr, AG, Zs)
        {
            this.MaximalHöhe = maximalHöhe;
            this.AnzahlRäder = 10;
            Passagierliste = new List<string>() { "Anna", "Kevin-Pascal", "Hannes" };
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" und das Flugzeug kann maximal {MaximalHöhe} m hoch fliegen.";
        }

        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;
        }

        // durch IEnumerable verlangte Methode
        // bei myFlugzeug[i] automatisch aufgerufene Methode
        public IEnumerator GetEnumerator()
        {
            // return ((IEnumerable)Passagierliste).GetEnumerator();
            foreach (var item in Passagierliste)
            { // Rendite, Ertrag
                // Mittels yield - kann in jedem Durchlauf der Schleife ein Wert zurückgegeben werden,
                // ohne dass die Methode danach abgebrochen wird
                yield return item;
            }
        }
    }
}
