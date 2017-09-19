using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05
{
    class Program
    {

        static void FileWriter (string path, string word, int number)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                try
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);
                    }
                }
                catch (Exception e)
                {
                    writer.WriteLine("");
                }
                finally
                {
                    Console.ReadLine();
                }
            }
        }
        static void Main(string[] args)
        {
            string path = @"my-file.txt";
            string word = "apple";
            int number = 5;

            FileWriter(path, word, number);
        }
    }
}
