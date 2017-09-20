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

namespace _09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Drawer (int x, FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(150 - x/2, 150 - x/2, x, x);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Drawer(50, foxDraw);
            foxDraw.StrokeColor(Colors.White);
            Drawer(40, foxDraw);
            Drawer(30, foxDraw);
        }
    }
}
