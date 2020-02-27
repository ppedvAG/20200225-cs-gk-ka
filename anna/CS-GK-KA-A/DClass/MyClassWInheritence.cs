using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{

    // die Methode Random.Next() wollen wir erben und anpassen
    public class MyClassWInheritence : Random 
    {
        public int NextInclusive(int min, int max) {

            return base.Next(min, max);
                }


    }
}
