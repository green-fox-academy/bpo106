using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class PallidaClass
    {
        private string className;
        List<Student> students;
        List<Mentor> mentors;

        public PallidaClass(string className)
        {
            students.Clear();
            mentors.Clear();
        }

        void AddStudent(Student student)
        {
            students.Add(student);
        }

        void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors.", className, students.Count, mentors.Count);
        }
    }
}
