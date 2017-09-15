using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static bool IsAnagram(string input1, string input2)
        {
            char[] word1 = input1.ToArray();
            Array.Sort(word1);
            char[] word2 = input2.ToArray();
            Array.Sort(word2);
            bool anagram = true;

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i< word1.Length; i++)
                {
                    if (word1[i] != word2[i]) anagram = false;
                }
            }

            else anagram = false;

            return anagram;
        }

        static void Main(string[] args)
        {
            string input1 = "eleven plus two";
            string input2 = "twelve plus one";

            Console.WriteLine(IsAnagram(input1, input2));
            Console.ReadLine();
        }
    }
}
