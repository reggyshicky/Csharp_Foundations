namespace DemoPath
{
    public class Program
    {
        //Path is class that provides a number of methods that makes it really easy to work with a string 
        //that representd a path and extract different parts of that path
        static void Main(string[] args)
        {
            string path = @"D:\fold\testing.txt";

            int index = path.IndexOf('.');
            string str = path.Substring(0);

            Console.WriteLine($"Extension: {Path.GetExtension(path)}"); //.docx
            Console.WriteLine($"FileName: {Path.GetFileName(path)}"); //Fgsredtkfygj.docx
            Console.WriteLine($"FileNameWithoutExtension: {Path.GetFileNameWithoutExtension(path)}"); // Fgsredtkfygj
            Console.WriteLine($"Directory that has the file is:  {Path.GetDirectoryName(path)}"); //returns a directory in which that file is sitting
        }
    }
}