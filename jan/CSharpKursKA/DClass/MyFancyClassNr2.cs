using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    class MyFancyClassNr2 : IMyInterface
    {
        // int IMyInterface.FancyLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FancyLevel { get; set; }

        public int ChangeFancyLevel(int fl)
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
