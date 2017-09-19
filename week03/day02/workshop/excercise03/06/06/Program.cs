using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06
{
    class Program
    {
        static bool Copy (string pathInput, string pathOutput)
        {
            bool isSuccessful = true;

            try
            {
                string[] content = File.ReadAllLines(pathInput);
                File.WriteAllLines(pathOutput, content);

                return isSuccessful;
            }

            catch (Exception e)
            {
                isSuccessful = false;
                return isSuccessful;
            }
        }

        static void Main(string[] args)
        {
            string pathInput = @"input.txt";
            string pathOutput = @"output.txt";

            Console.WriteLine(Copy(pathInput,pathOutput));
            Console.ReadLine();
        }
    }
}
