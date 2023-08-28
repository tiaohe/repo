// See https://aka.ms/new-console-template for more information

namespace qwer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            int b = 13;
            int c ;

            c = a & b;
            Console.WriteLine("c = {0}", c);
            
            c = a | b;
            Console.WriteLine("c = {0}", c);
            
            c = a ^ b;
            Console.WriteLine("c = {0}", c);
            
            c = ~a;
            Console.WriteLine("c = {0}", c);
            
            c = a << 2;
            Console.WriteLine("c = {0}", c);
            
            c = a >> 2;
            Console.WriteLine("c = {0}", c);
            Console.ReadLine();
            
            Console.WriteLine("int的大小是{0}",typeof(int));
            Console.WriteLine("short的大小是{0}", typeof(short));
            Console.WriteLine("double的大小是{0}", typeof(double));

            int a1, b1;
            a1 = 10;
            b1 = (a1 == 1) ? 20 : 30;
            Console.WriteLine("b 的值是{0}", b1);

            b1 = (a1 == 10) ? 20 : 30;
            Console.WriteLine("b 的值是{0}", b1);
            Console.ReadLine();
            
            
            
        }
    }
}