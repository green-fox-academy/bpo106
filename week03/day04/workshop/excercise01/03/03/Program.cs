using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static int SumDigit(int n)
        {
            if (n < 10)
            {
                return n;
            }
            else
            {
                int sum = 0;
                sum = SumDigit(n / 10) + (n % 10);
                return sum;
            }
        }

        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(SumDigit(n));
            Console.ReadLine();
        }
    }
}
