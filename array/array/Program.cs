namespace ArrayTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            Console.WriteLine(nums.Length);

            Console.WriteLine("First element in the nums: {0}", nums.First());
            Console.WriteLine("Last element in the nums: {0}", nums.Last());
            
            Console.WriteLine("---------------------------------------------");

            object[] objects = { "Bob", 30.14D, 652, 65.33256M, true};
            for (int i = 0; i < objects.Length; i++)
            {
                Console.WriteLine("type: {0}\tValue: {1}\n",objects[i].GetType(), objects[i]);
            }

            Console.WriteLine("---------------------------------------------");

            string[,] values = { { "Bob", "Jones" }, { "Joe", "Biden" } };

            Console.WriteLine(values[1,0]);
        }
    }
}