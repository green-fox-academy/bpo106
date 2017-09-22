using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;

namespace _21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Drawer(FoxDraw foxDraw)
        {
            List<List<Point>> list = new List<List<Point>>();

            for (int i = 0; i < 15; i++)
            {
                List<Point> sublist = new List<Point>();
                switch (i)
                {
                    case 0:
                    case 14:
                        Point myPoint = new Point(8 * i, 5 * 10);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 12);
                        sublist.Add(myPoint);
                        break;
                    case 1:
                    case 13:
                        myPoint = new Point(8 * i, 5 * 7);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 9);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 13);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 15);
                        sublist.Add(myPoint);
                        break;
                    case 2:
                    case 12:
                        myPoint = new Point(8 * i, 5 * 4);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 6);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 10);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 12);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 16);
                        sublist.Add(myPoint);
                        myPoint = new Point(8 * i, 5 * 18);
                        sublist.Add(myPoint);
                        break;
                    default:

                        for (int j = 0; j < 22;)
                        {
                            myPoint = new Point(5 * j, 8 * i);
                            sublist.Add(myPoint);
                            if (j % 3 == 0)
                            {
                                j += 4;
                            }
                            else
                            {
                                j += 2;
                            }
                        }

                        if (i % 2 == 0)
                        {
                            myPoint = new Point(5 * 22, 8 * i);
                            sublist.Add(myPoint);
                        }
                        break;
                }
                list.Add(sublist);
            }

            foxDraw.StrokeColor(Colors.Black);
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < list[i].Count; j += 2 )
                {
                    switch (i)
                    {
                        case 0:
                        case 14:
                            i = i + 1 - 1;
                            break;
                        case 1:
                        case 13:
                            i = i + 1 - 1;
                            break;
                        case 2:
                        case 12:
                            i = i + 1 - 1;
                            break;
                        default:
                            if (i % 2 == 0)
                            {
                                if (i > 0)
                                {
                                    foxDraw.DrawLine(list[i][j], list[i - 1][j]);
                                }
                                if (i < 11)
                                {
                                    foxDraw.DrawLine(list[i][j], list[i + 1][j]);
                                }
                                if (j < list[i].Count - 1)
                                {
                                    foxDraw.DrawLine(list[i][j], list[i][j + 1]);
                                }
                            }
                            else
                            {
                                if (j < list[i].Count - 1)
                                {
                                    if (i < 0)
                                    {
                                        foxDraw.DrawLine(list[i][j + 1], list[i - 1][j]);
                                    }
                                    if (i < 13)
                                    {
                                        foxDraw.DrawLine(list[i][j + 1], list[i + 1][j]);
                                    }
                                    if (j < list[i].Count - 1)
                                    {
                                        foxDraw.DrawLine(list[i][j + 1], list[i][j + 1]);
                                    }
                                }
                            }
                            break;
                    }
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Drawer(foxDraw);
        }
    }
}
