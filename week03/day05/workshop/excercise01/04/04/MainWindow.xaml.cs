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

namespace _04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void DrawLines(FoxDraw foxDraw, Point start, Point end, int count)
        {
            foxDraw.StrokeColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Black);
            foxDraw.DrawLine(start.X + (end.X - start.X) / 3, start.Y, start.X + (end.X - start.X) / 3, end.Y);
            foxDraw.DrawLine(start.X + (end.X - start.X) / 1.5, start.Y, start.X + (end.X - start.X) / 1.5, end.Y);
            foxDraw.DrawLine(start.X, start.Y + (end.Y - start.Y) / 3, end.X, start.Y + (end.Y - start.Y) / 3);
            foxDraw.DrawLine(start.X, start.Y + (end.Y - start.Y) / 1.5, end.X, start.Y + (end.Y - start.Y) / 1.5);

            count--;

            if (count > 0)
            {
                DrawLines(foxDraw, new Point (start.X + (end.X - start.X) / 3, start.Y), new Point (start.X + (end.X - start.X) / 1.5, start.Y + (end.Y - start.Y) / 3), count);
                DrawLines(foxDraw, new Point (start.X + (end.X - start.X) / 3, start.Y + (end.Y - start.Y) / 1.5), new Point (start.X + (end.X - start.X) / 1.5, end.Y), count);
                DrawLines(foxDraw, new Point (start.X + (end.X - start.X) / 1.5, start.Y + (end.Y - start.Y) / 3), new Point (end.X, start.Y + (end.Y - start.Y) / 1.5), count);
                DrawLines(foxDraw, new Point (start.X, start.Y + (end.Y - start.Y) / 3), new Point (start.X + (end.X - start.X) / 3, start.Y + (end.Y - start.Y) / 1.5), count);
                DrawLines(foxDraw, new Point(start.X, start.Y), new Point(start.X + (end.X - start.X) / 3, start.Y + (end.Y - start.Y) / 3), count);
                DrawLines(foxDraw, new Point(start.X + (end.X - start.X) / 1.5, start.Y), new Point(end.X, start.Y + (end.Y - start.Y) / 3), count);
                DrawLines(foxDraw, new Point(start.X + (end.X - start.X) / 1.5, start.Y + (end.Y - start.Y) / 1.5), new Point(end.X, end.Y), count);
                DrawLines(foxDraw, new Point(start.X, start.Y + (end.Y - start.Y) / 1.5), new Point(start.X + (end.X - start.X) / 3, end.Y), count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw, new Point(0, 0), new Point(600, 600), 5);
        }
    }
}
