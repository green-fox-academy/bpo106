using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class FibonacciCounter
    {
        public int counter (int input)
        {
            switch (input)
            {
                case 0:
                    return 1;
                case 1:
                    return 1;
                default:
                    return counter(input - 1) + counter(input - 2);
            }
        }
    }
}
