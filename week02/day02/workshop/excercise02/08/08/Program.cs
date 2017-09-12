using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };
            printif(p1, p2);
            Console.ReadLine();
        }

        static void printif(int[] array1, int[] array2)
        {
            if (array1.Length < array2.Length) Console.WriteLine("p2 has more elements than p1.");
            else if (array1.Length > array2.Length) Console.WriteLine("p1 has more elements than p2.");
            else Console.WriteLine("Both arrays have the same amount of elements.");
        }
    }
}
