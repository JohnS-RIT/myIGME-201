using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace PE7_MadLibs
{
    //Class: Program
    //Author: John Sniffen
    //Purpose: Run through code utilizing File IO and String formatting to create mad libs
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Run file IO to create mad libs with given answers from user
        //Restrictions: None
        static void Main(string[] args)
        {
            //Declare variables
            string start;
            string name;
            string userInput;
            int lineChoice = 0;
            bool valid = true;
            int nameCheck = 0;
            string resultString = null;

            //Welcome user and ask if they want to play
            Console.Write("Hello and welcome to Mad Libs! Would you like to play?: ");
            start = Console.ReadLine();

            //If user doesn't give valid answer, ask again until they do (while loop)
            while(start.ToLower() != "yes" && start.ToLower() != "no")
            {
                Console.Write("Please enter a valid answer!: ");
                start = Console.ReadLine();
            }

            //Loop game until user says no
            while(start.ToLower() == "yes")
            {
                //Only enter name once, in case multiple games played
                if (nameCheck == 0)
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                    nameCheck++;
                }
                
                Console.Write("Please choose a mad lib (1-5): ");

                //Loop to ask for valid mad lib choice, prevents errors with try/catch
                while (valid)
                {
                    try
                    {
                        lineChoice = int.Parse(Console.ReadLine());
                        if (lineChoice < 1 || lineChoice > 5)
                        {
                            lineChoice = int.Parse("p");
                        }
                        valid = false;
                    }
                    catch
                    {
                        Console.Write("Please enter a valid number!: ");
                    }
                }

                //Start streamreader use try/catch if error found at any point
                StreamReader input = null;
                try
                {
                    input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
                    String line = null;
                    String[] data = null;
                    int counter = 0;

                    //Set data[] equal to given mad lib choice
                    while (counter <= (lineChoice - 1))
                    {
                        line = input.ReadLine();
                        data = line.Split(' ');
                        counter++;
                    }

                    Console.WriteLine();

                    //Check to see if string[] element is '\n', user input, or regular word and acts accordingly
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (data[j].Contains("\\n"))
                        {
                            //Start new line
                            resultString += "\n";
                        }
                        else if (data[j].Contains("{") || data[j].Contains("}") || data[j].Contains("_"))
                        {
                            //Remove {} and _
                            data[j] = data[j].Replace("{", "");
                            data[j] = data[j].Replace("}", "");
                            data[j] = data[j].Replace("_", " ");
                            data[j] = data[j].ToLower();
                            Console.Write("Please enter a(n) " + data[j] + ": ");
                            userInput = Console.ReadLine();

                            resultString += userInput + " ";
                        }
                        else
                        {
                            resultString += data[j] + " ";
                        }
                    }

                    Console.WriteLine("\n" + resultString);


                }
                catch { }
                finally 
                { 
                    input.Close();
                    Console.Write("Would you like to play again?: ");
                    start = Console.ReadLine();

                    //If user doesn't give valid answer, ask again until they do (while loop)
                    while (start.ToLower() != "yes" && start.ToLower() != "no")
                    {
                        Console.Write("Please enter a valid answer!: ");
                        start = Console.ReadLine();
                    }
                }
            }

            Console.WriteLine("\nGoodbye.");
        }
    }
}
