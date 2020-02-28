using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFahrzeug
{
    public interface IBeladbar
    {
        // kein private in Interfaces (keine Modifizierer)
        MyFahrzeugClass Ladung { get; set; }
        void Belade(MyFahrzeugClass fz);
        void Entlade();
    }
}
