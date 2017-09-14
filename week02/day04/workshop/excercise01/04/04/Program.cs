using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static bool Find (string input, string find) //from task 3!
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

        static List<int> Finder (List<int> input, int fnum)
        {
            List<int> output = new List<int>();
            List<string> strInput = (from i in input select i.ToString()).ToList();
            string strFnum = fnum.ToString();

            for (int i = 0; i < strInput.Count; i++)
                if (Find(strInput[i], strFnum) == true) output.Add(i);

            return output;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.Write("Size of list: ");
            int inputnum = Int32.Parse(Console.ReadLine());
            Console.Write("Set the elements: ");
            for (int i = 0; i < inputnum; i++ )
            {
                int num = Int32.Parse(Console.ReadLine());
                list.Add(num);
            }
            Console.Write("Number to be found: ");
            inputnum = Int32.Parse(Console.ReadLine());

            Console.Write("List: ");
            for (int i = 0; i < list.Count; i++) Console.Write("{0} ", list[i]);
            Console.WriteLine();
            Console.Write("Where the number can be found: ");
            for (int i = 0; i < Finder(list, inputnum).Count; i++) Console.Write("{0} ", Finder(list, inputnum)[i]);
            Console.ReadLine();
        }
    }
}
