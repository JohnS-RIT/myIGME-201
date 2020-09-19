using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    //Class: Program
    //Purpose: practice use of libraries, creates vehicle objects or it's children which get more specific
    //Restrictions: Wont work as it wont seem to allow me to load vehicles library. I created it using .net 
    //framework for C# to create libraries in .dll type, but I think it only made a .sln
    class Program
    {
        //Method: Main
        //Purpose: Create instances of classes, comparing those who do and dont connect to IPassengerCarrier 
        //Restrictions: Does not work currently, as Library is created/loaded properly
        static void Main(string[] args)
        {
            AddPassenger(new Compact());
            AddPassenger(new SUV());
            AddPassenger(new Pickup());
            AddPassenger(new PassengerTrain());

            //Object that does not inherit IPassengerCarrier
            AddPassenger(new FreightTrain());
        }

        static void AddPassenger(IPassengerCarrier Vehicle)
        {
            Vehicle.IPassengerCarrier.LoadPassenger();
            Console.WriteLine(Vehicle.ToString());
        }
    }
}
