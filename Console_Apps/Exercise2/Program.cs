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

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number or OK to exit");
                String num = Console.ReadLine();
                if (num == "OK")
                {
                    Console.WriteLine(sum);
                    break;
                }
                sum = sum + int.Parse(num);
            }
        }

    }
}