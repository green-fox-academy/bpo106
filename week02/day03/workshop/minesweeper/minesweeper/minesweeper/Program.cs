using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    class Program
    {
        static string[,] PreField (int height, int width)
        {
            string[,] field = new string[height, width];
            for (int i = 0; i< height;i++)
            {
                for (int j = 0; j < width;j++)
                {
                    field[i, j] = "0";
                }
            }
            return field;
        }

        static string[,] Mineplacer (string[,] field, int minenum)
        {
            for (int i = 0; i < minenum;)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, field.GetLength(0));
                int b = rnd.Next(0, field.GetLength(1));
                if (field[a,b] == "0")
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

                        field[i, j] = k.ToString();
                    }
                }
            }
            return field;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int h = rnd.Next(5, 15);
            int w = rnd.Next(5, 15);
            Console.Write("Height: ");
            Console.Write(h);
            Console.Write(" Width: ");
            Console.WriteLine(w);
            int mines=h*w;
            while (mines >= h*w)
            {
                Console.Write("Set the number of mines (less than ");
                Console.Write(h*w);
                Console.Write("): ");
                var input = Console.ReadLine();
                Int32.TryParse(input, out mines);
                if (mines >= h*w)
                {
                    Console.WriteLine("Too many mines!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            string[,] field = PreField(h, w);
            field = Mineplacer(field, mines);
            field = FieldCounter(field);

            FieldDrawer(field);

            Console.ReadLine();
        }
    }
}
