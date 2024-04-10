using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;

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


            // - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            //Console.WriteLine("Please enter a number");
            //int input = int.Parse(Console.ReadLine());
            //int result = 1;

            //for (int i = 1; i <= input; i++)
            //{
            //    result = result * i;
            //}
            //Console.WriteLine($"{input}! = {result}");



            //3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            //Random random = new Random();
            //int secret = random.Next(1, 10);
            //Console.WriteLine("Please Guess a random number");
            //int guess = int.Parse(Console.ReadLine());
            //if (guess == secret)
            //{
            //    Console.WriteLine($"The secret number is: {secret}");
            //    Console.WriteLine("You won!");
            //}
            //else
            //{
            //    Console.WriteLine($"The secret number is: {secret}");
            //    Console.WriteLine("You Lost!");
            //}

            Random r = new Random();
            int rnum = r.Next(1,10);
            bool guessedCorrectly = false;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter a guess");
                int guess = int.Parse(Console.ReadLine());

                if (guess == rnum)
                {
                    Console.WriteLine($"The secret number is: {rnum}");
                    Console.WriteLine("You won!");
                    guessedCorrectly = true;
                    break;
                } 
                
                  
            }
            if (!guessedCorrectly)
            {
                Console.WriteLine($"The secret number was: {rnum}");
                Console.WriteLine("You Lost!");
            }

;        }
    }
}