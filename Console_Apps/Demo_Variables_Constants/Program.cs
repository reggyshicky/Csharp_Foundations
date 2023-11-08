using System.Runtime.InteropServices;

namespace Demo_Variables_Constants
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //0 255 output, range you can store in a byte
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            //The {0} and {0} are placeholders that represent the first and second arguments passed to the Console.WriteLine method respectively

            //CONSTANTS
            const float Pi = 3.14f; //you can change the value

            //Type Conversion
            //Implicit Type Conversion
            byte b = 1;                    //00000001
            int i = b; // 00000000 00000000 00000000 00000001   no data loss will happen
            Console.WriteLine(i);

            int j = 1;
            float f = i; //no data loss

            //Explicit Type Conversion
            int k = 1;
            byte c = (byte)k;

            float w = 1.0f;
            int x = (int)w; //we have to explicitly cast so that the compiler can know we are okay with the data loss

            //Non-Compatible types
            //string s = "1";
            //int i = (int)s; //won't compile

            //We use this mechanism
            string s = "1";
            int e = Convert.ToInt32(s);
            int l = int.Parse(s);

            try
            {
                var number = "1234";
                byte g = Convert.ToByte(number);
                Console.WriteLine(g);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted into a byte, byte can only store 0 to 255");
            }
            //We used the try catch to prevent the application from crashing, 

            try
            {
                string str = "true";
                bool h = Convert.ToBoolean(str);
                Console.WriteLine(h);
            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted into a byte, byte can only store 0 to 255");
            }
        }
    }
}