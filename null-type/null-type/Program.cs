namespace NullType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine("is num is null? answer: {0}", num == null);
            Console.WriteLine("does num has value? answer: {0}", num.HasValue);

            num = 50;
            Console.WriteLine("is num is null? answer: {0}", num == null);
            Console.WriteLine("does num has value? answer: {0}", num.HasValue);
        }
    }
}
