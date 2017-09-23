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

namespace _08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void TreeDraw(FoxDraw foxDraw, Point start, Point end, int count)
        {
            foxDraw.BackgroundColor(Colors.DarkBlue);
            foxDraw.StrokeColor(Colors.Yellow);

            List<Point> points = new List<Point>();

            points.Add(new Point(end.X - 0.8 * ( 0.866 * (start.X - end.X) - (start.Y - end.Y) / 2), end.Y - 0.8 * (0.866 * (start.Y - end.Y) + (start.X - end.X) / 2)));
            points.Add(new Point(end.X - 0.8 * (start.X - end.X), end.Y - 0.8 * (start.Y - end.Y)));
            points.Add(new Point(end.X - 0.8* (0.866 * (start.X - end.X) + (start.Y - end.Y) / 2), end.Y - 0.8 * (0.866 * (start.Y - end.Y) - (start.X - end.X) / 2)));

            foxDraw.DrawLine(start, end);

            count--;

            if (count >0)
            {
                TreeDraw(foxDraw, end, points[0], count);
                TreeDraw(foxDraw, end, points[1], count);
                TreeDraw(foxDraw, end, points[2], count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Point start = new Point(300, 500);
            Point end = new Point(300, 400);

            TreeDraw(foxDraw, start, end, 10);
        }
    }
}
