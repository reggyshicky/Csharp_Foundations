namespace Codility_Dates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var formatter = new Codility_Date();
            Console.WriteLine(formatter.Format(DateTime.Now.AddMinutes(-10), DateTime.Now)); // 10 minute(s) ago
            Console.WriteLine(formatter.Format(DateTime.Now.AddHours(-1), DateTime.Now)); // 1 hour(s) ago
            Console.WriteLine(formatter.Format(DateTime.Now.AddHours(-12), DateTime.Now)); // 12 hour(s) ago
            Console.WriteLine(formatter.Format(DateTime.Now.AddDays(-1), DateTime.Now)); // 1 day(s) ago
            Console.WriteLine(formatter.Format(DateTime.Now.AddDays(-4), DateTime.Now)); // 4 day(s) ago
            Console.WriteLine(formatter.Format(new DateTime(2018, 10, 10, 22, 5, 0), DateTime.Now)); // 2018-10-10 22:05
            Console.WriteLine(formatter.Format(DateTime.Now, DateTime.Now)); // now

            X_Y solution = new X_Y();

            // Example 1
            int X1 = 3;
            int Y1 = 5;
            int[] A1 = { 1, 2, 3, 2, 3, 2, 3 };
            Console.WriteLine("Example 1 : " + solution.Solution(X1, Y1, A1));

            // Example 2
            int X2 = 4;
            int Y2 = 5;
            int[] A2 = { 4, 4, 5, 5, 4, 5, 5, 4, 5, 5 };
            Console.WriteLine("Example 2" + solution.Solution(X2, Y2, A2));

            // Example 3
            int X9 = 100;
            int Y9 = 63;
            int[] A9 = { 100, 63, 1, 6, 1, 13 };
            Console.WriteLine("Example 3 " + solution.Solution(X9, Y9, A9));

            // Example 4
            int X3 = 1;
            int Y3 = 2;
            int[] A3 = { 1, 1, 1, 1, 2, 2, 2, 2 };
            Console.WriteLine("Example 4" + solution.Solution(X3, Y3, A3)); // Expected output: 7

            // Example 5
            int X4 = 1;
            int Y4 = 3;
            int[] A4 = { 1, 3, 3, 1, 3, 1, 1, 3 };
            Console.WriteLine("Example 5: " + solution.Solution(X4, Y4, A4)); // Expected output: 7

            // Example 6
            int X5 = 1;
            int Y5 = 1;
            int[] A5 = { 1, 1, 1, 1 };
            Console.WriteLine("Example 6: " + solution.Solution(X5, Y5, A5));

            // Example 7
            int X10 = 5;
            int Y10 = 5;
            int[] A10 = { 5 };
            Console.WriteLine("Example 7: " + solution.Solution(X10, Y10, A10));

            // Example 8
            int X11 = 5;
            int Y11 = 5;
            int[] A11 = { };
            Console.WriteLine("Example 8: " + solution.Solution(X11, Y11, A11));
        }
    }
}
