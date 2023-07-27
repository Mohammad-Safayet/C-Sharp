namespace interface_prac
{
    class VehicleKey : ICommand
    {
        private Vehicle vehicle;

        public VehicleKey(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Execute()
        {
            vehicle.start();
        }

        public void Undo()
        {
            vehicle.stop();
        }
    }
}
