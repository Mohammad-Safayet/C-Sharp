namespace interface_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = (Vehicle)Keys.getVehicleKeys("Ferrari", "420");

            VehicleKey vehicleKey = new VehicleKey(vehicle);
            AcceleratorPedal accelerator = new AcceleratorPedal(vehicle);

            vehicleKey.Execute();

            accelerator.Execute();
            accelerator.Execute();
            accelerator.Execute();
            accelerator.Execute();
            accelerator.Execute();
            accelerator.Undo();
            accelerator.Undo();

            vehicleKey.Undo();
        }
    }
}
