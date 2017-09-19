using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"random.txt";

            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content.Length);
            }

            catch (Exception e)
            {
                Console.WriteLine("0");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
