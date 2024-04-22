using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Methods
{
    public class Program
    {

        static void Main(string[] args)
        {
         

        }

        static void UseParams()
        {
            var calc = new Calculator();
            calc.Add(2, 3, 5, 6, 7);
            calc.Add(5, 6, 7, 8);
            Console.WriteLine(calc.Add([2, 5, 6, 7]));

        }
        static void UsePoints()
        {
            try
            {
                Point point = new Point(5, 10);
                //point.Move(new Point(10, 20));..
                point.Move(null);

                Console.WriteLine($"Point is at ({point.X}, {point.Y})");

                point.Move(100, 200);
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");
            }
            catch (Exception)
            {
                Console.WriteLine("An  unexpected error occured.");
            }
        }
    }
}