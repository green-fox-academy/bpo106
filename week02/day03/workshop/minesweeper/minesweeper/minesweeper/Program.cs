using System;
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
            for ( int i = 0; i < height;i++ )
            {
                for ( int j = 0; j < width ; j++ )
                {
                    field[i, j] = s;
                }
            }
            return field;
        }

        static string[,] Mineplacer (string[,] field, int minenum, int xcoord, int ycoord)
        {
            for ( int i = 0; i < minenum; )
            {
                Random random = new Random();
                int a = random.Next(0, field.GetLength(0));
                int b = random.Next(0, field.GetLength(1));
                if (field[a,b] == "0" && a != ycoord && b != xcoord)
                {
                    field[a, b] = "*";
                    i++;
                }
            }
            return field;
        }

        static void FieldDrawer (string[,] field)
        {
            for ( int i = 0; i < field.GetLength(0); i++ )
            {
                for ( int j = 0; j < field.GetLength(1); j++ )
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
            Random random = new Random();
            bool amIdead = false;
            int height = random.Next(5, 15);
            int width = random.Next(5, 15);

            Console.WriteLine("It's time to play the game!");
            Console.WriteLine("Height: {0}", height);
            Console.WriteLine("Width: {0}", width);
            int mines = height * width;

            Console.WriteLine("Set the number of mines (less than {0})", height * width - 1, ":");

            while (mines >= height * width - 1)
            {
                var input = Console.ReadLine();
                Int32.TryParse(input, out mines);
                if (mines >= height * width - 1)
                {
                    Console.WriteLine("Too many mines!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            Console.Clear();
            string[,] fieldSee = PreField(height, width, "■");
            FieldDrawer(fieldSee);
            int xcoord = 15;
            int ycoord = 15;

            while (xcoord > width - 1)
            {
                Console.Write("Set the X coordinate: ");
                xcoord = Int32.Parse(Console.ReadLine());
            }            
            while (ycoord > height - 1)
            {
                Console.Write("Set the Y coordinate: ");
                ycoord = Int32.Parse(Console.ReadLine());
            }

            string[,] field = PreField(height, width, "0");
            field = Mineplacer(field, mines, xcoord, ycoord);
            field = FieldCounter(field);

            int count = fieldSee.GetLength(0) * fieldSee.GetLength(1) - mines - 1;

            while ((count > 0))
            {
                if (field[ycoord, xcoord] == "*")
                {
                    count = 0;
                    Console.WriteLine("Killed By Death\nBtw R.I.P. Lemmy :(");
                }
                else
                {
                    Console.Clear();
                    fieldSee[ycoord, xcoord] = field[ycoord, xcoord];
                    FieldDrawer(fieldSee);

                    Console.Write("Set the X coordinate: ");
                    xcoord = Int32.Parse(Console.ReadLine());
                    Console.Write("Set the Y coordinate: ");
                    ycoord = Int32.Parse(Console.ReadLine());

                    count--;
                    if (count == 0) Console.WriteLine("We only live to win!");
                }
            }

            Console.ReadLine();
        }
    }
}
