using System.Reflection.Metadata;

namespace Enums
{
    //We define enums at the namespace level
    public enum ShippingMethods
    {
        RegularAirMail= 1,
        RegisteAirMail = 2,
        Express = 3

    }
    //Enums are internally integers
    //always explicitly set the value of the enum numbers
    //if you dont set any values to members of the enums, the first member will be set to zero and from their every members value will be incremented by 1
    public class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethods.Express;
            Console.WriteLine((int)method);

            //Conveting a given shipping method id to the shipping methd
            var methodId = 3;
            Console.WriteLine((ShippingMethods)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);


        }
    }
}