using System.ComponentModel.DataAnnotations;

namespace Exercise
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //Question 1
            //Console.WriteLine("Please input a number between 1 and 10");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 1 && number <= 10)
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //Question 2
            //Console.WriteLine("Enter the first number");
            //int firstNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the second number");
            //int secondNumber = int.Parse(Console.ReadLine());
            //int maxNum = Math.Max(firstNumber, secondNumber);
            //Console.WriteLine("The maximum number is: " + maxNum);

            //Question 3
            Console.WriteLine("Enter the width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length");
            int length = int.Parse(Console.ReadLine());

            int Max = Math.Max(width, length);

            if (Max == width)
            {
                Console.WriteLine("It is LandScape");
            }
            else
            {
                Console.WriteLine("It is Portrait");
            }






        }
    }
}