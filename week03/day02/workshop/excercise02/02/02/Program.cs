using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"my-file.txt";

            try
            {
                string[] content = File.ReadAllLines(path);
                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine(content[i]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
