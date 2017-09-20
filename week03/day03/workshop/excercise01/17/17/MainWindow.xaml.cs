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

namespace _17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void LineDrawer(FoxDraw foxDraw, int x1, int y1, int x2, int y2)
        {
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(x1, y1, x2, y2);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            for (int i = 0; i <= 150; i += 10)
            {
                LineDrawer(foxDraw, 150, i, 150 - i, 150);
                LineDrawer(foxDraw, 150, i, 150 + i, 150);
                LineDrawer(foxDraw, i, 150, 150, 150 + i);
                LineDrawer(foxDraw, 150, 300 - i, 150 + i, 150);
            }
        }
    }
}
