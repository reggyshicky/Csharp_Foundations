using System.Collections;

namespace UpCasting_And_DownCasting
{


    public class Program
    {
        static void Main(string[] args)
        {
            //Example of UpCasting
            StreamReader reader = new StreamReader(new MemoryStream()); //UpCasting, StreamReader takes aon object of Stream, MemoryStream, FileStream are derived classes from Stream, so converting derived class to base class is UpCasting


            //Example of downcasting
            Shape shape = new Text();
            Text text = (Text) shape;
            
            
            //Text text = new Text();
            //Shape shape = text; //upcasting text and shape references the address in memory.

            //text.Width = 200;
            //shape.Width = 250;

            //Console.WriteLine(text.Width);
        }
    }
}
