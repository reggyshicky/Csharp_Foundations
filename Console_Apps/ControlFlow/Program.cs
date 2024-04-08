namespace ControlFlow
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int hour = 21;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning!");
            } 
            else if (hour >= 12 && hour <= 18){
                Console.WriteLine("It is afternoon!");
                
            }
            else
            {
                Console.WriteLine("It is night");
            }
        }
    }
}