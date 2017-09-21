using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static int FromOneToN(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return FromOneToN(n - 1) + n;
            }
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(FromOneToN(n));
            Console.ReadLine();
        }
    }
}
