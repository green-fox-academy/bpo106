using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student() :base()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public Student(string name, int age, string gender, string previousOrganization)
        {
            skippedDays = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
