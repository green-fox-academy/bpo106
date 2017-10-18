using System;
using System.Collections.Generic;
using System.Linq;

namespace _05
{
    class Program
    {
        static void frequencyLambda(int[] n)
        {
            var frequency = n.GroupBy(x => x).Select(x => new { Number = x.Key, Count = x.Count() });

            foreach (var element in frequency)
            {
                Console.WriteLine(element.Number + ": " + element.Count);
            }
        }

        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            frequencyLambda(n);

            Console.ReadLine();
        }
    }
}
