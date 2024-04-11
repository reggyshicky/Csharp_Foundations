using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Array_Lists
{

    public class Exercise3
    {
        //1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        //If no one likes your post, it doesn't display anything.
        //If only one person likes your post, it displays: [Friend's Name] likes your post.
        //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
        //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
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
    }

}