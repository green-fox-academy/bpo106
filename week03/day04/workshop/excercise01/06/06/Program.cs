using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static int NewEars (int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n % 2 == 1)
            {
                return NewEars(n - 1) + 2;
            }
            else
            {
                return NewEars(n - 1) + 3;
            }
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(NewEars(n));
            Console.ReadLine();
        }
    }
}
