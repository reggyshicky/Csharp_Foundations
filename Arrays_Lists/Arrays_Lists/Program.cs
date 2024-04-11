namespace ArrayList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //Length property - returns the size of an array
            Console.WriteLine(numbers.Length);

            //IndexOf - finds the position of an element in the array
            int index = Array.IndexOf(numbers, 5);
            Console.WriteLine("Index of 5 is " + index);


            //Clear()
            Console.WriteLine("Demonstrate Clear()");
            Array.Clear(numbers, 0, 2); //numbers is the array itself, 0 is the starting index of the range of elements to clear, 2 is the 
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //Copy()
            Console.WriteLine("Demonstrating Copy");
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //Sort()
            Console.WriteLine("Demonstrating Sort()");
            int[] myarr = new int[3] { 9, 10, 7 }; 
            Array.Sort(myarr);
            foreach (var n in myarr)
            {
                Console.WriteLine(n);
            }

        }
    }

}