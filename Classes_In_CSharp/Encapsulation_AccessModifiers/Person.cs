namespace Encapsulation_AccessModifiers
{
    public class Person
    {

        public Person(DateTime birthDate)
        {
            BirthDate = birthDate;
        }
        //Auto-Implemented Properties
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            get 
            { 
                TimeSpan timeSpan = DateTime.Today - BirthDate;
                int years = (int) (timeSpan.Days / 365.25);
                
                return years;
            }
            
        }



        //private DateTime _birthDate;
        //Properties
        //public DateTime Birthdate
        //{
        //    get { return _birthDate; }
        //    set { _birthDate = value; }
        //}

        //public void SetBirthDate(DateTime birthDate)
        //{
        //    _birthDate = birthDate;
        //}

        //public DateTime GetBirthDate()
        //{
        //    return _birthDate;
        //}

    }
}
