namespace class_prac_ii
{
    class Animal
    {
        private string name;
        private int age;
        private string sound;
        public readonly int id;

        public Animal() : this("no name", 0, "no sound") { }

        public Animal(string name, int age, string sound)
        {
            Name = name;
            Age = age;
            Sound = sound;
            id = (new Random()).Next();
        }

        public String Name
        {
            get { return name; }
            set
            {
                if (value.Any(Char.IsDigit))
                {
                    Console.WriteLine("Name can't contain digit");
                    name = "";
                }
                else name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 50)
                {
                    Console.WriteLine("Age can't be bigger than 50");
                    age = -1;
                }
                else age = value;
            }
        }
        public String Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Sound can't be long than 10 character.");
                    sound = "";
                }
                else sound = value;
            }
        }

        public void pet()
        {
            Console.WriteLine("Rolling on the ground");
        }

        public void getInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge:{Age}\nSound: {Sound}");
        }
    }
}
