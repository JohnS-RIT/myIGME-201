using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Test_Question12
{
    //Class: Program
    //Purpose: Ask user for name and give raise depenedent on anme
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Ask user for name
        //Restrictions: None
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            Console.Write("What's your name?: ");
            sName = Console.ReadLine();

            bool raise = GiveRaise(sName, ref dSalary);

            if (raise)
            {
                Console.WriteLine("Congrats John, you got a raise!");
                Console.WriteLine("New salary: " + dSalary);
            }
        }

        //Takes in name and ref for salary and increases salary and returns true if name = "John"
        static bool GiveRaise(string name, ref double salary)
        {
            if(name == "John")
            {
                salary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
