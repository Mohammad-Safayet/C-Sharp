namespace GuessingGame
{
    class Game
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any key to start!");
            Console.ReadLine();

            Random random = new Random();
            int result = random.Next(1, 51);
            bool isSolved = false;

            do
            {
                Console.WriteLine("Enter any number in between 1 - 51:");
                int ans = Convert.ToInt32(Console.ReadLine());
                isSolved = ans == result;

            } while (!isSolved);
        }
    }
}
