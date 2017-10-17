using System;

namespace _02_comparable
{
    public class Domino : IComparable
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }

        public int CompareTo(object obj)
        {
            if ((int)obj > Values[0])
            {
                return 1;
            }
            if ((int)obj < Values[0])
            {
                return 1;
            }
            return 0;
        }
    }
}