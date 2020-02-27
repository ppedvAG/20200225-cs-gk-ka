using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    public class Fahrzeug
    {
        //Datentypen und Konstanten
        public enum FahrzeugZustand { Fahrend, Stehend }

        //Eigenschaften und Felder
        public string Name { get; private set; }
        public int Preis { get; set; }
        public int MaximalGeschwindigkeit { get; private set; }
        private int aktuelleGeschwindigkeit;
        public int AktuelleGeschwindigkeit
        {
            get { return aktuelleGeschwindigkeit; }
            private set
            {
                if (value <= this.MaximalGeschwindigkeit)
                {
                    aktuelleGeschwindigkeit = value;
                }
            }
        }
        public FahrzeugZustand Zustand { get; set; }

        //Konstruktoren
        public Fahrzeug(string name, int preis, int maximalGeschwindigkeit)
        {
            this.Name = name;
            this.Preis = preis;
            this.MaximalGeschwindigkeit = maximalGeschwindigkeit;
            this.Zustand = FahrzeugZustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        //Methoden
        public void StarteMotor()
        {
            if (Zustand == FahrzeugZustand.Fahrend)
            {
                this.AktuelleGeschwindigkeit += 5;
            }
        }

        public void StoppeMotor()
        {
            this.Zustand = FahrzeugZustand.Fahrend;
        }

        public void Parke()
        {
            this.Zustand = FahrzeugZustand.Stehend;
            this.AktuelleGeschwindigkeit = 0;
        }

        public string BeschreibeMich()
        {
            return $"{Name} ({Preis} Euro): Maximale Geschwindigkeit: {MaximalGeschwindigkeit} km/h | Zustand: {Zustand}| Mom. Geschwindigkeit: {AktuelleGeschwindigkeit}";
        }
    }
}
