using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static List<int> Unique (List<int>input)
        {
            input.Reverse();
            for (int i =0; i<input.Count; i++)
            {
                for (int j = i+1; j<input.Count;j++)
                {
                    if (input[i] == input[j]) input.Remove(input[i]);
                }
            }
            input.Reverse();
            return input;
        }

        static void Main(string[] args)
        {
            List<int> input = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };
            for (int i = 0; i<input.Count;i++)
            {
                Console.Write("{0} ", input[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < input.Count; i++)
            {
                Console.Write("{0} ", Unique(input)[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
