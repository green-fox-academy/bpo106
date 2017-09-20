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

namespace _10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void TripTheFckOut (FoxDraw foxDraw, int size, Color x)
        {
            List<Color> list = new List<Color>();
            list.Add(Colors.Red);
            list.Add(Colors.Orange);
            list.Add(Colors.Yellow);
            list.Add(Colors.Green);
            list.Add(Colors.Blue);
            list.Add(Colors.Purple);
            
            while (list[0] != x)
            {
                list.Add(list[0]);
                list.Remove(list[0]);
            }

            for (; size > 0; size -= 10)
            {
                foxDraw.FillColor(list[0]);
                foxDraw.DrawRectangle(150 - size/2, 150 - size / 2, size, size);
                list.Add(list[0]);
                list.Remove(list[0]);
            }

        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);

            int size = 250;

            TripTheFckOut(foxDraw, size, Colors.Red);
        }
    }
}
