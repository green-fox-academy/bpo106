using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Anagrams
    {
        public bool wordCompare (string s1, string s2)
        {
            char[] schar1;
            char[] schar2;
            schar1 = s1.ToCharArray();
            Array.Sort(schar1);
            schar2 = s2.ToCharArray();
            Array.Sort(schar2);

            if (schar1.Length == schar2.Length)
            {
                for (int i = 0; i < schar1.Length; i++)
                {
                    if (schar1[i] != schar2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
