using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void avgOddQuery(int[] n)
        {
            int sum = 0;
            var odd = from element in n
                      where element % 2 == 1 || -element % 2 == 1
                      select element;

            foreach (var element in odd)
            {
                sum += element;
            }
            Console.WriteLine(sum / (double)(odd.ToList().Count));
        }

        static void avgOddLambda(int[] n)
        {
            IEnumerable<int> odd = n.Where(x => x % 2 == 1 || (-x) % 2 == 1);

            int sum = 0;
            double count = 0.0;
            foreach (var element in odd)
            {
                sum += element;
                count++;
            }
            Console.WriteLine(sum / (double)(odd.ToList().Count));
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
