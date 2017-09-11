using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            for (int i =1 ;i<num+1;i++)
            {
                for (int j = 1; j < i + 1; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
