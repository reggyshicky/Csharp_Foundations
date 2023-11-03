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
        }
    }
}