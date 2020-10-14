using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Question4thru7
{
    //Class: Phone
    //Purpose: blueprints for creating phone objects
    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }

        public string address;

        public abstract void Connect();
        public abstract void Disconnect();
    }
}
