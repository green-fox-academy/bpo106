using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static int Find (string input, string find)
        {
            for (int i = 0; i< input.Length; i++)
            {
                if (input[i] == find[0])
                {
                    if (find.Length > input.Length - i) return -1;
                    else
                    {
                        for (int j = 1; j < find.Length; j++)
                        {
                            if (find[j] != input[i + j]) return -1;
                        }
                        return i;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string find = Console.ReadLine();
            Console.WriteLine(Find(input, find));
            Console.ReadLine();
        }
    }
}
