using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor() : base()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company)
        {
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public void Hire()
        {
            hiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
