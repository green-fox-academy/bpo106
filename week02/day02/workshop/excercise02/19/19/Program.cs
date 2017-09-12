using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };
            reverse(aj);
            Console.ReadLine();
        }

        static void reverse(int[] array)
        {
            for (int i=0;i<array.Length;i++)
            {
                if (i < array.Length / 2)
                {
                    array[i] += array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = array[i] - array[array.Length - 1 - i];
                    array[i] -= array[array.Length - 1 - i];
                }
                Console.Write(array[i] + " ");
            }
        }
    }
}
