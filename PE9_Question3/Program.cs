using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Question3
{
    //Class: Program
    //Purpose: create delegate function for Console.ReadLine()
    class Program
    {
        //Method: main
        //Purpose: call a readLine delegate and output the return
        static void Main(string[] args)
        {
            string returnedInput = ReadLine();
            Console.WriteLine("\n" + returnedInput);
        }

        //Method: ReadLine
        //Purpose: delegate for Console.ReadLine();
        static string ReadLine()
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
