namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal roxy = new Dog("Roxy", 4);

            (roxy as Dog).getInfo();
        }
    }
}
