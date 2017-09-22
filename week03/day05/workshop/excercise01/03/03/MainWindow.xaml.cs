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
        static void HexaDrawer (FoxDraw foxDraw, Point start, Point end, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Gray);

            var points = new List<Point>();
            points.Add(new Point(start.X + (end.X - start.X) / 4, start.Y));
            points.Add(new Point(start.X + (end.X - start.X) * 3 / 4, start.Y));
            points.Add(new Point(end.X, start.Y + (end.Y - start.Y) / 2));
            points.Add(new Point(start.X + (end.X - start.X) * 3 / 4, end.Y));
            points.Add(new Point(start.X + (end.X - start.X) / 4, end.Y));
            points.Add(new Point(start.X, start.Y + (end.Y - start.Y) / 2));

            foxDraw.DrawPolygon(points);

            count--;
            if (count > 0)
            {
                HexaDrawer(foxDraw, new Point(start.X + (end.X - start.X) / 6, start.Y), new Point (start.X + (end.X - start.X) / 2, start.Y + (end.Y - start.Y) / 3), count);
                HexaDrawer(foxDraw, new Point(start.X + (end.X - start.X) / 2, start.Y), new Point(start.X + (end.X - start.X) * 5 / 6, start.Y + (end.Y - start.Y) / 3), count);
                HexaDrawer(foxDraw, new Point(start.X, start.Y + (end.Y - start.Y) / 3), new Point(start.X + (end.X - start.X) / 3, start.Y + (end.Y - start.Y) * 2 / 3), count);
                HexaDrawer(foxDraw, new Point(start.X + (end.X - start.X) * 2 / 3, start.Y + (end.Y - start.Y) / 3), new Point(end.X, start.Y + (end.Y - start.Y) * 2 / 3), count);
                HexaDrawer(foxDraw, new Point(start.X + (end.X - start.X) / 6, start.Y + (end.Y - start.Y) * 2 / 3), new Point(start.X + (end.X - start.X) / 2, end.Y), count);
                HexaDrawer(foxDraw, new Point(start.X + (end.X - start.X) / 2, start.Y + (end.Y - start.Y) * 2 / 3), new Point(start.X + (end.X - start.X) * 5 / 6, end.Y), count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            HexaDrawer(foxDraw, new Point(0, 0), new Point(300, 259.8), 5);
        }
    }
}
