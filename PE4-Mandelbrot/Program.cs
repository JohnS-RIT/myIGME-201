using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    //**CODE HAS BEEN MODIFIED TO ALLOW USER TO 'ZOOM IN' BY INPUTING LIMITS FOR COORDINATES**
    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        static void Main(string[] args)
        {
            string sRealCoord, sImagCoord, sRealCoordEnd, sImagCoordEnd;
            double realCoord = 0, imagCoord = 0;
            double realCoordStart = 0, imagCoordStart = 0;
            double realCoordEnd = 0, imagCoordEnd = 0;
            double realCoordIncrement, imagCoordIncrement;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            bool valid = false;

            Console.WriteLine("Hello and welcome to the adjustable mandelbrot. We would like to ask you to set the limits for the image." +
                "Please make sure you follow the requirements.");

            while (valid == false)
            {
                Console.Write("\nPlease enter a starting value for imagCoord (This value will be the higher value for imagCoord): ");
                sImagCoord = Console.ReadLine();
                Console.Write("Please enter an ending value for imagCoord (This value must be lower than the start): ");
                sImagCoordEnd = Console.ReadLine();

                Console.Write("Please enter a starting value for realCoord (This value will be the lower value for realCoord): ");
                sRealCoord = Console.ReadLine();
                Console.Write("Please enter an ending value for realCoord (This must be the higher value): ");
                sRealCoordEnd = Console.ReadLine();

                try
                {
                    int fail;
                    realCoordStart = Convert.ToDouble(sRealCoord);
                    realCoordEnd = Convert.ToDouble(sRealCoordEnd);
                    imagCoordStart = Convert.ToDouble(sImagCoord);
                    imagCoordEnd = Convert.ToDouble(sImagCoordEnd);
                    if (imagCoordStart <= imagCoordEnd || realCoordStart >= realCoordEnd) 
                    { 
                        fail = Convert.ToInt32("badInput"); 
                    }
                    valid = true;
                }
                catch
                {
                    Console.WriteLine("Please enter numbers that match the requirements!");

                }

            }
            imagCoordIncrement = Math.Abs(imagCoordStart - imagCoordEnd) / 48;
            realCoordIncrement = Math.Abs(realCoordStart - realCoordEnd) / 80;
            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= imagCoordIncrement)
            {
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += realCoordIncrement)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}

