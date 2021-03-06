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

namespace Steps3D
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
            DrawRectangle(foxDraw);
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            double a = 10;
            double start = 10;
            foxDraw.StrokeColor(Colors.Purple);
            foxDraw.FillColor(Colors.Purple);
            for (int i = 1; i < 6; i++)
            {

                foxDraw.DrawRectangle(start, start, a * i, a * i);
                start = start + (a * i);
            }
        }
    }
}
