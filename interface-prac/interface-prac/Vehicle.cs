namespace interface_prac
{
    class Vehicle : IEngine
    {
        private int speed;
        private string brand;
        private string model;

        public int Speed { get { return speed; } }

        public Vehicle(string brand, string model)
        {
            speed = 0;
            this.brand = brand;
            this.model = model;
        }

        public void decreaseSpeed(int speed)
        {
            this.speed -= speed;
            Console.WriteLine("Speed decreased to {0}", this.speed);
        }

        public void increaseSpeed(int speed)
        {
            this.speed += speed;
            Console.WriteLine("Speed increased to {0}", this.speed);
        }

        public void start()
        {
            Console.WriteLine("Engine Turned on");
        }

        public void stop()
        {
            Console.WriteLine("Engine Turned off");
        }
    }
}
