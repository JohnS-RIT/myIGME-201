using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE5_Question2
{
    //Class: Program
    //Purpose: Run main code to request user for 2 numbers
    //Restrictions: none
    class Program
    {
        //Method: Main
        //Purpose: Ask user for 2 integers and display, will request new numbers if both are > 10 or both are < 10
        //Restrictions: none
        static void Main(string[] args)
        {
            //Declare variables
            string sNum1;
            string sNum2;
            int num1 = 0;
            int num2 = 0;
            bool valid = true;
            

            
            //While loop until only one number at most is > 10
            while(valid == true)
            {
                //Try-catch block to ensure code does not break if non-integer input is given
                try
                {
                    //Ask user for 2 numbers
                    Console.Write("Please enter an integer: ");
                    sNum1 = Console.ReadLine();
                    Console.Write("Please enter another integer: ");
                    sNum2 = Console.ReadLine();

                    //Convert string form of numbers into int var type
                    num1 = Convert.ToInt32(sNum1);
                    num2 = Convert.ToInt32(sNum2);
                }
                catch 
                {
                    num1 = 0;
                    num2 = 0;
                }

                //Convert each int to bool based on value and compare
                Console.WriteLine();
                bool num1Test = num1 > 10;
                bool num2Test = num2 > 10;
                bool test = num1Test ^ num2Test;

                //Repeat or break while loop based on user input
                if (test)
                {
                    valid = false;
                }
                else
                {
                    Console.WriteLine("Please enter 2 new integers, one > 10 and one < 10");
                }
            }
            
            //Print out successfully received ints from user.
            Console.WriteLine("First number: " + num1 + "\nSecond number: " + num2);
        }
    }
}
