namespace rebornClasses
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Reborn r = new Reborn();
            r.Introduce();
        }
    }

    public class Reborn
    {
        string firstName;
        string lastName;


        public void Introduce()
        {
            Console.WriteLine("What is your firstName?");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine($"Hi, My 1st name is {firstName} and 2nd name is {lastName}");
        }
    }
}