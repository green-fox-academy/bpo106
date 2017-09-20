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

namespace _19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random random = new Random();
            foxDraw.BackgroundColor(Colors.Black);

            for (int i = 0; i < 42; i++)
            {
                int x = random.Next(0, 300);
                int y = random.Next(0, 300);
                int z = random.Next();

                foxDraw.FillColor(Color.FromRgb((byte)z, (byte)z, (byte)z));
                foxDraw.StrokeColor(Color.FromRgb((byte)z, (byte)z, (byte)z));
                foxDraw.DrawRectangle(x, y, 5, 5);
            }
        }
    }
}
