// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
namespace CalculatorApplication
{
    class NumberMainpulator
    {
        public int FindMax(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }

        public int factorial(int num)
        {
            return num == 1 ? 1 : factorial(num - 1) * num;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 100;
            int ret;
            NumberMainpulator n = new NumberMainpulator();

            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是：{0}", ret);
            Console.ReadLine();
            
            Console.WriteLine("6的阶乘是：{0}", n.factorial(6));
            Console.WriteLine("7的阶乘是: {0}", n.factorial(7));
        }
    }
}