namespace Classes_In_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.firstName = "Ivans";
            person.lastName = "Waweru";
            person.Introduce("Reginah");
        }
    }

    public class Person
    {
        public string? firstName;
        public string? lastName;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to} i am {firstName} {lastName}");
        }

    }
}