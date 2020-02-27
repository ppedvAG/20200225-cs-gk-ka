using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
        public class MyFancyClass : IMyInterface
        {
            
            //zusätzlich zum Level wird noch ein Limit implementiert - wird aber hier nicht verwendet
            public int FancyLevelLimit { get; set; }

            public int FancyLevel { get; set; }

        public int ChangeFancyLevel(int fl)
            {
            // Beispiel if () FancyLevelLimit --
            //throw new NotImplementedException();
            FancyLevel = fl;
                return FancyLevel;
            }


            string IMyInterface.SayHelloInYourWay()
            {
                return "FancySayHelloFromClass";
                //throw new NotImplementedException();

            }
        }

}
