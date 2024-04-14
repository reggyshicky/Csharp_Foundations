namespace LearnDateTime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2024, 1, 1);
            DateTime now = DateTime.Now; //gets the current time
            DateTime today = DateTime.Today; //returns today's data irrespective of the time

            //let us access year, month, minutes hour etc from a DateTime object
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Seconds: " + now.Second);



            //Methods to DateTime
            DateTime tomorrow = now.AddDays(1); //returns tomorrow current time

            //if you want to go back in the past you use a negative number
            DateTime yesterday = now.AddDays(-1); 

            //Formatting DateTime C# objects to a date or time String
            Console.WriteLine("ToLongDateString: " + now.ToLongDateString());  //Sunday, 14 April 2024
            Console.WriteLine("ToShortDateString: " + now.ToShortDateString()); // 14/04/2024
            Console.WriteLine("ToLongTimeString : " + now.ToLongTimeString()); //  16:24:19
            Console.WriteLine("ToShortTimeString: " + now.ToShortTimeString()); // 16:24

            //if you want to display both Date and Time you use ToString method
            Console.WriteLine(now.ToString()); //14/04/2024 16:24:19

            //DateTime Format specifier concept, ToString() optionally takes an argument and that is where we come in with format specifiers
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm")); //2024-04-14

            //Resources
            //https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        }
    }
}