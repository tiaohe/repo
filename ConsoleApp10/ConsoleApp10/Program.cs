﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.ComponentModel;

namespace ConsoleApp10
{
    class Show
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;

            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool();
            Console.WriteLine("显示可空类型的值：{0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("一个可空的布尔值：{0}", boolval);
            Console.ReadLine();
        }

    }
}

