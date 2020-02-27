using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fahrzeugpark
{
    public interface IBeladbar
    {
        // kein private in Interfaces erlaubt (keine Modifizierer?)
        Fahrzeug Ladung { get; set; }
        void Belade(Fahrzeug fz);
        void Entlade();
    }
}
