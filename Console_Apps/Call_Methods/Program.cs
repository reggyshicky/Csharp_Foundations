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
            
        }

   
    }
}