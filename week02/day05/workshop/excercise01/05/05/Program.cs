using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        
        static int Josephus (List<int> list)
        {
            
            while (list.Count > 2)
            {
                int temp = list[0];
                list.Remove(list[0]);
                list.Remove(list[0]);
                list.Add(temp);
            }
            
            return list[0];
        }

        static void Main(string[] args)
        {
            int input;
            input = Int32.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < input; i++)
            {
                list.Add(i + 1);
            }

            Console.WriteLine(Josephus(list));
            Console.ReadLine();
        }
    }
}
