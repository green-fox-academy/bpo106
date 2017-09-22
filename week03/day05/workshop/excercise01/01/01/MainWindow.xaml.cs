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

namespace _01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void DrawTriangle(FoxDraw foxDraw, double startx, double starty, double endx, double endy, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Gray);

            var points = new List<Point>();
            points.Add(new Point(startx, starty));
            points.Add(new Point(endx, starty));
            points.Add(new Point(startx + (endx - startx) / 2, endy));
            foxDraw.DrawPolygon(points);

            var points2 = new List<Point>();
            points2.Add(new Point(startx + (endx - startx) / 2, starty));
            points2.Add(new Point(startx + (endx - startx) / 4, starty + (endy - starty) / 2));
            points2.Add(new Point(startx + (endx - startx) * 3 / 4, starty + (endy - starty) / 2));
            foxDraw.DrawPolygon(points2);

            count--;
            if (count > 0)
            {
                DrawTriangle(foxDraw, startx + (endx - startx) / 2, starty, endx, starty + (endy - starty) / 2, count);
                DrawTriangle(foxDraw, startx, starty, startx + (endx - startx) / 2, starty + (endy - starty) / 2, count);
                DrawTriangle(foxDraw, startx + (endx - startx) / 4, starty + (endy - starty) / 2, startx + (endx - startx) * 3 / 4, endy, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            DrawTriangle(foxDraw, 0, 0, 2*300, 2*259.8, 6);
        }
    }
}