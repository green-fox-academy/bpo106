using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static int Power(int n, int s)
        {
            if (s == 0)
            {
                return 1;
            }
            else
            {
                return n * Power(n, s - 1);
            }
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int s = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Power(n, s));
            Console.ReadLine();
        }
    }
}
