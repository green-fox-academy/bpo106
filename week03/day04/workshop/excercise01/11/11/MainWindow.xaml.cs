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

namespace _11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void DrawLines (FoxDraw foxDraw, double startx, double starty, double endx, double endy, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(startx + (endx - startx) / 3, starty, startx + (endx - startx) / 3, endy);
            foxDraw.DrawLine(startx + (endx - startx) / 1.5, starty, startx + (endx - startx) / 1.5, endy);
            foxDraw.DrawLine(startx, starty + (endy - starty) / 3, endx, starty + (endy - starty) / 3);
            foxDraw.DrawLine(startx, starty + (endy - starty) / 1.5, endx, starty + (endy - starty) / 1.5);

            count--;

            if (count > 0)
            {
                DrawLines(foxDraw, startx + (endx - startx) / 3, starty, startx + (endx - startx) / 1.5, starty + (endy - starty) / 3, count);
                DrawLines(foxDraw, startx + (endx - startx) / 3, starty + (endy - starty) / 1.5, startx + (endx - startx) / 1.5, endy, count);
                DrawLines(foxDraw, startx + (endx - startx) / 1.5, starty + (endy - starty) / 3, endx, starty + (endy - starty) / 1.5, count);
                DrawLines(foxDraw, startx, starty + (endy - starty) / 3, startx + (endx - startx) / 3, starty + (endy - starty) / 1.5, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Yellow);
            DrawLines(foxDraw, 0, 0, 300, 300, 5);
        }
    }
}
