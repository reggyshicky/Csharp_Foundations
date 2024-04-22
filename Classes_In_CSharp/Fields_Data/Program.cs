namespace Fields_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(2);
            customer.orders.Add(new Order());
            customer.orders.Add(new Order());

            customer.Promote();
            Console.WriteLine(customer.orders.Count);
        }
    }


}
