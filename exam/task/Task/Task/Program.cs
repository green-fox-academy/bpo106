using System;

namespace Task
{
    class Program
    {
        //Task 2: Create a function that reverses a string

        //With a simple for loop
        static string Reverse (string s)
        {
            string reversed = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversed += s[i];
            }
            return reversed;
        }

        //With Array.Reverse()
        static string Reverse2 (string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        //In a bit wtf way
        static string Reverse3 (string s)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s += s[i];
            }
            return s.Substring(s.Length / 2, s.Length / 2);
        }

        static void Main(string[] args)
        {
            string s = "asdasdasd";
            Console.WriteLine(s);
            Console.WriteLine(Reverse(s));
            Console.WriteLine(Reverse2(s));
            Console.WriteLine(Reverse3(s));
            Console.ReadLine();
        }
    }
}
