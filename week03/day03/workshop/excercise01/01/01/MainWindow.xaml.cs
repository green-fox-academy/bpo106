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
        public static void DrawLines(FoxDraw foxDraw)
        {
            var startPoint1 = new Point(0, 150);
            var endPoint1 = new Point(300, 150);
            var startPoint2 = new Point(150, 0);
            var endPoint2 = new Point(150, 300);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(startPoint1, endPoint1);

            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(startPoint2, endPoint2);
        }

        public MainWindow()
        {
            InitializeComponent();

            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw);
        }
    }
}
