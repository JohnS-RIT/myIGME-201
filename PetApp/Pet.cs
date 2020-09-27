using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    //Class: Pet
    //Purpose: Abstract class for general Pet creation
    public abstract class Pet
    {
        private string name;
        public int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public abstract void Eat();

        public abstract void Play();

        public abstract void GotoVet();

        public Pet() { }

        public Pet (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
