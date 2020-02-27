using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyFancyClassNr2 : IMyInterface
    {
        // int IMyInterface.FancyLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
 
        // int IMyInterface.FancyLevel { get => this.FancyLevel; set => ChangeFancyLevel = ; }

        public int ChangeFancyLevel(int fl, int FancyLevel)
        {
            FancyLevel = fl;
            // throw new NotImplementedException();
            return FancyLevel;
        }

        public string SayHalloInYourWay()
        {
            return "FancyHalloFromClassNr2";
            // throw new NotImplementedException();
        }
    }
}
