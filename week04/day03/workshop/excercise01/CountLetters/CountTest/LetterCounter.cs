using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountLetters
{
    public class LetterCounter
    {
        public Dictionary<char, int> charLister (string s)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            char[] word = s.ToCharArray();

            for (int i = 65; i < 182; i++)
            {
                dictionary.Add((char)i, 0);
            }

            for (int i = 0; i < word.Length; i++)
            {
                int count;
                dictionary.TryGetValue(word[i], out count);
                dictionary[word[i]] = count + 1;
            }

            for (int i = 65; i < 182; i++)
            {
                int count;
                dictionary.TryGetValue((char)i, out count);
                if (count == 0)
                {
                    dictionary.Remove((char)i);
                }
            }

            return dictionary;
        }
    }
}
