using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}