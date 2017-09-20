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

namespace _13
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

            for (int i = 0; i<30; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.FillColor(Colors.Black);
                    if (i % 2 == 0)
                    {
                        foxDraw.DrawRectangle(10*2*j, 10*i, 10, 10);
                    }
                    else
                    {
                        foxDraw.DrawRectangle(10 * (2 * j + 1), 10 * i, 10, 10);
                    }
                }
            }
        }
    }
}
