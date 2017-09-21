using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static int Fib(int n)
        {
            switch (n) {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return Fib(n - 1) + Fib(n - 2);
            }
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
            Console.ReadLine();
        }
    }
}
