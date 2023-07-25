namespace abstract_class
{
    abstract class Shape
    {
        public string type;
        public abstract void area();

        public virtual void getInfo()
        {
            Console.WriteLine("This shape is {0}", type);
        }
    }
}
