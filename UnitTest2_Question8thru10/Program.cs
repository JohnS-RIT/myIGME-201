using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Question8thru10
{
    //Class: Program
    //Purpose: Create a fantasy and a mystery book object and call methods
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Create Fantasy object and Mystery object and call MyMethod() with both
        static void Main(string[] args)
        {
            Fantasy book1 = new Fantasy();
            Mystery book2 = new Mystery();

            MyMethod(book1);
            MyMethod(book2);
        }

        //Method: MyMethod
        //Purpose: Call all methods of an object through interfaces and parent based on object type
        static void MyMethod(object obj)
        {
            if (obj.GetType() == typeof(Fantasy))
            {
                Fantasy f1 = (Fantasy)obj;
                f1.Read();
                f1.AddNotes("I like wizards.");

                IFantasy fantasy = (IFantasy)obj;
                fantasy.UseMagic();
            }
            else if (obj.GetType() == typeof(Mystery))
            {
                Mystery m1 = (Mystery)obj;
                m1.Read();
                m1.AddNotes("The butler did it.");

                IMystery mystery = (IMystery)obj;
                mystery.CommitCrime();
            }
        }
    }
}
