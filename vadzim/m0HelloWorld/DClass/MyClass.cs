using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DClass
{
    public class MyClass
    {
        // fields
        // sind immer private
        // Konvention: klein geschrieben
        private string strMyField1;
        private int intMyField2;
        // props
        // constructor
        // methods
        public void SetFields(string arg1, int arg2)
        {
            strMyField1 = arg1;
            intMyField2 = arg2;
        }
        public string GetFields()
        {
            // return "Grüße aus MyClass"; // Default-Werte werden zurückgegeben
            return strMyField1 + intMyField2; // Default-Werte werden zurückgegeben

        }
        // destructor
    }
}
