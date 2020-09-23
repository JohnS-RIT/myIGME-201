using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Question3
{
    //Class: MyDerivedClass
    //Purpose: Override GetString method of base/parent class: MyClass
    class MyDerivedClass: MyClass
    {
        //Method: GetString
        //Purpose: returns myString
        public override string GetString()
        {
            return base.GetString() + " (output from derived class)";
        }
    }
}
