using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyFancyClass : IMyInterface
    {
        public int FancyLevelLimit { get; set; }
        public int FancyLevel { get; set; }
        int IMyInterface.FancyLevel { get; set; }

        int IMyInterface.ChangeFancyLevel(int fl)
        {
            FancyLevel = fl;
            return FancyLevel;
            //throw new NotImplementedException();
        }

        string IMyInterface.SayHelloInYourWay()
        {
            return "FancyHalloFromClassNr2";
            //throw new NotImplementedException();
        }
    }
}
