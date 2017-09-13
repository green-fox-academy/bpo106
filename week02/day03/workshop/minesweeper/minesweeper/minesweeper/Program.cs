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

        static string[,] Mineplacer (string[,] field, int h, int w, int minenum)
        {
            for (int i = 0; i < minenum;)
            {
                Random rnd = new Random();
                int a = rnd.Next(0, h);
                int b = rnd.Next(0, w);
                if (field[a,b] == "0")
                {
                    field[a, b] = "*";
                    i++;
                }
            }
            return field;
        }

        static void FieldDrawer (string[,] field, int h, int w)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
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
            field = Mineplacer(field, h, w, mines);
            FieldDrawer(field, h, w);

            Console.ReadLine();
        }
    }
}
