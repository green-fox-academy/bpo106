using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Program
    {
        static void squareQuery(int[] n)
        {
            var square = from element in n
                         where element * element > 20
                         select element;

            foreach (var element in square)
            {
                Console.Write(element + " ");
            }
        }

        static void squareLambda(int[] n)
        {
            IEnumerable<int> square = n.Where(x => x * x > 20);

            foreach (var element in square)
            {
                Console.Write(element + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            squareQuery(n);
            Console.WriteLine();
            squareLambda(n);

            Console.ReadLine();
        }
    }
}
