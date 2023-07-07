namespace OutputFormation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Format output for currency
            Console.WriteLine("Currency : {0:c}", 23.455);

            // Pad with zeroes
            Console.WriteLine("Pad with 0s : {0:d4}", 23);

            // Define decimals
            Console.WriteLine("3 Decimals : {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas : {0:n4}", 2300);

            Console.WriteLine("------------------------------------------");

            string str = "This is a string";

            Console.WriteLine($"default: {str}");
            Console.WriteLine($"uppercase: {str.ToUpper()}");
            Console.WriteLine($"lowercase: {str.ToLower()}");
            Console.WriteLine($"padLeft: {str.PadLeft(25, '-')}");
            Console.WriteLine($"padRight: {str.PadRight(25, '-')}");

            // Get number of characters in string
            Console.WriteLine("String Length : {0}", str.Length);

            // Check if string contains other string
            Console.WriteLine("String Contains is : {0}",
                str.Contains("is"));

            // Index of string match
            Console.WriteLine("Index of is : {0}",
                str.IndexOf("is"));

            // Remove number of characters starting at an index
            Console.WriteLine("Remove string : {0}",
                str.Remove(10, 6));

            // Add a string starting at an index
            Console.WriteLine("Insert String : {0}",
                str.Insert(10, "short "));

            // Replace a string with another
            Console.WriteLine("Replace String : {0}",
                str.Replace("string", "sentence"));
        }
    }
}