namespace LearnTimeSpan
{
    public class Program
    {
        public static void Main(string[] args)
            /////*CREATING*/
        {
            //TimeSpan represent a length of time /represents time interval
            //let us create a TimeSpan object
            TimeSpan timeSpan = new TimeSpan(1, 2, 3); //hour, minutes, seconds

            // if no value for minutes and seconds
            TimeSpan timeSpan2 = new TimeSpan(1, 0, 0);

            //More readable way of creating TiemSpan Objects

            TimeSpan.FromHours(1); //creates a TimeSpan object representing a duration of 1 hour

            //Another to create a timespan obj, if you have two datetime objs and you substract them, the result is a TimeSpan
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duratio: " + duration);


            /*PROPERTIES*/
            Console.WriteLine("Minutes: " + timeSpan.Minutes); //returns the minute component of your timespan obj Minutes: 2
            
            Console.WriteLine("Total Minutes:  " + timeSpan.TotalMinutes); //Convert timespan obj to minutes Total Minutes:  62.05

            //Add
            //Modifying a timespan obj, timespan object is immutable
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8))); //Add Example: 01:10:03

            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2))); //Subtract Example: 01:00:03


            //Convert a TimeSpan to a String - call a ToString() method.
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //Parse - Convert a String to a TimeSpan.
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));



        }
    }
}