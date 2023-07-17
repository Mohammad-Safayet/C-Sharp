namespace ExceptionHandling
{
    class Program
    {
        static int divide(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handeling");
            int num1 = 10;
            int num2 = 0;

            try
            {
                int result = divide(num1, num2);
            }
            catch (DivideByZeroException excption)
            {
                Console.WriteLine(excption.Message);
            } finally { Console.WriteLine("the final message is fix the code"); }
        }
    }
}