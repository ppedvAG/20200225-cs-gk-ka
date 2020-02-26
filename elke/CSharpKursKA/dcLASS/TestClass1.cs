using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DClass
{
    public class TestClass1
    {
        //Fields
        // sind immer privat -> Konvention: immer klein geschrieben
        private string strMyField1;
        private int intMyField2;

        //Properties


        //constructor


        //methods

        public void SetFields(string arg1, int arg2) //void -> es wird nichts zurückgegeben
        {
            this.strMyField1 = arg1;
            this.intMyField2 = arg2;
        }
        public string sGetFields()
        {
            return strMyField1 + intMyField2; //Defaultwerte werden zurückgegeben
            //return "Grüße aus TestClass1"; //Defaultwerte werden zurückgegeben
        }

        //destructor


    }
}
