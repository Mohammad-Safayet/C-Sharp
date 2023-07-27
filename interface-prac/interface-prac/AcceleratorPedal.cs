namespace interface_prac
{
    class AcceleratorPedal : ICommand
    {
        private IEngine vehicle;

        public AcceleratorPedal(IEngine vehicle)
        {
            this.vehicle = vehicle;
        }

        public void Execute()
        {
            vehicle.increaseSpeed(1);
        }

        public void Undo()
        {
            vehicle.decreaseSpeed(1);
        }
    }
}
