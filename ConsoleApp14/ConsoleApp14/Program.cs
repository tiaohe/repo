﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
public class EnumTest
{
    enum Day
    {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat
    }

    static void Main()
    {
        int x = (int)Day.Sun;
        int y = (int)Day.Fri;
        
        Console.WriteLine("Sun = {0}", x);
        Console.WriteLine("Fri = {0}", y);
        
    }
}

