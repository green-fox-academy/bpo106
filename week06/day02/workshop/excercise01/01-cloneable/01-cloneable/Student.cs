using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_cloneable
{
    public class Student : ICloneable
    {
        private string name;
        private int age;
        private string gender;
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", name, age, gender, previousOrganization, skippedDays);
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public object Clone()
        {
            Student cloned = new Student(name, age, gender, previousOrganization);
            return cloned;
        }
    }
}
