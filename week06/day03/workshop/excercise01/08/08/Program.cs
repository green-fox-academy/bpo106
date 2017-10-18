﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _08
{
    class Program
    {
        static void upperCaseQuery(string s)
        {
            var uppercase = from element in s
                            where Char.IsUpper(element)
                            select element;

            uppercase.ToList().ForEach(x => Console.Write("{0} ", x));
        }

        static void upperCaseLambda(string s)
        {
            var uppercase = s.Where(x => Char.IsUpper(x)).Select(x => x);

            uppercase.ToList().ForEach(x => Console.Write("{0} ", x));
            
        }

        static void Main(string[] args)
        {
            string s = "BuDaPeST";

            Console.WriteLine(s);
            upperCaseQuery(s);
            Console.WriteLine();
            upperCaseLambda(s);

            Console.ReadLine();
        }
    }
}
