using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _11
{
    class Program
    {
        static List<string>[] NumbersMaker (string[] rows)
        {
            List<string>[] numbers = new List<string>[rows.Length];
            for (int i = 0; i < rows.Length; i++)
            {
                numbers[i] = rows[i].Split(';').ToList();
                for (int j = 0; j < 11; j++)
                {
                    numbers[i].RemoveAt(0);
                }
            }
            return numbers;
        }

        static int[] CountFiller (List<string>[] numbers)
        {
            int[] count = new int[90];

            for (int i = 0; i < 90; i++)
            {
                count[i] = 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    count[Int32.Parse(numbers[i][j]) - 1] += Int32.Parse(numbers[i][j]);
                }
            }
            return count;
        }

        static int MaxCounter(int[] count)
        {
            int max = 0;
            int index = 0;

            for (int i = 0; i < 90; i++)
            {
                if (max < count[i])
                {
                    max = count[i];
                    index = i + 1;
                }
            }

            return index;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaxCounter(CountFiller(NumbersMaker(File.ReadAllLines(@"otos.csv")))));

            Console.ReadLine();
        }
    }
}
