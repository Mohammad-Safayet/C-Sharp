namespace StructType
{
    class Program
    {
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public double Area()
            {
                return length *  width;
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.length = 100;
            rect.width = 40;
            Console.WriteLine("The are of the rect is {0}", rect.Area());

            Rectangle rect2 = new Rectangle(200, 30);
            rect2 = rect;

            rect.width = 60;
            Console.WriteLine("The width of rect is {0} and the width of rect2 is {1}", rect.width, rect2.width);
        }
    }
}