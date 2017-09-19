using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07
{
    class Program
    {
        static void Simplify (string path)
        {
            string[] content = File.ReadAllLines(path);

            for (int i = 0; i < content.Length; i++ )
            {
                var text = new List<char>(content[i]);

                for (int j = 0; j < text.Count- 1; j++)
                {
                    text.RemoveAt(j);
                }

                content[i] = string.Join("", text.ToArray());
            }
            File.WriteAllLines(path, content);
        }

        static void Main(string[] args)
        {
            string path = @"duplicated-chars.txt";
            Simplify(path);
            Console.ReadLine();
        }
    }
}
