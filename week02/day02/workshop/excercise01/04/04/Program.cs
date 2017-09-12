using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-1-re kilép");
            sum();
            Console.ReadLine();
        }

        static void sum()
        {
            int sum = 0;
            int num = 0;
            string input="x";
            while (num!=-1)
            {
                input = Console.ReadLine();
                Int32.TryParse(input, out num);
                if (num!=-1) sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
