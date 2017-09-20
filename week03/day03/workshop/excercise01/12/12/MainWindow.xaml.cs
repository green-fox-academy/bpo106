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

namespace _12
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

            int j = 0;
            for (int i = 1; i < 7; i++)
            {
                foxDraw.FillColor(Colors.MediumPurple);
                foxDraw.DrawRectangle(10 + j, 10 + j, 10*i, 10*i);
                if (j == 0)
                {
                    j += 10;
                }
                else
                {
                    j += i*10;
                }
            }
        }
    }
}
