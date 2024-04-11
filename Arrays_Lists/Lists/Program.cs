using System.Runtime.InteropServices;

namespace Lists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2 ,3, 4};

            //Add
            numbers.Add(1); //adds one element

            //Add Range
            numbers.AddRange(new int[3] { 5, 6, 7,}); //adds  a range of elements
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Illustrate IndexOf");
            //IndexOf and LastIndexOf
            Console.WriteLine("Illustrate index of");
            Console.WriteLine($"Index of {numbers.IndexOf(5)}" ); //search from beginning of the list
            Console.WriteLine($"Last index of 1 is {numbers.LastIndexOf(1)}"); //search from the end of the list

            //Count
            Console.WriteLine("Illustrate Count");
            Console.WriteLine(numbers.Count); //note in Lists we use Count and in Arrays we use Length


            Console.WriteLine("Illustrate Remove");
            //numbers.Remove(1); //remove takes the parameter of the item itself

            //Removing all occurrences of 1
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers.Clear();
            Console.WriteLine(numbers.Count);

        }
    }
}