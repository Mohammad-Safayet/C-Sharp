namespace inner_class_prac
{
    class Vehicle
    {
        public string brand;
        public Owner owner;

        public Vehicle(string brand) : this(brand, new Vehicle.Owner("")) { }

        public Vehicle(string brand, Owner owner)
        {
            this.brand = brand;
            this.owner = owner;
        }

        public void getInfo()
        {
            Console.WriteLine("Brand: {0}", brand);
            owner.getInfo();
        }

        public class Owner
        {
            private readonly int id;
            private string name;

            public Owner(string name)
            {
                this.id = (new Random()).Next();
                Name = name;
            }


            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public void getInfo()
            {
                Console.WriteLine("Owner: {0}\nID: {1}", Name, this.id);
            }
        }
    }
}
