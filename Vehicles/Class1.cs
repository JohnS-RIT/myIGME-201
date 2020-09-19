using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Class1
    {
        public abstract class Vehicle
        {
            public virtual void LoadPassenger()
            {

            }
        }
        public abstract class Car : Vehicle
        {

        }
        public abstract class Train : Vehicle
        {
            public override void LoadPassenger()
            {

            }
        }
        public interface IPassengerCarrier
        {

        }
        public interface IHeavyLoadCarrier
        {

        }
        public class Compact : Car, IPassengerCarrier
        {

        }
        public class SUV : Car, IPassengerCarrier
        {

        }
        public class Pickup : Car, IPassengerCarrier, IHeavyLoadCarrier
        {

        }
        public class PassengerTrain : Train, IPassengerCarrier
        {

        }
        public class FreightTrain : Train, IHeavyLoadCarrier
        {

        }
        public class _424DoubleBogey : Train, IHeavyLoadCarrier
        {

        }
    }
}
