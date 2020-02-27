using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeug
{
    public interface IBeladbar
    {
        //in Interfaces sind keine Zugriffsmodifizierer erlaubt z.B. private set / protected
        M5FahrzeugClass Ladung { get; set; }

        void Belade(M5FahrzeugClass fz);

        void Entlade();

    }
}
