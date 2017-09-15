using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static string CreatePalindrome (string input)
        {
            List<char> list = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                list.Add(input[i]);
            }
            for (int i =input.Length; i>0; i--)
            {
                list.Add(input[i - 1]);
            }

            return string.Join("", list.ToArray());
        }

        static void Main(string[] args)
        {
            string input = "random";
            string output = CreatePalindrome(input);

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }
            Console.ReadLine();
        }
    }
}
