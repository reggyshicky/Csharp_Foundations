using System.ComponentModel.DataAnnotations;

namespace WorkingWithFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //FILE
            var path = @"D:\home.txt";
            var path2 = @"D:\lol.txt";
            var path3 = @"D:\wow.txt";
            File.Copy(@"D:\fold\testing.txt", @"E:\testbitbucketrepo\testing.txt", true);
            File.Delete(path);
            File.Create(path);
            if (File.Exists(path) == true)
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File does not exists");
            }

            var content = File.ReadAllText(@"D:\fold\testing.txt"); //returns a astring

            Console.WriteLine(content);
            //File.ReadAllBytes(path); //returns byte array , as binary


            //FileInfo

            FileInfo fileInfo = new FileInfo(path2);
            fileInfo.CopyTo(path2);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine("File exists");
            }

        }
    }
}