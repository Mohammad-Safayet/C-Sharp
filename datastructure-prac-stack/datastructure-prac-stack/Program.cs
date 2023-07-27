namespace datastructure_prac_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine(String.Join(",", stack.ToArray()));
            Console.WriteLine("Popping: {0}", stack.Peek());
            stack.Pop();
            Console.WriteLine("Popping: {0}", stack.Peek());
            stack.Clear();
        }
    }
}
