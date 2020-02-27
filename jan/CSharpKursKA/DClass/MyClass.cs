using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLibrary
{
    public class MyClass
    {
        // fields
        // sind immer private
        // Konvention: klein geschrieben (erster Buchstabe)
        private string strMyField1;
        private int intMyField2;


        // props (properties)

        // constructor

        // methods
        public void SetFields(string arg1, int arg2)
        {
            strMyField1 = arg1;
            intMyField2 = arg2;
        }

        public string GetFields()
        {
            return strMyField1 + intMyField2;
            //return "Grüße aus MyClass";
        }

        // destructor

    }
}
