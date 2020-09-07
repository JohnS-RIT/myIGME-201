
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question8
{
    //Class: program
    //Purpose: console application that accepts a string and replaces all occurrences of the string "no" with "yes"
    //Restrictions: none
    class Program
    {
        //Method: main
        //Purpose: console application that accepts a string and replaces all occurrences of the string "no" with "yes"
        //Restrictions: none
        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Please enter a word or sentence: ");
            userInput = Console.ReadLine();

            if (userInput == "no")
            {
                userInput = "yes";
            }

            Console.WriteLine("\n" + userInput + "\n");
        }
    }
}
