namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            // for loop 
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();

            // ForEach loop
            foreach (int i in arr)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            // while loop
            int index = 0;
            while (index < arr.Length)
            {
                Console.Write(arr[index]);
                index++;
            }
        }
    }
}