using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10
{
    class Program
    {
        static void Decode (string path)
        {
            string[] content = File.ReadAllLines(path);

            for (int i = 0; i < content.Length; i++)
            {
                char[] row = content[i].ToCharArray();
                for (int j = 0; j < content[i].Length; j++)
                {
                    if (row[j] != ' ')
                    {
                        row[j] -= (char)1;
                    }
                }
                content[i] = new string(row);
            }
            File.WriteAllLines(path, content);
        }

        static void Main(string[] args)
        {
            string str = @"encoded-lines.txt";
            Decode(str);
            Console.ReadLine();
        }
    }
}
