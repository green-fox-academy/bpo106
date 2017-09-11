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
            double massInKg = 81.2;
            double heightInM = 1.78;
            Console.WriteLine(massInKg / (heightInM * heightInM));
            Console.ReadLine();
        }
    }
}
