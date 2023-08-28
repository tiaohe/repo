﻿// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

namespace StringApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            
            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);
            
            //通过使用 string 构造函数
            char[] letters = {'H', 'e', 'l', 'l', 'o'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            
            //方法返回字符串
            string[] sarray = {"Hello", "From", "Tutorials", "Point"};
            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);
            
            //用于转换值的格式化方法
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            Console.ReadKey();
        }
    }
}

