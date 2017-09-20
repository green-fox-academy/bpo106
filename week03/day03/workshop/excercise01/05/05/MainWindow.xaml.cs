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

namespace _05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static void Drawer(FoxDraw foxDraw, int x, int y)
        {
            int x2 = Math.Max(x + 50, 300);
            var startPoint = new Point(x, y);
            var endPoint = new Point(x2, y);

            foxDraw.DrawLine(startPoint, endPoint);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            // create a line drawing function that takes 2 parameters:
            // the x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // draw 3 lines with that function.

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int x = random.Next(0, 300);
                int y = random.Next(0, 300);
                Drawer(foxDraw, x, y);
            }

        }
    }
}
