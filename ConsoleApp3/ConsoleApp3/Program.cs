// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

namespace ConsoleApp3
{
    class Apple
    {
        static void Main(string[] args)
        {
            byte b = 10;
            int i = b; //隐式转换，不需要显示转换

            int intValue = 42;
            long longValue = intValue;
            Console.WriteLine(longValue);

            int i1 = 10;
            byte b1 = (byte)i;

            double doubleValue = 3.14;
            int intValue1 = (int)doubleValue;
            Console.WriteLine(intValue1);
        }
    }
}

