namespace Exercise
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Please input a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());
            if (number > 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}