namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine("max value of int is {0} and min value of int is {1}", intMax, intMin);

            long longMax = long.MaxValue;
            long longMin = long.MinValue;
            Console.WriteLine("max value of long is {0} and min value of long is {1}", longMax, longMin);

            float floatMax = float.MaxValue;
            float floatMin = float.MinValue;
            Console.WriteLine("max value of float is {0} and min value of float is {1}", floatMax, floatMin);
            Console.WriteLine("max value of double is {0} and min value of double is {1}",
                double.MaxValue,
                double.MinValue
            );
            Console.WriteLine("max value of decimal is {0} and min value of decimal is {1}", 
                decimal.MaxValue, 
                decimal.MinValue
            );

            float myValue = 3.1416F;
            Console.WriteLine("my value f: {0}", myValue);

            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

        }
    }
}
