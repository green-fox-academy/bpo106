using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_printable
{
    public class Todo : IPrintable
    {
        public void PrintAllFields()
        {
            Console.WriteLine("This is some random text. Enjoy.");
        }
    }
}
