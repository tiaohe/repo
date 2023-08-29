// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");
using first_space;
using second_space;

namespace first_space
{
    class abs
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass
{
    static void Main(string[] args)
    {
        abs fc = new abs();
        efg sc = new efg();
        
        fc.func();
        sc.func();

        Console.ReadKey();
    }

}