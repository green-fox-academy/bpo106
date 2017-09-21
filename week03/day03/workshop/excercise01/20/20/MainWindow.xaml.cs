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

namespace _20
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Drawer (FoxDraw foxDraw)
        {
            List<List<Point>> list = new List<List<Point>>();

            for (int i = 0; i < 22; i++ )
            {
                List<Point> sublist = new List<Point>();
                for (int j = 22 - i; j < 23 + i; j += 2 )
                {
                    Point myPoint = new Point(6 * j, 10 * i);
                    sublist.Add(myPoint);
                }
                list.Add(sublist);
            }

            foxDraw.StrokeColor(Colors.Black);
            for (int i = 1; i < 22; i++ )
            {
                for (int j = 0; j < list[i].Count; j++ )
                {
                    if (j < list[i].Count - 1)
                    {
                        foxDraw.DrawLine(list[i - 1][j], list[i][j]);
                    }
                    if (j > 0)
                    {
                        foxDraw.DrawLine(list[i - 1][j - 1], list[i][j]);
                    }
                    if (j < list[i].Count - 1)
                    {
                        foxDraw.DrawLine(list[i][j], list[i][j + 1]);
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
