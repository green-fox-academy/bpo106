using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";
            example = example.Replace("dishwasher", "galaxy");
            Console.WriteLine(example);
            Console.ReadLine();
        }
    }
}
