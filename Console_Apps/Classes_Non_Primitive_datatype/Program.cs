namespace Classes_Non_Primitive_datatype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Reginah";
            person1.lastName = "Shikanda";
            person1.Introduction();
            Calculator calculator = new Calculator(1, 5);
            int result = calculator.Add();
            Console.WriteLine(result);


        }
    }

}