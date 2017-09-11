using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 10;
            double c = 10;
            Console.Write("Surface Area: ");
            Console.WriteLine(2 * (a * b + a * c + b * c));
            Console.Write("Volume: ");
            Console.WriteLine(a * b * c);
            Console.ReadLine();
        }
    }
}
