﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
public class ConstTest
{
    class SampleClass
    {
        public int x;
        public int y;
        public const int c1 = 5;
        public const int c2 = c1 + 5;

        public SampleClass(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    static void Main()
    {
        SampleClass mc = new SampleClass(11, 12);
        Console.WriteLine("x = {0}, y = {1}", mc.x, mc.y);
        Console.WriteLine("c1 = {0}, c2 = {1}", SampleClass.c1, SampleClass.c2);
    }
}