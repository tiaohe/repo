// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Hello, World!");

namespace InteritanceAppcation
{
    class Shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }

    class Rectangle : Shape
    {
        public int getArea()
        {
            return width * height;
        }
    }

    class RectangeleTester
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.setWidth(5);
            r.setHeight(7);
            Console.WriteLine("Total area: {0}", r.getArea());
            Console.ReadKey();
        }
    }
}


