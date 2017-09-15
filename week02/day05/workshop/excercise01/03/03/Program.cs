using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static List<string> SearchPalindrome (string input)
        {
            List<string> output = new List<string>();

            for (int i = 0; i< input.Length; i++)
            {
                int j = 0;

                while ((input[i + j] == input[i]) && (i < input.Length - 1) && (i + j < input.Length - 1))
                {
                    if (i + j < input.Length - 1) j++;
                }

                int k = 0;
                                
                List<char> sublist = new List<char>();
                while ((i + j + k < input.Length) && (i - k - 1 >= 0) && (input[i + j + k] == input[i - k - 1]))
                {
                    sublist.Add(input[i + j + k]);
                    k++;
                }
                sublist.Reverse();

                for (int l = 0; l < j; l++) sublist.Add(input[i]);

                for (int l = sublist.Count - 1 - j; l >= 0; l--)
                {
                    sublist.Add(sublist[l]);
                }
                if (sublist.Count > 2)
                {
                    string sublist2 = new string(sublist.ToArray());
                    output.Add(sublist2);
                }
                
            }
            return output;
        }

        static void Main(string[] args)
        {
            string input = "123456789xxxabcdefghiaxxxawwwww";
            List<string> output = new List<string>();
            output = SearchPalindrome(input);
            Console.Write("[\"");
            for (int i = 0; i < output.Count - 1; i++)
            {
                Console.Write(output[i] + "\", \"");
            }
            Console.WriteLine(output[output.Count - 1] + "\"]");
            Console.ReadLine();
        }
    }
}
