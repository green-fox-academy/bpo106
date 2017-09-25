using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();

            student.learn();
            student.question(teacher);

            teacher.answer();
            teacher.teach(student);
        }
    }
}
