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

namespace StarryNight
{
    public partial class MainWindow : Window
    {
        public static Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.BackgroundColor(Colors.Black);
            for (int i = 0; i < 15; i++)
            {
                DrawStars(foxDraw);
            }

        }
        public static void DrawStars(FoxDraw foxDraw)
        {
            int x = rnd.Next(0, 340);
            int y = rnd.Next(0, 515);
            byte gray = Convert.ToByte(rnd.Next(0, 255));
            foxDraw.StrokeColor(Color.FromRgb(gray, gray, gray));
            foxDraw.FillColor(Color.FromRgb(gray, gray, gray));
            foxDraw.DrawRectangle(y, x, 6, 6);
        }
    }
}
