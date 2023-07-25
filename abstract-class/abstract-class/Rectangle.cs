namespace abstract_class
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override void area()
        {
            double area = Height * Width;
            Console.WriteLine("The area is: {0}", area);
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("The hight is {0} and the width is {1}", Height, Width);
        }
    }
}
