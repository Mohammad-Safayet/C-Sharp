namespace Fuctions
{
    class Program
    {
        static int addNum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void incrementNum(int num, out int solution)
        {
            solution = num + 2;
        }

        static void swap(ref int num01, ref int num02)
        {
            int temp = num01;
            num01 = num02;
            num02 = temp;
        }

        static int getSum(params int[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }

            return sum;
        }
        
        static int getSum(params string[] nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += Convert.ToInt32(item);
            }

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("add: {0}", addNum(num1, num2));

            Console.WriteLine();
            Console.WriteLine("Out param Fuctions, Input a number to increment");
            int solution = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            incrementNum(num, out solution);
            Console.WriteLine("increment: {0}", solution);

            Console.WriteLine() ;
            Console.WriteLine("Ref Functions, Input two nums to swap"); 
            int num01 = Convert.ToInt32(Console.ReadLine());
            int num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap num1: {0} num2: {1}", num01, num02);
            swap(ref num01, ref num02);
            Console.WriteLine("After swap num1: {0} num2: {1}", num01, num02);

            Console.WriteLine();
            Console.WriteLine("Unknown numbers param");
            int item1 = 10;
            int item2 = 20;
            int item3 = 30;
            int item4 = 40;
            int item5 = 50;
            int item6 = 60;
            Console.WriteLine("The sum is: {0}", getSum(item1, item2, item3, item4, item5, item6));
            
            Console.WriteLine();
            Console.WriteLine("Method overloading");
            string item10 = "10";
            string item20 = "20";
            string item30 = "30";
            string item40 = "40";
            string item50 = "50";
            string item60 = "60";
            Console.WriteLine("The sum is: {0}", getSum(item10, item20, item30, item40, item50, item60));

        }
    }
}