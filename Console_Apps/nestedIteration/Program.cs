using System.Collections.Specialized;

namespace nestedIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach(string elem in myArray)
            {
                if (elem.StartsWith("B"))
                {
                    Console.WriteLine(elem);
                }
            }

            string message = "The quick brown fox jumps over the lazy dog.";

            //convert the message into a char array
            char[] arrayMessage = message.ToCharArray();

            //Reverse the arrayMessage
            Array.Reverse(arrayMessage);

            int count = 0;

            foreach(char elem in arrayMessage)
            {
                if (elem == 'o')
                {
                    count++;
                }
             }

            string newMessage = new string(arrayMessage);

            //print it out
            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {count} times.");
        }
    }
}