namespace EnumeratedTypes
{
    class Program
    {
        enum Gender
        {
            male,
            female,
        }

        enum DevPosition: byte
        {
            intern = 10,
            junior,
            senior,
        }
        static void Main(string[] args)
        {
            Gender gender = Gender.female;
            Console.WriteLine("Enum is {0} with code {1}",gender, (int)gender);

            DevPosition devPosition = DevPosition.senior;
            Console.WriteLine("The position is {0} with code {1}",devPosition, (int)devPosition);
        }
    }
}
