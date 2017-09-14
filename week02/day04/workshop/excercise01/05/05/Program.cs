using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static bool Find(string input, string find) //from task 3!
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == find[0])
                {
                    if (find.Length > input.Length - i) return false;
                    else
                    {
                        for (int j = 1; j < find.Length; j++)
                        {
                            if (find[j] != input[i + j]) return false;
                        }
                        return true;
                    }
                }
            }
            return false;
        }

        static List<int> Finder(List<string> input, string felement)
        {
            List<int> output = new List<int>();
          
            for (int i = 0; i < input.Count; i++)
                if (Find(input[i], felement) == true) output.Add(i);

            if (output.Count == 0) output.Add(-1);
            return output;
        }

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.Write("Size of list: ");
            int inputnum = Int32.Parse(Console.ReadLine());
            Console.Write("Set the elements:\n");
            for (int i = 0; i < inputnum; i++)
            {
                string element = Console.ReadLine();
                list.Add(element);
            }
            Console.Write("String to be found: ");
            string findElement = Console.ReadLine();

            Console.Write("List: ");
            for (int i = 0; i < list.Count; i++) Console.Write("{0} ", list[i]);
            Console.WriteLine();
            Console.Write("Where the string can be found: ");
            for (int i = 0; i < Finder(list, findElement).Count; i++) Console.Write("{0} ", Finder(list, findElement)[i]);
            Console.ReadLine();
        }
    }
}