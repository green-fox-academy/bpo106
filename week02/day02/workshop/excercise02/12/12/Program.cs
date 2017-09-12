using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] af = { 4, 5, 6, 7 };
            printall(af);
            Console.ReadLine();
        }

        static void printall(int[] n)
        {
           foreach (int element in n)
            {
                Console.WriteLine(element);
            }
        }
    }
}
