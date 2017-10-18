using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_printable
{
    class Program
    {
        static void Main(string[] args)
        {
            Domino domino = new Domino(2, 1);
            Todo todo = new Todo();
            domino.PrintAllFields();
            todo.PrintAllFields();
            Console.ReadLine();
        }
    }
}
