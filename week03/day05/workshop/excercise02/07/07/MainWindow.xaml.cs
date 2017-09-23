﻿using System;
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

namespace _07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void DrawTriangle(FoxDraw foxDraw, Point start, Point end, int count)
        {
            List<Point> list = new List<Point>();
            list.Add(new Point(start.X + (end.X - start.X) / 3, start.Y + (end.Y - start.Y) / 3));
            list.Add(new Point(start.X + (end.X - start.X) * 2 / 3, start.Y + (end.Y - start.Y) * 2 / 3));

            list.Add(new Point(list[0].X + (list[1].X - list[0].X) / 2 - 1.732 * (list[0].Y - list[1].Y) / 2, list[0].Y - (list[0].Y - list[1].Y) / 2 - 1.732 * (list[1].X - list[0].X) / 2));

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawLine(start, list[0]);
            foxDraw.DrawLine(list[0], list[2]);
            foxDraw.DrawLine(list[1], list[2]);
            foxDraw.DrawLine(list[1], end);

            count--;

            if (count > 0)
            {
                DrawTriangle(foxDraw, list[0], list[2], count);
                DrawTriangle(foxDraw, list[2], list[1], count);
                DrawTriangle(foxDraw, start, list[0], count);
                DrawTriangle(foxDraw, list[1], end, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var points = new List<Point>();
            var foxDraw = new FoxDraw(canvas);

            DrawTriangle(foxDraw, new Point(150, 0), new Point(300, 259.8), 5);
            DrawTriangle(foxDraw, new Point(300, 259.8), new Point(0, 259.8), 5);
            DrawTriangle(foxDraw, new Point(0, 259.8), new Point(150, 0), 5);
        }
    }
}
