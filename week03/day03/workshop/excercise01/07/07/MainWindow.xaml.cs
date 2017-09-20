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

namespace _07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static void Color(FoxDraw foxDraw, System.Windows.Media.Color x)
        {
            foxDraw.FillColor(x);
            foxDraw.StrokeColor(x);
        }

        public static void DrawRectangle(FoxDraw foxDraw, int a, int b, int c, int d, System.Windows.Media.Color x)
        {
            foxDraw.FillColor(x);
            foxDraw.StrokeColor(x);
            foxDraw.DrawRectangle(a, b, c, d);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawRectangle(foxDraw, 210, 220, 30, 40, Colors.Green);
            DrawRectangle(foxDraw, 150, 140, 30, 20, Colors.Black);
            DrawRectangle(foxDraw, 6, 9, 42, 54, Colors.Red);
            DrawRectangle(foxDraw, 0, 200, 10, 10, Colors.Blue);
        }
    }
}
