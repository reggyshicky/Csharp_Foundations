using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Array_Lists
{

    public class Exercise3
    {
        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        //Write a program and continuously ask the user to enter different names, until the user presses Enter(without supplying a name). Depending on the number of names provided, display a message based on the above pattern.


        public void facebook()
        {
            List<string> names = new List<string>();
            while (true)
            {
                Console.WriteLine("Type a name(or hit ENTER to quit): ");
                String input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }
          
            if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} like your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            }
            else if (names.Count > 2)
            {
                int otherCount = names.Count - 2;
                Console.WriteLine($"{names[0]}, {names[1]} and {otherCount} others like your post");
            }
            else
            {
                Console.WriteLine();
            }
        }
        //Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string.
        //Display the reversed name on the console.
        public void arrayReverse()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            char[] nameArr = name.ToCharArray();
            Array.Reverse(nameArr);

            string reversedString = string.Join("", nameArr);
            Console.WriteLine(reversedString);
        }

        //public void Exercise2()
        //{
        //    Console.Write("What's your name? ");
        //    var name = Console.ReadLine();

        //    var array = new char[name.Length];
        //    for (var i = name.Length; i > 0; i--)
        //        array[name.Length - i] = name[i - 1];

        //    var reversed = new string(array);
        //    Console.WriteLine("Reversed name: " + reversed);
        //}
    }

}