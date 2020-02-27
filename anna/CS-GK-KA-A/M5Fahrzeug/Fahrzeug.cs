using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{

    public class Fahrzeug
    {

        public string Name { get; set; }
        public int Geschwindigkeit_max { get; set; }
        public int Preis { get; set; }
        public int Geschwindigkeit_akt { get; set; }
        public enum Zustand { Stehend, Fahrend };
        Zustand ZSD { get; set; }

        public Fahrzeug(string s, int gm, int p, int ga, Zustand z)
        {
            Name = s;

            Geschwindigkeit_max = gm;

            Preis = p;

            Geschwindigkeit_akt = ga;

            ZSD = z;
        }

       

        public int Beschleunige(int kmh)
        {
            int neueGeschw = Geschwindigkeit_akt + kmh;
            if (neueGeschw < Geschwindigkeit_max )
            {
                Geschwindigkeit_akt = neueGeschw;
            } else
            {
                Geschwindigkeit_akt = Geschwindigkeit_max;
            }
            return Geschwindigkeit_akt;
        }


        public Startemotor(){
            ZSD = Zustand.Fahrend;

        }

         public Stoppemotor(){
            ZSD = Zustand.Fahrend;

        }


        public string Beschreibemich (){
        
        return $" {Name}, {Geschwindigkeit_max}";
        }
    }

}

