namespace Classes_Exercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            StopWatch s = new StopWatch();

            DateTime start = s.start();

            Console.WriteLine("____starting");
            //Perform some operation to measure
            //For example, simulate some  work with a delay
            Thread.Sleep(10000);

            DateTime stop = s.stop();
            Console.WriteLine("____stopping");

            TimeSpan duration = s.GetDuration(start, stop);
            Console.WriteLine(duration);

        }
    }
}
