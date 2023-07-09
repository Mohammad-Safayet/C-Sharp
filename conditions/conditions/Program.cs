namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Youre age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 6)
            {
                goto HandleLittleKids;
            }
            else
            {
                goto HandleGrownKids;
            }

        HandleLittleKids:
            switch (age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Goto Day-Care");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Goto Preschool");
                    break;
                case 5:
                    Console.WriteLine("Goto Kinder garden");
                    break;
                default:
                    Console.WriteLine("Stay with mother");
                    break;
            }

        HandleGrownKids:
            if (age > 5 && age < 8)
            {
                Console.WriteLine("Goto Elementry School");
            }
            else if (age > 9 && age < 12)
            {

                Console.WriteLine("Goto Middle School");
            }
            else if (age > 13 && age < 17)
            {
                Console.WriteLine("Goto High School");
            }
            else if (age > 14 && age < 25)
            {
                Console.WriteLine("Goto College");
            }
            else
            {
                Console.WriteLine("You Should be independent");
            }
        }
    }
}