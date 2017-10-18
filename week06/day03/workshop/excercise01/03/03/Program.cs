using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void squareQuery(int[] n)
        {
            var square = from element in n
                         where element > -1
                         select element * element;

            foreach (var element in square)
            {
                Console.Write(element + " ");
            }
        }

        static void squareLambda(int[] n)
        {
            IEnumerable<int> square = n.Where(x => x > -1).Select(x => x * x);

            foreach (var element in square)
            {
                Console.Write(element + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            squareQuery(n);
            Console.WriteLine();
            squareLambda(n);

            Console.ReadLine();
        }
    }
}
