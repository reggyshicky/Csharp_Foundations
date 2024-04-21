namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Name = "Reginah";
            customer.Id = 4;
            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}