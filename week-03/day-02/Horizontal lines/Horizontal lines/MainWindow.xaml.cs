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

namespace Horizontal_lines
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            DrawLines(foxDraw, 10, 20);
            DrawLines(foxDraw, 40, 50);
            DrawLines(foxDraw, 100, 65);
        }
        public static void DrawLines(FoxDraw foxDraw, double a, double b)
        {
            foxDraw.StrokeColor(Colors.CadetBlue);
            foxDraw.DrawLine(a, b, (a + 50), b);
        }
    }
}
