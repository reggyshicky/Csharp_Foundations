using System.Security.Cryptography.X509Certificates;

namespace Encapsulation_AccessModifiers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.SetBirthDate(new DateTime(2024,1,1));
            //Console.WriteLine($"{person.GetBirthDate().ToShortDateString()}");
            Person person = new Person(new DateTime(1999, 1, 1));
            Console.WriteLine(person.Age);
        }
    }
}
