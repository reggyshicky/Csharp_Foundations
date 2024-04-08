namespace random
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Random random = new Random();
            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (int j = 0; j < passwordLength; j++)
            {
                buffer[j] = (char)('a' + random.Next(0, 26));

            }
            var password = new String(buffer); //initializes a new instance of the string
            Console.WriteLine(password);

                
                //Console.WriteLine(random.Next());//random.next() takes no parameters, returns a non-negative random number
                //Console.WriteLine(random.Next(1, 10)); //take two params, minValue and MaxValue. get random number equal or greater than 1 and less than 10, (MaxValue is excluded)

        }
    }
}