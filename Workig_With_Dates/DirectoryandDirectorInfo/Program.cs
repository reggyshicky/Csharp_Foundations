namespace DirectoryandDirectorInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"D:\Directory");
            string[] files = Directory.GetFiles(@"D:\Directory", "*.*", SearchOption.AllDirectories); //returns a string array
            string[] filess = Directory.GetFiles(@"D:\Directory", "*.sln*", SearchOption.AllDirectories);

            foreach (string num in files)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Directories");
            string[] directories = Directory.GetDirectories(@"D:");
            foreach(var dir in directories)
            {
                Console.WriteLine(dir);
            }
            Console.WriteLine(Directory.Exists(@"D:\Directory"));


            //DirectoryInfo
            DirectoryInfo m = new DirectoryInfo(@"D:Directory");
            m.GetFiles();
            m.GetDirectories();

        }

    }
}