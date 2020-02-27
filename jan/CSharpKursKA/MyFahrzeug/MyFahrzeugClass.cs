using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrzeug
{
    public class MyFahrzeugClass
    {
        // properties
        public string Name { get; set; }
        public int MaximalGeschwindigkeit { get; set; }
        public int Preis { get; set; }
        public int AktuelleGeschwindigkeit { get; set; }
        public string Zustand { get; set; }
        

        // constructor
        public MyFahrzeugClass(string Nm, int MG, int Pr, int AG, string Zs)
        {
            this.Name = Nm;
            this.MaximalGeschwindigkeit = MG;
            this.Preis = Pr;
            this.AktuelleGeschwindigkeit = AG;
            this.Zustand = Zs;
        }

        // methoden
        public int Beschleunige(int wert1)
        {
            if((AktuelleGeschwindigkeit + wert1) < MaximalGeschwindigkeit)
            {
                AktuelleGeschwindigkeit += wert1;
            }
            return AktuelleGeschwindigkeit;
        }

        public string StarteMotor()
        {
            Zustand = "fahrend";
            return Zustand;
        }

        public string StoppeMotor()
        {
            Zustand = "stehend";
            return Zustand;
        }

        public string BeschreibeMich()
        {
            return $"Das Fahrzeug ist ein {Name}, die Maximalgeschwindigkeit ist {MaximalGeschwindigkeit}, " +
                $"der Preis ist {Preis}, die aktuelle Geschwindigkeit ist {AktuelleGeschwindigkeit}, der aktuelle Zustand ist {Zustand}";
        }

    }
}
