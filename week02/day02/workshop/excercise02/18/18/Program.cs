using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };
            sum(ai);
            Console.ReadLine();
        }

        static void sum (int[] array)
        {
            for (int i=1;i<array.Length;i++)
            {
                array[0] += array[i];
            }
            Console.WriteLine(array[0]);
        }
    }
}
