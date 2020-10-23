using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;
using CourseLib;

namespace PeopleAppGlobals
{
    // global variables that all modules of our application can access
    public static class Globals
    {
        public static People people = new People();
        public static Courses courses = new Courses();

        public static void AddPeopleSampleData()
        {
            int i = 0;

            Person person = null;
            Student student = null;
            Teacher teacher = null;

            Random rand = new Random();

            String[] specialty = new String[] { "Math", "Comp Sci", "History", "Chemistry", "English" };

            String[] firstName = new string[] { "Sue", "Tom", "Harry", "John", "David", "Rob", "Mary", "Cathy", "Amy", "Theresa", "Beth" };
            String[] lastName = new string[] { "Harris", "Smith", "Johnson", "Cass", "Murphy", "O'Malley", "Scott", "Peterson", "Clark" };

            for (i = 0; i < 100; ++i)
            {
                if (rand.Next(0, 2) == 0)
                {
                    student = new Student();
                    student.gpa = rand.NextDouble() * 4;

                    person = student;
                }
                else
                {
                    teacher = new Teacher();

                    teacher.specialty = specialty[rand.Next(0, specialty.Length)];
                    person = teacher;
                }

                person.eGender = (genderPronoun)rand.Next(0, 3);

                person.age = rand.Next(0, 81);
                person.LicenseId = rand.Next(0, 999999);

                person.email = "person_" + i.ToString() + "@rit.edu";
                person.name = firstName[rand.Next(0, firstName.Length)] + " " + lastName[rand.Next(0, lastName.Length)];

                people[person.email] = person;
            }
        }
    }
}
