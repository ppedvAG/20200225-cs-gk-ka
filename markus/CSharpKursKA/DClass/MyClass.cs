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
        private string myField1;
        private int myField2;


        // properties

        // constructor

        // methods

        public void SetFields(string arg1, int arg2)
        {
            this.myField1 = arg1;
            this.myField2 = arg2;
        }
        public string GetFields()
        {
            return myField1 + myField2; // Default Werte werden zurückgegeben.
            //return "Grüße aus MyClass"; // Default Werte werden zurückgegeben.
        }
        // destructor

    }
}
