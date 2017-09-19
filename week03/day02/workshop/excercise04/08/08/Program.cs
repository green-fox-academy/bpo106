using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _08
{
    class Program
    {
        static void Reverse(string path)
        {
            string[] content = File.ReadAllLines(path);

            for (int i = 0; i < content.Length; i++)
            {
                char[] array = content[i].ToCharArray();
                Array.Reverse(array);
                content[i] = new string(array);
            }
            File.WriteAllLines(path, content);
        }

        static void Main(string[] args)
        {
            string path = @"reversed-lines.txt";
            Reverse(path);
            Console.ReadLine();
        }
    }
}
