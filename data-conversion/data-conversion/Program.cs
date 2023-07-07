namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Numerical data conversion - Explicit Conversion
            int value = 420;
            float valueF = (float)value;
            Console.WriteLine(valueF);

            // Numerical data conversion - Implicit Conversion
            int value2 = 100;
            long valueL = value2;
            Console.WriteLine(valueL);

            float value3 = 2.5f;
            double valueD = value3;
            Console.WriteLine(valueD);


            // String to Numerical data conversion
            string valueG = "69";
            int valueI = int.Parse(valueG);
            Console.WriteLine(valueI);

            // Get data type
            string str = "Hello";
            Console.WriteLine(str.GetType());
        }
    }
}
