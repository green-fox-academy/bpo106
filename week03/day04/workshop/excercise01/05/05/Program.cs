using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static int Ear(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return Ear(n - 1) + 2;
            }
        }

        static void Main(string[] args)
        {
            int n = Int32. Parse(Console.ReadLine());
            Console.WriteLine(Ear(n));
            Console.ReadLine();
        }
    }
}
