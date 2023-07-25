namespace abstract_class
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            type = "Circle";
        }

        public override void area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area is: {area}");
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("The radius is: {0}", radius);
        }
    }
}
