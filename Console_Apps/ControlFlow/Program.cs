namespace ControlFlow
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int hour = 21;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is morning!");
            } 
            else if (hour >= 12 && hour <= 18){
                Console.WriteLine("It is afternoon!");
                
            }
            else
            {
                Console.WriteLine("It is night");
            }


            bool isGoldCustomer = true;
            float price;

            //if (isGoldcustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.96f;
            //}

            price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);



            var season = Season.Spring;
            switch(season)
            {
                case Season.Spring:   //this statements means if its Spring or Autumn the I have got a promotion is written on console
                case Season.Autumn:
                    Console.WriteLine("I have got a promotion");
                    break;

                case Season.Winter:
                    Console.WriteLine("It is Winter");
                    break;
                case Season.Summer:
                    Console.WriteLine("It is Summer");
                    break;
                default:
                    Console.WriteLine("Sitambui");
                    break;
            }
        }
    }
}