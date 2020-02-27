using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyFancyClass2 : IMyInterface

        //int IMyInterface.FancyLevel get throw new Ni...
 
      
    {
        // int IMyInterface.FancyLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //   get; set;

        int IMyInterface.FancyLevel { get; set; }

        public int ChnageFancyLevel(int fl, int FancyLevel)
        {
            // throw new NotImplementedException();
            FancyLevel = fl;
            return FancyLevel;
        }

        public string SayHalloInYourWay()
        {
            // throw new NotImplementedException();
            return "FancyHalloFromClass2";
        }
    }
    
   

 
    {
    }
}
