using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Test_Question13
{
    //Class: Program
    //Purpose: Ask user for name and give raise depenedent on name
    //Restrictions: None
    class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }

        //Method: Main
        //Purpose: Ask user for name
        //Restrictions: None
        static void Main(string[] args)
        {
            employee employee1 = new employee();

            Console.Write("What's your name?: ");
            employee1.sName = Console.ReadLine();
            employee1.dSalary = 30000;

            bool raise = GiveRaise(ref employee1);

            if (raise)
            {
                Console.WriteLine("Congrats John, you got a raise!");
                Console.WriteLine("New salary: " + employee1.dSalary);
            }
        }

        //Takes in ref for employee struct and increases salary and returns true if employee's name = "John"
        static bool GiveRaise(ref employee employee1)
        {
            if (employee1.sName == "John")
            {
                employee1.dSalary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
