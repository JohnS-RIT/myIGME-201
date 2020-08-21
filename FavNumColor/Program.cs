using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FavNumColor
{
    //class Program
    //Purpose: Run main code
    //Restrictions: None
    class Program
    {
        //Method main
        //Purpose: prompt user for favorite number and color
        static void Main(string[] args)
        {
            string color;
            int number = 0;
            string strNum;
            bool valid = false;

            //Prompt for fav color
            Console.Write("Enter your favorite color:\t");

            //Read for fav color
            color = Console.ReadLine();

            do
            {
                //Prompt for fav number
                Console.Write("\nEnter your favorite number:\t");

                //Read for fav number
                strNum = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(strNum);
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter an integer");
                }
            }
            while (valid == false);

            //Change text color to their fav color
            switch (color.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }

            //Print response of fav color to console their fav number of times
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Your favorite is {color + "!"}");
            }
        }
    }
}
