using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public class Flugzeug : Fahrzeug, IRollbar, IEnumerable
    {

        public string Land { get; set; }


        public int MaxFlugHöhe { get; set; }

        public int AnzahlRäder { get; set; }

        public List<string> Passagierliste { get; set; }

        //damit können wir die Klasse iterierbar machen 
        public string this[int i] { 
        get { return Passagierliste[i];  }
            set { Passagierliste[i] = value;  }
        }


        public Flugzeug(string name, int gm, int p, int ga, Zustand z, string land, int maxFH, int maxG) : base(name, gm, p, ga, z, maxG)
        {
            Land = land;


            this.MaxFlugHöhe = maxFH;
            this.AnzahlRäder = 10; 
            Passagierliste = new List<string>() { "Anna", "Kevin", "Hannes" };


        }


        public void Crash()

        {
            Console.WriteLine("Da war ein Vogel im Weg");
            this.AnzahlRäder -= 2;


            


        }
        public override string Beschreibemich()
        {
            return base.Beschreibemich() + $"Flugzeugprop Land: {Land}";
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Passagierliste)
            ///  return ((IEnumerable)Passagierliste).GetEnumerator();

            {
                //Renditte, Ertag
                //Mittels yield - kann in jedem Durchlauf der Scheife ein Wert zurückgegeben werden,
                //ohne dass die Methode danach abgebrochen wird 

                yield return item; 

            }
           
        }
    }
}
