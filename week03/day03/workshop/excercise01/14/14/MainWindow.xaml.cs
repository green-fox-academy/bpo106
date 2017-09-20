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

namespace _14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void RapingLines(int x, int y, FoxDraw foxDraw)
        {
            foxDraw.DrawLine(x, y, 150, 150);

            for (int i = 0; i < 15; i++)
            {
                foxDraw.DrawLine(0, 20 * (i + 1), 150, 150);
                foxDraw.DrawLine(300, 20 * i, 150, 150);
                foxDraw.DrawLine(20 * i, 0, 150, 150);
                foxDraw.DrawLine(20 * (i + 1), 300, 150, 150);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            Random random = new Random();
            int x = random.Next(0, 300);
            int y = random.Next(0, 300);

            RapingLines(x, y, foxDraw);
        }
    }
}
