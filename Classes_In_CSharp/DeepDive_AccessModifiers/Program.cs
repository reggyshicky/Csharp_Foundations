using Amazon;

namespace DeepDive_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new Customer();
            //Amazon.


            //side notes, the keyword is used to check the type of an obj
            string name = "reginah";
            if (name is string)
            {
                Console.WriteLine("Indeed it checks the type");
            }
            else
            {
                Console.WriteLine("What hell");
            }
        }
    }



 


}


//internal - Accessibility within the same property assembly/project