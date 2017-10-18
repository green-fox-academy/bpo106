using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void avgOddQuery(int[] n)
        {
            var odd = from element in n
                      where element % 2 != 0
                      select element;

            Console.WriteLine(odd.ToList().Average());
        }

        static void avgOddLambda(int[] n)
        {
            IEnumerable<int> odd = n.Where(x => x % 2 != 0);

            Console.WriteLine(odd.ToList().Average());
        }

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            avgOddQuery(n);
            avgOddLambda(n);

            Console.ReadLine();
        }
    }
}
