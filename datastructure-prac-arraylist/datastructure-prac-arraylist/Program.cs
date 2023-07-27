using System.Collections;

namespace datastructure_prac_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);

            foreach (var item in arrayList)
            {
                Console.Write("{0}\t", item);
            }
            Console.WriteLine();
            Console.WriteLine($"Total items {arrayList.Count}");

            arrayList.Remove(1);
            arrayList.RemoveRange(2, 2);
            Console.WriteLine($"Total items {arrayList.Count}");

            Console.WriteLine($"Total capacity {arrayList.Capacity}");

            Console.WriteLine($"Contains 1 : {arrayList.Contains(1)}");
            Console.WriteLine($"Contains 2 : {arrayList.Contains(2)}");
            arrayList.Clear();
        }
    }
}
