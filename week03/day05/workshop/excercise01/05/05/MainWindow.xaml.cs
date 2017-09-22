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

namespace _05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void SquarePorn (FoxDraw foxDraw, Point start, Point end, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Transparent);

            List<Point> list = new List<Point>();
            list.Add(new Point(start.X + (end.X - start.X) / 4, start.Y + (end.Y - start.Y) / 4));
            list.Add(new Point(start.X + (end.X - start.X) * 3 / 4, start.Y + (end.Y - start.Y) / 4));
            list.Add(new Point(start.X + (end.X - start.X) * 3 / 4, start.Y + (end.Y - start.Y) * 3 / 4));
            list.Add(new Point(start.X + (end.X - start.X) / 4, start.Y + (end.Y - start.Y) * 3 / 4));
            foxDraw.DrawPolygon(list);

            count--;

            if (count > 0)
            {
                Point point1 = new Point(start.X + (end.X - start.X) / 2, start.Y);
                Point point2 = new Point(start.X, start.Y + (end.Y - start.Y) / 2);
                Point point3 = new Point(start.X + (end.X - start.X) / 2, start.Y + (end.Y - start.Y) / 2);
                Point point4 = new Point(end.X, start.Y + (end.Y - start.Y) / 2);
                Point point5 = new Point(start.X + (end.X - start.X) / 2, end.Y);

                SquarePorn(foxDraw, start, point3, count);
                SquarePorn(foxDraw, point1, point4, count);
                SquarePorn(foxDraw, point2, point5, count);
                SquarePorn(foxDraw, point3, end, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            SquarePorn(foxDraw, new Point(0, 0), new Point(300, 300), 4);
        }
    }
}
