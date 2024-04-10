using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exerice2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);

            //Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number (or 'ok' to exit)");
                string num = Console.ReadLine();
                if (num.ToLower() == "ok")
                {
                    break;
                }
                sum = sum + int.Parse(num);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);


            // - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
            //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            Console.WriteLine("Please enter a number");
            int input = int.Parse(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= input; i++)
            {
                result = result * i;
            }
            Console.WriteLine($"{input}! = {result}");

            //4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
            Random r = new Random();
            int rnum = r.Next(1, 10);
            //Console.WriteLine("Secret is " + rnum);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Pleas guess the secret number");
                int guess = int.Parse(Console.ReadLine());

                if (guess == rnum)
                {
                    Console.WriteLine($"The secret number is: {rnum}");
                    Console.WriteLine("You won!");
                    return;
                }
            }
            Console.WriteLine($"The secret number was: {rnum}");
            Console.WriteLine("You Lost!");

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and
            //display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.WriteLine("Enter a series of numbers of seperated by commas");
            string inputt = Console.ReadLine();
            var numbers = inputt.Split(',');

            //Assume the first number is the max
            int max = int.Parse(numbers[0]);

            foreach(var str in numbers)
            {
                var number = int.Parse(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is " + max);
        }
    }
}