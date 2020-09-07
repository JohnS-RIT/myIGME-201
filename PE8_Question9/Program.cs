using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question9
{
    //Class: program
    //Purpose: Add quotations to each word in a string
    //Restrictions: none
    class Program
    {
        //Method: main
        //Purpose: Add quotations to each word in user inputted string by splitting to array
        //Restrictions: none
        static void Main(string[] args)
        {
            //Declare variable
            string userInput;

            //Take in sentence
            Console.Write("Please enter a sentence: ");
            userInput = Console.ReadLine();

            //Convert to string array based on " "
            string[] stringList = userInput.Split(' ');

            //Foreach loop to take each element and print each with " before and after it
            foreach (var s in stringList)
            {
                Console.Write("\"" + s + "\" ");
            }

            Console.WriteLine();
        }
    }
}
