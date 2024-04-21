namespace ObjectInitializer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Object Initializer syntax
            List<int> lst = new List<int>() { 1, 2, 3, 5, 6 };
            Home home = new Home() { Name = "Reginah", Price = "600" };
            Console.WriteLine($"My name is {home.Name}");
        }

        
    }

    public class Home
    {
        public string Name;
        public string Price;
    }
    
}