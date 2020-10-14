using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Question4thru7
{
    //Class: Program
    //Purpose: Create a Tardis object and PhoneBooth object and use both by calling UsePhone Method
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Create a Tardis object and PhoneBooth object and use both by calling UsePhone Method
        //Restrictions: None
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();


            UsePhone(tardis);
            UsePhone(phoneBooth);
		}

        //Method: UsePhone
        //Purpose: call MakeCall() and HangUp() using interface, then calls approprate method based on object type
        //Restrictions: None
        static void UsePhone(object obj)
        {
            PhoneInterface phoneInterface = (PhoneInterface)obj;

            phoneInterface.MakeCall();
            phoneInterface.HangUp();

            if (obj.GetType() == typeof(PhoneBooth))
            {
                PhoneBooth phoneBooth = (PhoneBooth)obj;
                phoneBooth.OpenDoor();
            }
            else if (obj.GetType() == typeof(Tardis))
            {
                Tardis tardis = (Tardis)obj;
                tardis.TimeTravel();
            }
        }
	}
}
