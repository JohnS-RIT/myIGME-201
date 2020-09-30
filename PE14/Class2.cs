using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    //Class: Class1
    //Purpose: Run WriteALine method
    class Class2 : IClassy
    {
        //Method: WriteALine
        //Purpose: Writes a line specific to Class2 objects
        public void WriteALine()
        {
            Console.WriteLine("This is the very unique string for the WriteALine method of Class2!");
        }
    }
}
