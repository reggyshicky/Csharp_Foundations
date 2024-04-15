namespace WorkingWithText_CsharpStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fullname = "reginah Shikanda "; //note the whitespace at the end 
            Console.WriteLine($"Trim: {fullname.Trim()}"); //reginah Shikanda
            Console.WriteLine($"Trim: {fullname.ToLower()}"); //reginah shikanda
            Console.WriteLine($"Trim: {fullname.ToUpper()}");  //REGINAH SHIKANDA

            var index = fullname.IndexOf(' ');
            Console.WriteLine(index);

            var firstName = fullname.Substring(0, index); //0 is the startindex, index limits the no characters to retrieve(length)
            Console.WriteLine(firstName);

            var lastName = fullname.Substring(index + 1); //reginah
            Console.WriteLine(lastName); //Shikanda

            //Alternative
            string[] names = fullname.Split(' ');
            Console.WriteLine("FirstName: " + names[0]); //reginah
            Console.WriteLine("Second: " + names[1]); //Shikanda

            //Replace method
            string nfullName = fullname.Replace("reginah", "shicky");
            Console.WriteLine(nfullName); //shicky Shikanda , you can also use replace a letter with a letter

            //
            if (String.IsNullOrWhiteSpace(nfullName))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("String is not empty");
            }

            //String to int
            string str = "25";
            Byte age = Convert.ToByte(str);
            Console.WriteLine(age);

            //int to string
            float price = 30f;
            Console.WriteLine(price.ToString("C0"));

        }
    }
}