using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_sortthearray
{
    class Program
    {
        static void Sort<T>(ref T[] input) where T : IComparable<T>
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[j].CompareTo(input[i]) > 0)
                    {
                        T k = input[i];
                        input[i] = input[j];
                        input[j] = k;                        
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 5, 32, 43, 1, 3, 67 };
            Sort<int>(ref array);
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
