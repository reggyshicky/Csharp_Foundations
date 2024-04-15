//using System.Text;
using System.Text;

namespace LearnStringBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder builder = new StringBuilder("Hello World");
            //builder.Append('!', 10); //appends 10 times
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('!', 10);
            //builder.Replace('!', '_');
            //builder.Remove(0, 10);
            //builder.Insert(0, new string('+', 10));
            //Console.WriteLine(builder);
            //Console.WriteLine(builder[10]);

            StringBuilder builder = new StringBuilder("Hello World");
            builder
                .Append('!', 10) //appends 10 times
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('!', 10)
                .Replace('!', '_')
                .Remove(0, 10)
                .Insert(0, new string('+', 10));
            Console.WriteLine(builder);
            Console.WriteLine(builder[10]);
        }
    }
}