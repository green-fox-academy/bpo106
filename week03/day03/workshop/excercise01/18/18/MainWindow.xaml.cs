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
                foxDraw.StrokeColor(Colors.Green);
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
            List<Point> list2 = new List<Point>();

            Point l0 = new Point(10, 10);
            Point l1 = new Point(290, 10);
            Point l2 = new Point(290, 290);
            Point l3 = new Point(10, 290);
            list1.Add(l0);
            list1.Add(l1);
            list1.Add(l2);
            list1.Add(l3);

            Point l4 = new Point(50, 100);
            Point l5 = new Point(70, 70);
            Point l6 = new Point(80, 90);
            Point l7 = new Point(90, 90);
            Point l8 = new Point(100, 70);
            Point l9 = new Point(120, 100);
            Point l10 = new Point(85, 130);
            Point l11 = new Point(50, 100);
            list1.Add(l4);
            list1.Add(l5);
            list1.Add(l6);
            list1.Add(l7);
            list1.Add(l8);
            list1.Add(l9);
            list1.Add(l10);
            list1.Add(l11);

            Connect(list1, foxDraw);
            Connect(list2, foxDraw);
        }
    }
}
