using System.Collections;

namespace datastructure_prac_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue("2");
            queue.Enqueue("John");
            queue.Enqueue(true);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"1st item: {queue.Peek()}");

            queue.Dequeue();
            Console.WriteLine($"1st item: {queue.Peek()}");

            Console.WriteLine("Total items: {0}", queue.Count);
            Console.WriteLine("Contains John: {0}", queue.Contains("John"));
            Console.WriteLine("Contains Jane: {0}", queue.Contains("Jane"));

            queue.Clear();
        }

    }
}
