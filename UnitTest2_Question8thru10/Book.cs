using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Question8thru10
{
    //Class: Book
    //Purpose: Abstract class to be parent to Mystery and Fantasy clesses
    public abstract class Book
    {
        private string title;

        public string Title
        {
            get { return this.title; }
        }

        public abstract void Read();

        public virtual void AddNotes(string note)
        {

        }
    }
}
