using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // store user name
            string myName = "";

            // string and int of # of questions
            string sQuestions = "";
            int nQuestions = 0;

            // string and base value related to difficulty
            string sDifficulty = "";
            int nMaxRange = 0;

            // constant for setting difficulty with 1 variable
            const int MAX_BASE = 10;

            // question and # correct counters
            int nCntr = 0;
            int nCorrect = 0;

            // operator picker
            int nOp = 0;

            // operands and solution
            int val1 = 0;
            int val2 = 0;
            int nAnswer = 0;

            // string and int for the response
            string sResponse = "";
            Int32 nResponse = 0;

            // boolean for whether the response was a valid number
            bool bValid = false;

            // play again?
            string sAgain = "";

            // seed the random number generator
            Random rand = new Random();

            Console.WriteLine("Math Quiz!");
            Console.WriteLine();

            // fetch the user's name into myName
            while (true)
            {
                Console.Write("What is your name-> ");
                myName = Console.ReadLine();
            }

        // label to return to if they want to play again
        start:

            // use standard console colors
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            // initialize correct responses for each time around
            nCorrect = 0;

            Console.WriteLine();

            // ask how many questions until they enter a valid number
            do
            {
                Console.Write("How many questions-> ");

            } while ( );

            Console.WriteLine();

            // ask difficulty level until they enter a valid response
            do
            {
                Console.Write("Difficulty level (easy, medium, hard)-> ");
            } while (  );

            Console.WriteLine();

            // if they choose easy, then set nMaxRange = MAX_BASE, unless myName == "David", then set difficulty to hard
            // if they choose medium, set nMaxRange = MAX_BASE * 2
            // if they choose hard, set nMaxRange = MAX_BASE * 3
            switch ( )
            {
            }

            // ask each question
            for ( )
            {
                // generate a random number between 0 inclusive and 3 exclusive to get the operation
                nOp = rand.Next(0, 3);

                val1 = rand.Next(0, nMaxRange) + nMaxRange;
                val2 = rand.Next(0, nMaxRange);

                // if either argument is 0, pick new numbers

                // if nOp == 0, then addition
                // if nOp == 1, then subtraction
                // else multiplication

                // display the question and prompt for the answer until they enter a valid number
                // we learned Convert.ToInt32(string) to convert a string to an integer
                // there is also int.Parse(string), which converts a string to an integer
                // use the int.Parse() method in this loop 
                do
                {
                } while ( );

                // if response == answer, output flashy reward and increment # correct
                // else output stark answer


                Console.WriteLine();
            }

            Console.WriteLine();

            // output how many they got correct and their score
            // hint: you can format the output as a 2 decimal percentage by using Console.WriteLine("{0:P2}", nCorrect / (double)nQuestions)
            // or Console.Write($"{Convert.ToDouble(nCorrect) / nQuestions:P2}") note that one of the operands must be cast or converted to a double
            // in order for the result to be a double (you can use either method on either operand).  
            // Otherwise the result will be an int and will always show as 100.00% or 0.00%

            Console.WriteLine();

            do
            {
                // prompt if they want to play again
                Console.Write("Do you want to play again? (Y/N)");

                sAgain = Console.ReadLine();
                
                if ()
                // if they type y or yes then play again
                // else if they type n or no then leave this loop
                // use the string class methods ToLower() and StartsWith() to check if they typed "yes" or "no"
                // hint: you can chain methods together such as string.ToLower().StartsWith("y")
            } while (true);
        }
    }
}
