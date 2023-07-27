namespace interface_prac
{
    class Keys
    {
        public static IEngine getVehicleKeys(string brand, string model) { return new Vehicle(brand, model); }
    }
}
