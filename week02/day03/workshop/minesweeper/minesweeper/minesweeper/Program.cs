using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minesweeper
{
    class Program
    {
        static int[,] PreField (int height, int width)
        {
            int[,] field = new int[height, width];
            for ( int i = 0; i < height;i++ )
            {
                for ( int j = 0; j < width ; j++ )
                {
                    field[i, j] = 0;
                }
            }
            return field;
        }

        static string[,] PreFieldSee(int height, int width, string s)
        {
            string[,] field = new string[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    field[i, j] = s;
                }
            }
            return field;
        }

        static int[,] Mineplacer (int[,] field, int minenum, int xcoord, int ycoord)
        {
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < field.GetLength(1); i++)
            {
                for (int j = 0; j < field.GetLength(0); j++)
                {
                    if (i != xcoord || j != ycoord)
                    {
                        int[] array = new int[2];
                        array[0] = i;
                        array[1] = j;
                        list.Add(array);
                    }
                }                    
            }

            Random randommine = new Random();

            while (minenum > 0)
            {
                int choose = randommine.Next(0, list.Count - 1);
                field[(list[choose])[0], (list[choose])[1]] = 9;
                list.RemoveAt(choose);
                minenum--;
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

        static int[,] FieldCounter (int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (field[i, j] == 0)
                    {
                        if (i > 0 && j > 0 && field[i - 1, j - 1] == 9) field[i, j]++;
                        if (i > 0 && j < field.GetLength(1) - 1 && field[i - 1, j + 1] == 9) field[i, j]++;
                        if (i < field.GetLength(0) - 1 && j < field.GetLength(1) - 1 && field[i + 1, j + 1] == 9) field[i, j]++;
                        if (i < field.GetLength(0) - 1 && j > 0 && field[i + 1, j - 1] == 9) field[i, j]++;
                        if (i < field.GetLength(0) - 1 && field[i + 1, j] == 9) field[i, j]++;
                        if (j < field.GetLength(1) - 1 && field[i, j + 1] == 9) field[i, j]++;
                        if (i > 0 && field[i - 1, j] == 9) field[i, j]++;
                        if (j > 0 && field[i, j - 1] == 9) field[i, j]++;
                    }
                }
            }
            return field;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            bool amIdead = false;
            int height = 4;//random.Next(5, 15);
            int width = 4;//random.Next(5, 15);

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
            string[,] fieldSee = PreFieldSee(height, width, "■");
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

            int[,] field = PreField(height, width);
            field = Mineplacer(field, mines, xcoord, ycoord);
            field = FieldCounter(field);

            int count = fieldSee.GetLength(0) * fieldSee.GetLength(1) - mines - 1;

            while ((count > 0))
            {
                if (field[ycoord, xcoord] == 9)
                {
                    count = 0;
                    amIdead = true;
                    for (int i = 0; i < field.GetLength(1); i++ )
                    {
                        for (int j = 0; j < field.GetLength(0); j++)
                        {
                            if (field[i, j] == 9) fieldSee[i, j] = "*";
                        }
                    }
                    Console.Clear();
                    FieldDrawer(fieldSee);
                    Console.WriteLine("Killed By Death\nBtw R.I.P. Lemmy :(");
                }
                else
                {
                    Console.Clear();
                    if (field[ycoord,xcoord] == 0)
                        fieldSee[ycoord, xcoord] = "-";
                    else
                        fieldSee[ycoord, xcoord] = field[ycoord, xcoord].ToString();

                    FieldDrawer(fieldSee);

                    Console.Write("Set the X coordinate: ");
                    xcoord = Int32.Parse(Console.ReadLine());
                    Console.Write("Set the Y coordinate: ");
                    ycoord = Int32.Parse(Console.ReadLine());

                    count--;
                }
                if ((count == 0) && (amIdead == false))
                {
                    if (field[ycoord, xcoord] == 0)
                        fieldSee[ycoord, xcoord] = "-";
                    else
                        fieldSee[ycoord, xcoord] = field[ycoord, xcoord].ToString();
                    FieldDrawer(fieldSee);

                    Console.Clear();
                    Console.WriteLine("We only live to win!");
                }
            }
            Console.ReadLine();
        }
    }
}
