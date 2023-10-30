using System.Runtime.CompilerServices;

namespace Call_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random(); //this line crreates an instance of the Random class named "dice". The Random class is part of the  .NET  framework and is used for generating random 
            int roll = dice.Next(1, 7); //this line generates a random integer btn 1(inclusive) and 7(exclusive) using Next method of the dice object.The generated number will be in the range of 1 to 6
            Console.WriteLine(roll); //prints the value of the "roll" variable to the console
            //This code simulates a dice roll using the Random.Next() method to generate a number 


            //EXAMINING OVERLOADED VERSIONS OF THE Random.Next()

            Random dice1 = new Random();
            int roll1 = dice.Next();  //doesn't set an upper and lower boundary so the method will return values ranging from 0 to 2,147,483, 647 which is the max valur an int can storre
            int roll2 = dice.Next(101); //specifies the max value as an upper boundary, expect a random value btn 0 and 100
            int roll3 = dice.Next(50, 101); //specifies both the min and max vlaues, expect value btn 50 and 100
            
            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            //MATH CLASS METHOD CHALLENGE
            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
            
        }

   
    }
}