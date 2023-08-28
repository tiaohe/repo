// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

namespace HelloWorld
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            int i, j;

            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }

            foreach (int k in n)
            {
                int t = j - 100;
                Console.WriteLine("Element[{0}] = {1}", t, k);
            }

            Console.ReadKey();
        }
    }
}