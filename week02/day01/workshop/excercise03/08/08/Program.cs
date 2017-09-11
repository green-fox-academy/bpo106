using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            Console.WriteLine("Before swap:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine("After swap:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
