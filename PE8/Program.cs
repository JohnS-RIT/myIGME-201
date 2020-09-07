using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    //class: Program
    //Purpose: Run code to calculate a variable z based on ranges
    //Restrictions: code does not calculate all answers
    class Program
    {
        //method: Main
        //Purpose: Define z based on ranges with 3-dimensional array
        //Restrictions: code goes out of bounds
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            int xIncr = 0;
            int yIncr = 0;
            int zIncr = 0;

            //3d array [x,y,z]
            double[,,] formulation = new double[21, 40, 630];

            for (double i = -1; i <= 1; i+=.1)
            {
                xIncr++;
                for (double j = 1; j <= 4; j += .1)
                {
                    yIncr++;
                    zIncr++;
                    x = i;
                    y = j;
                    z = 3 * (y * y) + 2 * x - 1;
                    formulation[xIncr, yIncr, zIncr] = x + y + z;
                    Console.WriteLine(formulation[xIncr, yIncr, zIncr]);
                }
            }

            
        }
    }
}
