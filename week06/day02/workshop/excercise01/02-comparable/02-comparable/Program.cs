using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dominoes = new ArrayList();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));

            dominoes.Sort();
        }
    }
}
