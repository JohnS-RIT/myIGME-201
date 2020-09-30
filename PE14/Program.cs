using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    //Class: Program
    //Purpose: Create a Class1 and Class2 objects to use with MyMethod method, which calls interface to use WriteALine method
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Create a Class1 and Class2 objects
        static void Main(string[] args)
        {
            Class1 object1 = new Class1();
            Class2 object2 = new Class2();

            MyMethod(object1);
            MyMethod(object2);
        }

        //Method: MyMethod
        //Purpose: Calls interface to use WriteALine method
        public static void MyMethod(object myObject)
        {
            IClassy iClass = (IClassy)myObject;
            iClass.WriteALine();
        }
    }
}
