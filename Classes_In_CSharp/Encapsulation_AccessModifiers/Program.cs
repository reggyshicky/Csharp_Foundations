namespace Encapsulation_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(2024,1,1));
            Console.WriteLine($"{person.GetBirthDate().ToShortDateString()}");



        }
    }

    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }

    }
}
