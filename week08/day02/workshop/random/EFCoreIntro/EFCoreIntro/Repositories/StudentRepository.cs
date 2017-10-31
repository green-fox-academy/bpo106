using EFCoreIntro.Entities;
using EFCoreIntro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Repositories
{
    public class StudentRepository
    {
        StudentContext studentContext;

        public StudentRepository(StudentContext studentContext)
        {
            this.studentContext = studentContext;
        }

        public int CountStudents()
        {
            return studentContext.Students.Count();
        }

        public Student GetLastStudent()
        {
            return StudentContext.Students.Last();
        }
 
        public void AddStudent()
        {
            var student = new Student()
            {
                Firstname = "Pista",
                Surname = "Tra",
                Age = 18
            };
 
            StudentContext.Students.Add(student);
            StudentContext.SaveChanges();
        }
 
        public void UpdateStudent()
        {
            var student = StudentContext.Students.FirstOrDefault(s => s.Firstname.Equals("Pista"));
            student.Age = 81;
            StudentContext.Students.Update(student);
            StudentContext.SaveChanges();
        }
 
        public void RemoveStudent()
        {
            var student = StudentContext.Students.FirstOrDefault(s => s.Firstname.Equals("Pista"));
            StudentContext.Students.Remove(student);
            StudentContext.SaveChanges();
        }
    }
}
