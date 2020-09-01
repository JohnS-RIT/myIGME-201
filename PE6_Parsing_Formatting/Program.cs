using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Parsing_Formatting
{
    //Class: Program
    //Purpose: Run main code in order to ask user to guess random numer
    //0 - 100 inclusive
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Create a random int 0-100 inclusive and give user 8 VALID guesses
        //To figure out, assist by informing if guess is too high or low
        //Restrictions: None
        static void Main(string[] args)
        {
            //Variables
            bool valid;
            int userInput = -1;
            int turnCount = 1;
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            //Print random number for testing purposes
            Console.WriteLine(randomNumber + "\nGuess numbers between 0 and 100 inclusive\n");

            //While loop for guessing game (maximum of 8 full loops is all valid but incorrect guesses)
            while(turnCount < 9)
            {
                Console.Write("Turn #:" + turnCount + ": Enter your guess: ");
                valid = int.TryParse(Console.ReadLine(), out userInput);

                //If parse fails, repeat below until valid int given
                while (!valid || userInput < 0 || userInput > 100)
                {
                    Console.WriteLine("Invalid guess - try again.\n");
                    Console.Write("Turn #:" + turnCount + ": Enter your guess: ");
                    valid = int.TryParse(Console.ReadLine(), out userInput);
                }

                //Compare userInput to randomNumber
                if (userInput == randomNumber)
                {
                    Console.WriteLine("\nCorrect! You won in " + turnCount + " turn(s).");
                    break;
                }
                else if (userInput > randomNumber)
                {
                    Console.WriteLine("Too high\n");
                    turnCount++;
                }
                else
                {
                    Console.WriteLine("Too low\n");
                    turnCount++;
                }
            }

            //If user fails to guess correctly in 8 tries
            if (turnCount > 8)
            {
                Console.WriteLine("You ran out of turns. The number was " + randomNumber + ".");
            }
        }
    }
}
