using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Mentor : Person
    {
        private string level;

        public Mentor()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            level = "intermediate";
        }

        public Mentor(string name, int age, string gender, string level)
        {
        }

        public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} level mentor.", name, age, level);
        }
    }
}
