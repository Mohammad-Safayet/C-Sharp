namespace inner_class_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle.Owner owner = new Vehicle.Owner("Safayet Latif");
            Vehicle vehicle = new Vehicle("Ferrari", owner);

            vehicle.owner.getInfo();

            Vehicle gmc = new Vehicle("GMC");
            gmc.getInfo();
        }
    }
}
