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

namespace _03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(100, 100));
            points.Add(new Point(100, 200));
            points.Add(new Point(200, 200));
            points.Add(new Point(200, 100));

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(points[0], points[1]);
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(points[1], points[2]);
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(points[2], points[3]);
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(points[3], points[0]);
        }

        public static void DrawDiagonal(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(100, 100));
            points.Add(new Point(100, 200));
            points.Add(new Point(200, 200));
            points.Add(new Point(200, 100));

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(points[0], points[2]);
            foxDraw.DrawLine(points[1], points[3]);
        }

        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            // draw the canvas' diagonals in green.
            DrawRectangle(foxDraw);

            DrawDiagonal(foxDraw);

        }
    }
}
