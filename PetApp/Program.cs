using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PetApp
{
    //Class: Program
    //Purpose: Create pets to performa actions
    //Restrictions: None
    class Program
    {
        //Method: Main
        //Purpose: Create instances of pets
        static void Main(string[] args)
        {
            string name;
            int age;
            string license;

            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();

            for(int i = 0; i < 50; i++)
            {
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0,2) == 0)
                    {
                        Console.WriteLine("You bought a dog!");
                        Console.Write("Dog's Name => ");
                        name = Console.ReadLine();
                        Console.Write("Age => ");
                        while (true)
                        {
                            try
                            {
                                age = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.Write("Age => ");
                            }
                        }
                        Console.Write("License => ");
                        license = Console.ReadLine();

                        thisPet = new Dog(license, name, age);
                        
                    }
                    else
                    {
                        Console.WriteLine("You bought a cat!");
                        Console.Write("Cat's Name => ");
                        name = Console.ReadLine();
                        Console.Write("Age => ");
                        while (true)
                        {
                            try
                            {
                                age = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.Write("Age => ");
                            }
                        }
                        cat = new Cat();
                        thisPet = cat;
                        thisPet.Name = name;
                        thisPet.age = age;
                    }
                }
                else
                {
                    thisPet = pets[rand.Next(0, pets.Count)];
                }

                if (thisPet != null)
                {
                    if (thisPet.GetType() == typeof(Cat))
                    {
                        iCat = (ICat)thisPet;
                        int choice = rand.Next(0, 4);

                        if (choice == 0)
                        {
                            iCat.Eat();
                        }
                        else if (choice == 1)
                        {
                            iCat.Play();
                        }
                        else if (choice == 2)
                        {
                            iCat.Scratch();
                        }
                        else
                        {
                            iCat.Purr();
                        }
                    }
                    else
                    {
                        iDog = (IDog)thisPet;
                        int choice = rand.Next(0, 5);

                        if (choice == 0)
                        {
                            iDog.Eat();
                        }
                        else if (choice == 1)
                        {
                            iDog.Play();
                        }
                        else if (choice == 2)
                        {
                            iDog.Bark();
                        }
                        else if (choice == 3)
                        {
                            iDog.NeedWalk();
                        }
                        else
                        {
                            iDog.GotoVet();
                        }

                    }
                }
            }
        }
    }
}
