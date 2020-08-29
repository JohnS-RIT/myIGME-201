using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3___Question_5
{
    //class: Program
    //Purpose: Run main code which holds method Main asking user for 4 integers
    //Restrictions: None
    class Program
    {
        //method: Main
        //Purpose: Asks user for 4 integers which are taken in as strings and converted to ints, then multiplied
        //Restrictions: None
        static void Main(string[] args)
        {
            Console.WriteLine((6 / 4.0 + 3.5) / 2);
            //Declare each string for number input and int variable to convert each to
            string sNum1;
            string sNum2;
            string sNum3;
            string sNum4;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int product;

            //Declare and initialize boolean for do while loops to ensure proper integers are given
            bool valid = false;

            //Do-while loop that asks user for first integer and repeats using try-catch block until a working int is given
            do
            {
                Console.Write("Please enter an integer: ");     //Ask for first number
                sNum1 = Console.ReadLine();
                try
                {
                    num1 = Convert.ToInt32(sNum1);              //Try to convert string into int
                    valid = true;
                }
                catch { Console.WriteLine("Please enter a valid integer!"); }      //Catch block if not success
            }
            while (valid == false);

            //Reset valid bool
            valid = false;

            //Do-while loop that asks user for second integer and repeats using try-catch block until a working int is given
            do
            {
                Console.Write("Please enter another integer: ");     //Ask for second number
                sNum2 = Console.ReadLine();
                try
                {
                    num2 = Convert.ToInt32(sNum2);              //Try to convert string into int
                    valid = true;
                }
                catch { Console.WriteLine("Please enter a valid integer!"); }      //Catch block if not success
            }
            while (valid == false);

            //Reset valid bool
            valid = false;

            //Do-while loop that asks user for third integer and repeats using try-catch block until a working int is given
            do
            {
                Console.Write("Please enter another integer: ");     //Ask for third number
                sNum3 = Console.ReadLine();
                try
                {
                    num3 = Convert.ToInt32(sNum3);              //Try to convert string into int
                    valid = true;
                }
                catch { Console.WriteLine("Please enter a valid integer!"); }      //Catch block if not success
            }
            while (valid == false);

            //Reset valid bool
            valid = false;

            //Do-while loop that asks user for fourth integer and repeats using try-catch block until a working int is given
            do
            {
                Console.Write("Please enter another integer: ");     //Ask for fourth number
                sNum4 = Console.ReadLine();
                try
                {
                    num4 = Convert.ToInt32(sNum4);              //Try to convert string into int
                    valid = true;
                }
                catch { Console.WriteLine("Please enter a valid integer!"); }      //Catch block if not success
            }
            while (valid == false);

            //Create product and display
            product = num1 * num2 * num3 * num4;
            Console.WriteLine("\nProduct: " + product + "\n");

        }
    }
}
