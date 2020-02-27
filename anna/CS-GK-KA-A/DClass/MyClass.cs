using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyClass
    {

        //fields
        //sind immer private, kleingeschirben 
        private string strmyField1;
        private int intmyfield2;


        //props 
        //constructor 
        //methods

        public void SetFields(string arg1, int arg2)
        {

            strmyField1 = arg1;
            intmyfield2 = arg2;

        }


        public string GetFields()
        { return strmyField1 + intmyfield2; }

        //{ return "Grüße aus"; }

        //destructor 


    }


}
