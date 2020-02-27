using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    //Konvention Interfaces immer mit I beginnende
    public interface IMyInterface
    {
        int FancyLevel { get; set; }

        int ChangeFancyLevel(int fl);

        string SayHelloInYourWay();


    }
}
