using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void evenSql (int[] n)
        {
            var even = from element in n
                       where element % 2 == 0
                       select element;

            foreach (var element in even)
            {
                Console.Write(element + " ");
            }
        }

        static void evenLambda(int[] n)
        {
            IEnumerable<int> even = n.Where(x => x % 2 == 0);

            foreach (var element in even)
            {
                Console.Write(element + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            evenSql(n);
            Console.WriteLine();
            evenLambda(n);

            Console.ReadLine();
        }
    }
}
