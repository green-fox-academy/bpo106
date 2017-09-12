using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };
            nimals = add(nimals);
            //for (int i = 0; i < nimals.Length; i++)
            //{
            //    Console.WriteLine(nimals[i] + " ");
            //}
            Console.ReadLine();
        }

        static string[] add (string[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                array[i] += "a";
            }
            return array;
        }
    }
}
