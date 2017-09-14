using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static List<int> Sort (List<int> input, bool desc)
        {
            input.Sort();
            if (desc == true) input.Reverse();
            return input;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            bool desc;
            string inputString = "random";

            Console.Write("Elements of list? ");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Elements:");
            for (int j=0; j<i;j++)
            {
                int element = Int32.Parse(Console.ReadLine());
                list.Add(element);
            }
            while (inputString != "A" && inputString != "D")
            {
                Console.Clear();
                Console.Write("A/D? ");
                inputString = Console.ReadLine();
            }
            if (inputString == "A") desc = false;
            else desc = true;
            for (i = 0; i < list.Count; i++)
            {
                Console.Write("{0} ", Sort(list, desc)[i]);
            }
            Console.ReadLine();
        }
    }
}
