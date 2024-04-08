using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Exercise
{
    public class Program
    {
        public static void Main(String[] args)
        {
            // Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
            // a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
            // applications where values entered into input boxes need to be validated.)
            Console.WriteLine("Please input a number between 1 and 10");
            int number = int.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            //Write a program which takes two numbers from the console and displays the maximum of the two.
            Console.WriteLine("Enter the first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(firstNumber, secondNumber);
            //var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("The maximum number is: " + maxNum);

            // Write a program and ask the user to enter the width and height of an image. Then tell if the image 
            // is landscape or portrait.
            Console.WriteLine("Enter the width");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length");
            int length = int.Parse(Console.ReadLine());

            Orientation orientation = (width > length) ? Orientation.LandScape : Orientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);





            // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            // etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            // the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            // display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            // demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            // the console. If the number of demerit points is above 12, the program should display License Suspended.
            int SpeedLimit = 60; //km/hr
            int demeritPoints = 0;
            Console.WriteLine("Please Enter the Speed Limit");
            int userSpeed = int.Parse(Console.ReadLine());

            if (userSpeed < SpeedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int diff = userSpeed - SpeedLimit;

                demeritPoints = demeritPoints + (diff / 5);

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }
                
            }

        }

        public enum Orientation
        {
            LandScape,
            Portrait

        }
    }
}