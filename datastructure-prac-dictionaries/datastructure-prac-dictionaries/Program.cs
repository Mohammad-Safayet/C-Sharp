namespace datastructure_prac_dictinaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> superheros = new Dictionary<string, string>();

            superheros.Add("Super Man", "DC");
            superheros.Add("BatMan", "DC");
            superheros.Add("Iron Man", "Marvel");
            superheros.Add("The Flash", "DC");
            superheros.Add("Captin America", "Marvel");
            superheros.Add("Winter Soldier", "Marvel");
            superheros.Add("Ananta Jolil", "Banggal");

            foreach (string key in superheros.Keys)
            {
                Console.WriteLine($"{key}: {superheros[key]}");
            }

            Console.WriteLine("Contains Wonder Woman: {0}", superheros.ContainsValue("Wonder Woman"));
            Console.WriteLine("Total Superheros: {0}", superheros.Count);

            Console.WriteLine("Contains DC superheros: {0}", superheros.ContainsValue("DC"));
            superheros.Remove("Ananta Jolil");
            Console.WriteLine("Total Superheros: {0}", superheros.Count);
            superheros.Clear();
        }
    }
}
