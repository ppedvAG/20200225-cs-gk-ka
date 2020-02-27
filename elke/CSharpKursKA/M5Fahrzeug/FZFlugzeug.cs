using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class FZFlugzeug : M5FahrzeugClass, IRollbar, IEnumerable
    {
        public string Flugzeugtyp { get; set; }
        public int AnzahlRäder { get; set; }

        public List<string> Passagierliste { get; set; }

        //damit können wir die Klasse iterierbar machen (wie ein Array)
        public  string this[int i]
        {
            get { return Passagierliste[i]; }
            set { Passagierliste[i] = value; }
        }


        public FZFlugzeug(string Name, int MaxG, int Preis, int AktG, string Zustand, string flugzeugtyp) : base(Name, MaxG, Preis, AktG, Zustand)
        {
            this.Flugzeugtyp = flugzeugtyp;
            this.AnzahlRäder = 10;
            Passagierliste = new List<string>() { "Anna", "Kevin", "Hannes" };

        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" Zusatz für Flugzeug: Flugzeugtyp = {Flugzeugtyp}";
        }

        public void Crash()
        {
            Console.WriteLine("Du hat einen Vogel übersehen.");
            this.AnzahlRäder -= 2;//Räder werden um 2 verringert

        }
        //durch Ienumerable 
        public IEnumerator GetEnumerator()
        {
            //return ((IEnumerable)Passagierliste).GetEnumerator();
            foreach (var item in Passagierliste)
            {
                // yield = Rendite / Ertrag
                // Mittels yield  kann in jedem Durchlauf der Schleie ein Wert zurückgegeben werden,
                // ohne dass die Methode danach abgebrochen wird
                yield return item;
            }

        }
    }

}
