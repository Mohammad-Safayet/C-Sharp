namespace abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(2.0d), new Rectangle(5.8, 6.4) };

            foreach (var shape in shapes)
            {
                shape.getInfo();

                shape.area();
            }
        }
    }
}
