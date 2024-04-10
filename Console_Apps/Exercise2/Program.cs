using System.Diagnostics.CodeAnalysis;

namespace Exerice2
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
            //int count = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Please enter a number or OK to exit");
            //    String num = Console.ReadLine();
            //    if (num == "OK")
            //    {
            //        Console.WriteLine(sum);
            //        break;
            //    }
            //    sum = sum + int.Parse(num);
            //}

            Console.WriteLine("Please enter a number");
            int input = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= input; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"{input}! = {result}");
        }



    }
}