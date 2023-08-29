// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

#define PI
#define VC_V10

namespace PreprocessorDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #if (PI)
                Console.WriteLine("PI is defined");
            #else
                Console.WriteLine("PI is not defined");
            #endif
            
            #if (DEBUG && !VC_V10)
                Console.WriteLine("DEBUG is defined");
            #elif (!DEBUG && VC_V10)
                Console.WriteLine("VC_V10 is defined");
            #elif (DEBUG && VC_V10)
                Console.WriteLine("DEBUG and VC_V10 are defined");
            #endif
            
            Console.ReadKey();
        }
    }
}