namespace Value_Reference_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a: {a} b:{b}");

            var array = new int[3] { 1, 2, 3 };
            var array2 = array;
            array2[0] = 0;
            Console.WriteLine($"array[0]: {array[0]} array2[0]: {array2[0]}");
            //Value types directly store their data in memory, and when you assign a value type
            //to another variable, a copy of the data is made. Changes to one variable do not affect 
            //the other.Examples of value types include primitive types(int, float, char and userdefined structs)
            //Reference types store a reference to the memory location where the actual data is stored. When you 
            //assign a reference type to another variable, you are copying the reference, not the actual data
            //Both variables then refer to the same data in memory. Examples include, classes, arrays and interfaces
        }
    }
}