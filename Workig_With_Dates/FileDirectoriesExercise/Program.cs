namespace FileDirectoriesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileDirectories n = new FileDirectories();
            n.readTextFile();

            Console.WriteLine("-------");
            n.execise2();
        }
    }
}