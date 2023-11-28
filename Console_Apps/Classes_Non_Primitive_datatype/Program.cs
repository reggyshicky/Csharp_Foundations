using System.ComponentModel.DataAnnotations;

namespace Classes_Non_Primitive_datatype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Reginah";
            person1.lastName = "Shikanda";
            person1.Introduction();
            Calculator calculator = new Calculator(1, 5);
            int result = calculator.Add();  
            Console.WriteLine(result);


            int[] numbers = new int[3] { 1, 2, 3 };
            string newArray = string.Join(",", numbers); //the result is a string where the numbers are seperated by commas
            Console.WriteLine(newArray);

            string name = "Reginah";
            char firstLetter = name[0];
            Console.WriteLine(firstLetter); //R

            
            string mName = "Shicy";
            String myName = "Shi"; //String and string same name

            Int32 myNum = 5;
            int myno = 6; //int and Int32 same thing

           
            var names = new string[3] { "John", "Jack", "Mary" };
            var combinedString = string.Join(",", names);
            Console.WriteLine(combinedString); //

            var text = @"Hi John
Look into the following paths
c:\folder\folder2
c:\folder3\folder4";
            Console.WriteLine(text);


            //Output
            //My name is Reginah Shikanda
            //6
            //1,2,3
            //R
            //John, Jack, Mary
            //Hi John
            //Look into the following paths
            //c:\folder\folder2
            //c:\folder3\folder4


            


        }
    }

}