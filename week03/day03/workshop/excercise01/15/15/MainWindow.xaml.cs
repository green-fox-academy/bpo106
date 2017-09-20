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

namespace _15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void WidenedGape(FoxDraw foxDraw)
        {
            for (int i = 0; i <= 300; i+=20)
            {
                foxDraw.StrokeColor(Colors.Green);
                foxDraw.DrawLine(0, i, i, 300);
                foxDraw.StrokeColor(Colors.Purple);
                foxDraw.DrawLine(i, 0, 300, i);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            WidenedGape(foxDraw);
        }
    }
}
