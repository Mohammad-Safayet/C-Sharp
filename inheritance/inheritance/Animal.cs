namespace inheritance
{
    class Animal
    {
        private string type;

        public string Type { get { return type; } set { type = value; } }

        public Animal() : this("unknown") { }

        public Animal(string type)
        {
            this.type = type;
        }

        protected void getInfo()
        {
            Console.WriteLine($"Animal Type: {Type}");
        }
    }
}
