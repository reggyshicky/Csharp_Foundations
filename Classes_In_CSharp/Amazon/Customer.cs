namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Promote()
        {
            var calc = new RateCalculator();
            var rating = calc.Calculate(this);
            Console.WriteLine("Promote logic changed");

        }
   
    }


}


//internal - Accessibility within the same property assembly/project