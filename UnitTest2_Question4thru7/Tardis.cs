using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Question4thru7
{
    //Class: Tardis
    //Purpose: blueprints for creating tardis objects
    public class Tardis : RotaryPhone
    {
        private bool sonicScrewDriver;
        private byte whichDrWho;

        public byte WhichDrWho
        {
            get { return this.whichDrWho; }
        }
        
        //Bool operator overloads to ensure whichDrWho == 10 is always greatest
        public static bool operator ==(Tardis t1, Tardis t2)
        {
            return t1.whichDrWho == t2.whichDrWho;
        }

        public static bool operator !=(Tardis t1, Tardis t2)
        {
            return t1.whichDrWho != t2.whichDrWho;
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10 || t1.whichDrWho > t2.whichDrWho)
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
            else if (t2.whichDrWho == 10 || t1.whichDrWho < t2.whichDrWho)
            {
                return t1.whichDrWho < t2.whichDrWho;
            }
            else
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
        }

        public static bool operator <(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10 || t1.whichDrWho > t2.whichDrWho)
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
            else if (t2.whichDrWho == 10 || t1.whichDrWho < t2.whichDrWho)
            {
                return t1.whichDrWho < t2.whichDrWho;
            }
            else
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
        }

        public static bool operator >=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
            else if (t2.whichDrWho == 10)
            {
                return t1.whichDrWho < t2.whichDrWho;
            }
            else if (t1.whichDrWho > t2.whichDrWho)
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
            else if (t1.whichDrWho < t2.whichDrWho)
            {
                return t1.whichDrWho < t2.whichDrWho;
            }
            else
            {
                return t1.whichDrWho == t2.whichDrWho;
            }
        }

        public static bool operator <=(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
            else if (t2.whichDrWho == 10)
            {
                return t1.whichDrWho < t2.whichDrWho;
            }
            else if (t1.whichDrWho > t2.whichDrWho)
            {
                return t1.whichDrWho > t2.whichDrWho;
            }
            else if (t1.whichDrWho < t2.whichDrWho)
            {
                return t1.whichDrWho < t2.whichDrWho;
            }
            else
            {
                return t1.whichDrWho == t2.whichDrWho;
            }
        }

        private string femaleSideKick;

        public string FemaleSideKick
        {
            get { return this.femaleSideKick; }
        }

        public double exteriorSurfaceArea;
        public double interiorVolume;

        public void TimeTravel()
        {

        }
    }
}
