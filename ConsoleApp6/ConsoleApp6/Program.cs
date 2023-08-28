// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

namespace OperatorsApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21, b = 10, c;
            c = a + b;
            Console.WriteLine("c = {0}", c);
            c = a - b;
            Console.WriteLine("c = {0}", c);
            c = a * b;
            Console.WriteLine("c = {0}", c);
            c = a / b;
            Console.WriteLine("c = {0}", c);
            c = a % b;
            Console.WriteLine("c = {0}", c);

            c = ++a;
            Console.WriteLine("c = {0}", c);

            c = --a;
            Console.WriteLine("c = {0}", c);
            Console.ReadLine();

            if (a == b)
            {
                Console.WriteLine(a == b);
            }
            else
            {
                Console.WriteLine(a == b);
            }

            if (a < b)
            {
                Console.WriteLine(a < b);
            }
            else
            {
                Console.WriteLine(a > b);
            }

            a = 5;
            b = 20;

            if (a <= b)
            {
                Console.WriteLine(a <= b);
            }

            if (b >= a)
            {
                Console.WriteLine(b >= a);
            }

            bool a1 = true;
            bool b1 = true;

            if (a1 && b1)
            {
                Console.WriteLine(a1 && b1);
            }

            if (a1 || b1)
            {
                Console.WriteLine(a1 || b1);
            }

            a1 = false;
            b1 = true;
            if (a1 && b1)
            {
                Console.WriteLine(a1 && b1);
            }
            else
            {
                Console.WriteLine(a1 && b1);
            }

            if (!(a1 && b1))
            {
                Console.WriteLine(!(a1 && b1));
            }
            Console.ReadLine();
        }
    }
}