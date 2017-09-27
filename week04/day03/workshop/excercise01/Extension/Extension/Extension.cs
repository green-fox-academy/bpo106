using System;
using System.Collections.Generic;

namespace Extension
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }

        public int Median(List<int> pool)
        {
            pool.Sort();
            return pool[(pool.Count - 1) / 2];
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű', 'A', 'Á', 'E', 'É', 'I', 'Í', 'O', 'Ó', 'Ö', 'Ő', 'U', 'Ú', 'Ü', 'Ű' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c))
                {
                    teve = string.Concat(teve.Substring(0,i), c, "v", c, teve.Substring(i+1, length - i - 1));
                    i += 2;
                    length += 2;
                }
            }

            return teve;
        }
    }
}