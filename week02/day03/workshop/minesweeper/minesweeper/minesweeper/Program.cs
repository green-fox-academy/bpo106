﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    class Program
    {
        static string[,] PreField (int height, int width, string s)
        {
            string[,] field = new string[height, width];
            for (int i = 0; i< height;i++)
            {
                for (int j = 0; j < width;j++)
                {
                    field[i, j] = s;
                }
            }
            return field;
        }

        static string[,] Mineplacer (string[,] field, int minenum, int x, int y)
        {
            for (int i = 0; i < minenum;)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, field.GetLength(0));
                int b = rnd.Next(0, field.GetLength(1));
                if (field[a,b] == "0" && a != y && b != x)
                {
                    field[a, b] = "*";
                    i++;
                }
            }
            return field;
        }

        static void FieldDrawer (string[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static string[,] FieldCounter (string[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == "0")
                    {
                        int k = 0;

                        if (i > 0 && j > 0 && field[i - 1, j - 1] == "*") k++;
                        if (i > 0 && j < field.GetLength(1) - 1 && field[i - 1, j + 1] == "*") k++;
                        if (i < field.GetLength(0) - 1 && j < field.GetLength(1) - 1 && field[i + 1, j + 1] == "*") k++;
                        if (i < field.GetLength(0) - 1 && j > 0 && field[i + 1, j - 1] == "*") k++;
                        if (i < field.GetLength(0) - 1 && field[i + 1, j] == "*") k++;
                        if (j < field.GetLength(1) - 1 && field[i, j + 1] == "*") k++;
                        if (i > 0 && field[i - 1, j] == "*") k++;
                        if (j > 0 && field[i, j - 1] == "*") k++;

                        if (k != 0) field[i, j] = k.ToString();
                        else field[i, j] = "-";
                    }
                }
            }
            return field;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool amIdead = false;
            int h = 4; //rnd.Next(5, 15);
            int w = 4; //rnd.Next(5, 15);

            Console.WriteLine("It's time to play the game!");
            Console.Write("Height: ");
            Console.WriteLine(h);
            Console.Write(" Width: ");
            Console.WriteLine(w);
            int mines=h*w;

            Console.Write("Set the number of mines (less than ");
            Console.Write(h * w - 1);
            Console.Write("): ");

            while (mines >= h * w - 1)
            {
                var input = Console.ReadLine();
                Int32.TryParse(input, out mines);
                if (mines >= h * w - 1)
                {
                    Console.WriteLine("Too many mines!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.Clear();
            string[,] fieldSee = PreField(h, w, "■");
            FieldDrawer(fieldSee);
            int x = 15;
            int y = 15;

            while (x > w - 1)
            {
                Console.Write("Set the X coordinate: ");
                x = Int32.Parse(Console.ReadLine());
            }            
            while (y > h - 1)
            {
                Console.Write("Set the Y coordinate: ");
                y = Int32.Parse(Console.ReadLine());
            }

            string[,] field = PreField(h, w, "0");
            field = Mineplacer(field, mines, x, y);
            field = FieldCounter(field);

            int count = fieldSee.GetLength(0) * fieldSee.GetLength(1) - mines - 1;

            while ((count > 0))
            {
                if (field[y, x] == "*")
                {
                    count = 0;
                    Console.WriteLine("Killed By Death\nBtw R.I.P. Lemmy :(");
                }
                else
                {
                    Console.Clear();
                    fieldSee[y, x] = field[y, x];
                    FieldDrawer(fieldSee);

                    Console.Write("Set the X coordinate: ");
                    x = Int32.Parse(Console.ReadLine());
                    Console.Write("Set the Y coordinate: ");
                    y = Int32.Parse(Console.ReadLine());

                    count--;
                    if (count == 0) Console.WriteLine("We only live to win!");
                }
            }

            Console.ReadLine();
        }
    }
}
