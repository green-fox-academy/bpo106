using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ag = { 4, 5, 6, 7, 8 };
            doubling(ag);
            Console.ReadLine();
        }

        static void doubling(int[] array)
        {
            for (int i=0;i<array.Length;i++)
            {
                array[i] *= 2;
                Console.WriteLine(array[i]);
            }
        }
    }
}
