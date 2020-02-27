using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrzeug
{
    public class Schiff : MyFahrzeugClass, IBeladbar
    {
        public int Ladefläche { get; set; }
        public MyFahrzeugClass Ladung { get; set; }

        public Schiff(string Nm, int MG, int Pr, int AG, string Zs, int ladefläche) : base(Nm, MG, Pr, AG, Zs)
        {
            this.Ladefläche = ladefläche;
        }

        public override string BeschreibeMich()
        {
            return base.BeschreibeMich() + $" und das Schiff hat {Ladefläche} m^2 Ladefläche";
        }

        public void Belade(MyFahrzeugClass fz)
        {
            if (this.Ladung == null)
            {
                this.Ladung = fz;
                Console.WriteLine($"Ladevorgang von '{fz.Name}' auf '{this.Name}' erfolgreich.");
            } else
            {
                Console.WriteLine($"Ladeplatz auf '{this.Name}' bereits durch '{this.Ladung.Name}' belegt.");
            }
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"Entladungsvorgang von '{this.Ladung.Name}' erfolgreich.");
                this.Ladung = null;
            }
            else
            {
                Console.WriteLine($"'{this.Name}' hat keine Ladung geladen.");
            }
        }
    }
}
