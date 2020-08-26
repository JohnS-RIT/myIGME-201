using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0 - ";" missing at end of line, compile-time error, syntax
            int i = 0;

            // declare string to hold all numbers
            string allNumbers = null;

            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i)
            {
                // declare string to hold all numbers
                //string allNumbers = null; - Must be declared before for loop, compile-time error

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = "); - missing parentheses around calculation of i - 1, compile-time error, syntax
                Console.Write(i + "/" + (i - 1) + " = ");

                //No number can be divided by zero, so in order to keep for loop from 1-10, it will pass over any 
                //iterations where the denominator (i-1) would be zero, which would not need an output as it is invalid to start,
                //used an if statement to stop and else to report any invalid iterations - run-time error
                if ((i - 1) != 0)
                {
                    // output the calculation based on the numbers
                    Console.WriteLine(i / (i - 1));
                }
                else
                {
                    //Output the error
                    Console.WriteLine("cannot divide by 0");
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                //i = i + 1; - Unnecessary incrementation as the for loop does it on it's own, would be useful for while or do while loop
                //Run-time error
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); - must have concatenation ('+') between components, compile-time error
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }

}
