﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperCandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyShop candyShop = new CandyShop(300);
            candyShop.CreateSweets("candy");
            candyShop.CreateSweets("candy");
            candyShop.CreateSweets("lollipop");
            candyShop.CreateSweets("lollipop");
            candyShop.PrintInfo();
            candyShop.Sell("candy", 1);
            candyShop.PrintInfo();
            candyShop.Raise(5);
            candyShop.Sell("lollipop", 1);
            candyShop.PrintInfo();
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            Console.ReadKey();
        }
    }
}
