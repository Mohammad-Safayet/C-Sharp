namespace class_prac_ii
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal roxy = new Animal();
            roxy.Name = "Roxy";
            roxy.Age = 10;
            roxy.Sound = "woof";

            Console.WriteLine(roxy.id);

            roxy.getInfo();
            roxy.pet();

        }
    }
}
