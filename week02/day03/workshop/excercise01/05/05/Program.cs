using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            reversed = new string(reversed.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reversed);
            Console.ReadLine();
        }
    }
}
