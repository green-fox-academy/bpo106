using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_printable
{
    public class Domino : IPrintable
    {
        public int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public void PrintAllFields()
        {
            Console.WriteLine("{0}, {1}", Values[0], Values[1]);
        }
    }
}
