using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    //Class: Program
    //Purpose: Allow student to go through and find various types of compile, run-time, and logical errors
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //int nY - Compile-time error, missing semicolon
            int nY;
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); - Compile-time error, missing quotation marks
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); Run-Time error, this ReadLine should be equate to string sNumber
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            } //while (int.TryParse(sNumber, out nX)); - Logical error, should output nY, as this is for y var
            //while (int.TryParse(sNumber, out nY)); - Run-time error, program will loop forever if you give an integer
            //while (!int.TryParse(sNumber, out nY)); - Run-time error, if user gives a negative in, causes stack overflow error
            while (!int.TryParse(sNumber, out nY) || nY < 0);

            // compute the factorial of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); - Logical error, need to specify vars to be used, otherwise simply prints given string with {}'s
            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer);
        }


        //int Power(int nBase, int nExponent) - Compile-time, must be static so parameters can pass
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; - Logical error, x^0 = 1
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); - Run-time error, causes stack overflow as function will loop forever as continually increasing nExponent
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; - Compile-time error, must specify that you are actually RETURNING returnVal
            return returnVal;
        }
    }
}

