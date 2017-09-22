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
        static void DrawCircle(FoxDraw foxDraw, double startx, double starty, double endx, double endy, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.Transparent);
            foxDraw.DrawEllipse(startx, starty, endx - startx, endy - starty);
            count--;

            if (count > 0)
            {
                DrawCircle(foxDraw, startx + (endx - startx) / 4, starty, startx + (endx - startx) * 3 / 4, starty + (endy - starty) / 2, count);
                DrawCircle(foxDraw, startx + 0.0335 * (endx - startx), starty + (endy - starty) * 3 / 8, startx + 0.5335 * (endx - startx), starty + (endy - starty) * 7 / 8, count);
                DrawCircle(foxDraw, startx + (1 - 0.5335) * (endx - startx), starty + (endy - starty) * 3 / 8, startx + (1 - 0.0335) * (endx - startx), starty + (endy - starty) * 7 / 8, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            DrawCircle(foxDraw, 0, 0, 300, 300, 5);
        }
    }
}
