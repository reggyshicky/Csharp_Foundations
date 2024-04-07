namespace InputFromConsole
{
    class Program
    {
        public static void Main(String[] args)
        {
            //String Input
            Console.WriteLine("Name a country");
            String country = Console.ReadLine();

            //Integer Input
            Console.WriteLine("Name your lucky number");
            int luckyNum = int.Parse(Console.ReadLine());
            Console.WriteLine(luckyNum is int);

            //Double Input
            Console.WriteLine("Give a double");
            double num = double.Parse(Console.ReadLine());

            //Float Input
            Console.WriteLine("Give a float");
            float number = float.Parse(Console.ReadLine());

        }
    }
}