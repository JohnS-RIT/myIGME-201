using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Unit1Test_Question4
{
    //Class: Program
    //Purpose: Recreate the given 3questions.exe
    //Restrictions: None
    class Program
    {
        //Creation of timer, questionNum var, and bool for outOfTime
        static Timer timeOutTimer;
        static string questionNum;
        static bool outOfTime = false;

        //Method: Main
        //Purpose: Ask user for 1 of 3 questions and then ask for the answer
        //Restrictions: None
        static void Main(string[] args)
        {
            //Declare variable
            string question = null;
            string answer = null;
            string repeat;
            bool valid = true;

            //Do/while loop that can repeat game if user would like, and forces user to give appropriate response
            do
            {
                Console.Write("Choose your question (1-3): ");
                questionNum = Console.ReadLine();

                //Store question string based on questionNum
                if (questionNum == "1")
                {
                    question = "What is your favorite color?";
                }
                else if (questionNum == "2")
                {
                    question = "What is the answer to life, the universe, and everything?";                }
                else if (questionNum == "3")
                {
                    question = "What is the airspeed velocity of an unladen swallow?";
                }

                //Ask question and begin timer
                if (questionNum == "1" || questionNum == "2" || questionNum == "3")
                {
                    timeOutTimer = new Timer(5000);
                    outOfTime = false;
                    timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

                    Console.WriteLine("You have 5 seconds to answer the following question:");
                    Console.WriteLine(question);

                    timeOutTimer.Start();
                    answer = Console.ReadLine();
                    timeOutTimer.Stop();

                    //Responds to user based on question, answer, and whether they ran out of time
                    if (questionNum == "1")
                    {
                        if (answer == "black" && !outOfTime)
                        {
                            Console.WriteLine("Well done!");
                        }
                        else if (answer != "black" && !outOfTime)
                        {
                            Console.WriteLine("Wrong! The answer is: black");
                        }
                    }
                    else if (questionNum == "2")
                    {
                        if (answer == "42" && !outOfTime)
                        {
                            Console.WriteLine("Well done!");
                        }
                        else if (answer != "42" && !outOfTime)
                        {
                            Console.WriteLine("Wrong! The answer is: 42");
                        }
                    }
                    else
                    {
                        if (answer == "What do you mean? The African or European Swallow?" && !outOfTime)
                        {
                            Console.WriteLine("Well done!");
                        }
                        else if (answer != "What do you mean? The African or European Swallow?" && !outOfTime)
                        {
                            Console.Write("Wrong! The answer is: What do you mean? The African or European Swallow?");
                        }
                    }

                    //Do/while to ask user if they would like to continue, forces user to give appropriate answer
                    do
                    {
                        Console.Write("Play again? ");
                        repeat = Console.ReadLine();
                    }
                    while (repeat != "yes" && repeat != "no");
                    
                    //End game if they choose no
                    if(repeat == "no")
                    {
                        valid = false;
                    }
                }
                Console.WriteLine();
            }
            while (valid);
        }

        //Method: TimesUp
        //Purpose: Tell user time is up 5 seconds after question is posed, tells them what answer was
        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Time's Up!");
            Console.Write("The answer is: ");
            if (questionNum == "1")
            {
                Console.Write("black");
            }
            else if (questionNum == "2")
            {
                Console.Write("42");
            }
            else
            {
                Console.Write("What do you mean? The African or European Swallow?");
            }
            Console.WriteLine("\nPlease press enter.");

            outOfTime = true;
            timeOutTimer.Stop();
        }
    }
}
