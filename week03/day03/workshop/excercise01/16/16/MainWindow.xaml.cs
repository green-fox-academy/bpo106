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

namespace _16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void WidenedGape(FoxDraw foxDraw, int x, int y)
        {
            for (int i = 0; i <= 150; i += 10)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(x + 0, y + i, x + i, y + 150);
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(x + i, y + 0, x + 150, y + i);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            WidenedGape(foxDraw, 0, 0);
            WidenedGape(foxDraw, 0, 150);
            WidenedGape(foxDraw, 150, 0);
            WidenedGape(foxDraw, 150, 150);
        }
    }
}
