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
        public int FancyLevel { get; set; }

         public int ChangeFancyLevel(int fl)
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
