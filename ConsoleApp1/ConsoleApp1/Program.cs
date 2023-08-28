// See https://aka.ms/new-console-template for more information

using System.Drawing;

class HelloWorld
{
    static void Main(string[] args)
    {
        Rectangle r = new Rectangle();
        Console.WriteLine(r.ToString());
    }
    
    class Rectangele
    {
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}