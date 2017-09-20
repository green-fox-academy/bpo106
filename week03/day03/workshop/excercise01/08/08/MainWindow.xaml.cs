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

namespace _08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Drawer(int x, int y, FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(x, y, 50, 50);
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int x = random.Next(0, 300);
                int y = random.Next(0, 300);
                Drawer(x, y, foxDraw);
            }
        }
    }
}
