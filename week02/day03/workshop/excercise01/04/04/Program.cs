using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            todoText = todoText.Insert(0, "Postal 2 - Monday\nMy todo:\n");
            todoText += " - Pick up paycheck\n   - Defend yourself the attack of crazy game protestors\n";
            todoText = string.Concat(todoText, " - Cash paycheck\n   - Try not to rob the bank");
            Console.WriteLine(todoText);
            Console.ReadLine();
        }
    }
}
