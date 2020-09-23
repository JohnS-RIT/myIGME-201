using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Question3
{
    //Class: Program
    //Purpose: Practice creating classes and derived classes with overridden methods
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Create MyDerivedClass instance and have it run to override MyString of MyClass
        //Restrictions: None
        static void Main(string[] args)
        {
            MyDerivedClass class1 = new MyDerivedClass();

            class1.MyString = "sample string";

            Console.WriteLine(class1.GetString());
        }
    }
}
