namespace inheritance
{
    class Dog : Animal
    {
        private string name;
        private int age;

        public String Name { get { return name; } }
        public int Age { get { return age; } }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            Type = "Dog";
        }

        public new void getInfo()
        {
            base.getInfo();
            Console.WriteLine($"Name: {name}\nAge: {age}");
        }
    }
}
