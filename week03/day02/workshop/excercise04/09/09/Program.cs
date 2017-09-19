using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09
{
    class Program
    {
        static void Reverse(string path)
        {
            string[] content = File.ReadAllLines(path);

            Array.Reverse(content);

            File.WriteAllLines(path, content);
        }

        static void Main(string[] args)
        {
            string path = @"reversed-order.txt";
            Reverse(path);
            Console.ReadLine();
        }
    }
}
