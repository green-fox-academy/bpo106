using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public Person(string name, int age, string gender)
        {
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2}.", name, age, gender);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
