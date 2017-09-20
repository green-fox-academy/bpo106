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

namespace _18
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Connect (List<Point> list, FoxDraw foxDraw)
        {
            for (int i = 0; i < list.Count; i++)
            {
                foxDraw.DrawLine(list[0], list[1]);
                list.Add(list[0]);
                list.Remove(list[0]);
            }

        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            List<Point> list1 = new List<Point>();
            Connect(list1, foxDraw);
        }
    }
}
