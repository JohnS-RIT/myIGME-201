using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Test_Question3
{
    //Class: Program
    //Purpose: Create a delegate to impersonate Console.ReadLine()
    //Restrictions: None
    class Program
    {
        delegate string ReadLine();

        //Method: Main
        //Purpose: call a ReadLine delegate and output the return
        //Restrictions: None
        static void Main(string[] args)
        {
            ReadLine readLine = new ReadLine(Console.ReadLine);
            Console.Write("Input a string: ");
            string userInput = readLine();
            Console.WriteLine("You wrote: " + userInput);
        }
    }
}
