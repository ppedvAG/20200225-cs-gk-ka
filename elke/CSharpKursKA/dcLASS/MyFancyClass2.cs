using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary

{
    public class MyFancyClass2 : IMyInterface
    {
        //ursprüngliches Einfügen auskommentiert
        //int IMyInterface.FancyLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IMyInterface.FancyLevel { get; set; }

         int IMyInterface.ChangeFancyLevel(int fl, int FancyLevel)
        {
            //throw new NotImplementedException();
            FancyLevel = fl;
            return FancyLevel;

        }

         string IMyInterface.SayHelloInYourWay()
        {
            return "FancySayHelloFromClass2";
            //throw new NotImplementedException();

        }
    }
}
