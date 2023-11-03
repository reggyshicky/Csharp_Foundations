namespace ArraysBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The new operator creates a new instance of an array in the computer's memory that can hold 3 values
            /*The first set of square brackets merely tells the compiler that the variable named fraudulentOrderIDs is an array, but the second set of square brackets [3] indicates
            the number of elements that the array can hold
            string[] fraudulentOrderIDs = new string[3];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            fraudulentOrderIDs[3] = "D0000";
            */
            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

            string[] names = { "Reginah", "Shikanda", "Bao" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}