using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Question7
{
    //Class: program
    //Purpose:console application that accepts a string from the user and outputs a string with the characters in reverse order
    //Restrictions: none
    class Program
    {
        //Method: main
        //Purpose:console application that accepts a string from the user and outputs a string with the characters in reverse order
        //Restrictions: none
        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Please enter a word or sentence: ");
            userInput = Console.ReadLine();

            char[] characters = userInput.ToCharArray();

            for(int i = (characters.Length - 1); i >= 0; i--)
            {
                Console.Write(characters[i]);
            }

            Console.WriteLine();
        }
    }
}
