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

namespace _12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static void DrawSix (FoxDraw foxDraw, double startx, double starty, double endx, double endy, int count)
        {
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.FillColor(Colors.White);

            var points = new List<Point>();
            points.Add(new Point(startx + (endx - startx) / 4, starty));
            points.Add(new Point(startx + (endx - startx) * 3 / 4, starty));
            points.Add(new Point(endx, starty + (endy - starty) / 2));
            points.Add(new Point(startx + (endx - startx) * 3 / 4, endy));
            points.Add(new Point(startx + (endx - startx) / 4, endy));
            points.Add(new Point(startx, starty + (endy - starty) / 2));

            foxDraw.DrawPolygon(points);

            count--;
            if (count > 0)
            {
                DrawSix(foxDraw, startx + (endx - startx) / 2, starty + (endy - starty) / 4, endx, starty + (endy - starty) * 3 / 4, count);
                DrawSix(foxDraw, startx + (endx - startx) / 8, starty, startx + (endx - startx) * 5 / 8, starty + (endy - starty) / 2, count);
                DrawSix(foxDraw, startx + (endx - startx) / 8, starty + (endy - starty) / 2, startx + (endx - startx) * 5 / 8, endy, count);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawSix(foxDraw, 0, 0, 300, 260, 5);
        }
    }
}
