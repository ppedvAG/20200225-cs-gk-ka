using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    // Die Methode Random.Next() wollen wir erben und anpassen
    public class MyClassWInheritance : Random
    { 
        public int MaxInclusive(int min, int max)
        {
            return base.Next(min, max + 1);
        }
    }
}
