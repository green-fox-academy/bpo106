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

namespace _02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void DrawCircle(FoxDraw foxDraw, Point start, Point end, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Transparent);
            foxDraw.DrawEllipse(start.X, start.Y, end.X - start.X, end.Y - start.Y);
            count--;

            if (count > 0)
            {
                Point point1 = new Point(start.X + (end.X - start.X) / 4, start.Y);
                Point point2 = new Point(start.X + (end.X - start.X) * 3 / 4, start.Y + (end.Y - start.Y) / 2);
                Point point3 = new Point(start.X + 0.0335 * (end.X - start.X), start.Y + (end.Y - start.Y) * 3 / 8);
                Point point4 = new Point(start.X + 0.5335 * (end.X - start.X), start.Y + (end.Y - start.Y) * 7 / 8);
                Point point5 = new Point(start.X + (1 - 0.5335) * (end.X - start.X), start.Y + (end.Y - start.Y) * 3 / 8);
                Point point6 = new Point(start.X + (1 - 0.0335) * (end.X - start.X), start.Y + (end.Y - start.Y) * 7 / 8);

                DrawCircle(foxDraw, point1, point2, count);
                DrawCircle(foxDraw, point3, point4, count);
                DrawCircle(foxDraw, point5, point6, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            DrawCircle(foxDraw, new Point(0, 0), new Point(600, 600), 5);
        }
    }
}
