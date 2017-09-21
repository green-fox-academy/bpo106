using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void CountDown(int n)
        {
            while (n > 0)
            {
                n--;
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            CountDown(n);
            Console.ReadLine();
        }
    }
}
