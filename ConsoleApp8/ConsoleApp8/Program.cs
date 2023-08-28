// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

using System.Globalization;

namespace jiecheng
{
    class jiecheng
    {
        public int Jc(int num)
        {
            return num > 0 ? num * Jc(num - 1) : 1;
        }
    }

    class excutejiecheng
    {
        static void Main(string[] args)
        {
            jiecheng n = new jiecheng();
            int res = n.Jc(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("result is {0}", res);
            Console.ReadKey();
        }
    }
}