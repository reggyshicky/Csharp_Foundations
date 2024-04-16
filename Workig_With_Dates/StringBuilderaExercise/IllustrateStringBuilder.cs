using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderaExercise
{
    public class IllustrateStringBuilder
    {
        //1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.
        //For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        public void exercise1()
        {
            Console.WriteLine("Kindly enter a few numbers separated by a hyphen");
            string input = Console.ReadLine();
            string[] arr = input.Split('-');

            List<int> lst = new List<int>();
            foreach (var n in arr)
            {
                lst.Add(int.Parse(n));
            }

            bool isConsecutive = true;
            for(int i = 0; i < lst.Count - 1; i++)
            {
                if (lst[i + 1] - lst[i] != 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }


        //2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply presses Enter,
        //without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
        //If so, display "Duplicate" on the console.
        public void exercise2()
        {
            Console.WriteLine("Please enter a few numbers seperated by a hyphen eg 1-2-3-4): ");
            string input = Console.ReadLine();
            List<int> lst = new List<int>();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }
            else
            {
                string[] arr = input.Split('-');
                foreach (string n in arr)
                {
                    lst.Add(int.Parse(n));
                }
            }

            List<int> uniques = new List<int>();
            bool isDuplicated = false;
            for(int i = 0; i < lst.Count; i++)
            {
                if (uniques.Contains(lst[i])) {
                    isDuplicated = true;
                    break;
                    
                }
                else
                {
                    uniques.Add(lst[i]);
                    
                }
            }

            if (isDuplicated == true)
            {
                Console.WriteLine("Duplicates found");
            }
            else
            {
                Console.WriteLine("No Duplicates were found");
            }

        }

        //3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00).
        //A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise,
        //display "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

        public void exercise3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format(e.g. 19:00), A valid time should be between 00:00 and 23:59");
            string input = Console.ReadLine();
            string[] arr = input.Split(':');

            if (String.IsNullOrWhiteSpace(input)) {
                Console.WriteLine("Invalid Time");
                return;
            }

            if (arr.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            int n = int.Parse(arr[0]);
            int m = int.Parse(arr[1]);

            if ((n >= 0 && n <= 23) && (m >= 0 && m <= 59))
            {
                Console.WriteLine("Ok");
            } else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        //4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.
        //For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on
        //the input.So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

        public void exercise4()
        {
            Console.WriteLine("Please enter a few words seperated by a space");
            string input = Console.ReadLine();

            string[] arr = input.Split(" ");
            StringBuilder n = new StringBuilder();
;
            for(int i = 0; i < arr.Length; i++)
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                string a = textInfo.ToTitleCase(arr[i]);
                n.Append(string.Join("", a));
            }

            Console.WriteLine(n);
        }

        //Mosh Homodani alternative for the above
        public void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }

        //- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word.
        //So, if the user enters "inadequate", the program should display 6 on the console.

        public void exercise5()
        {
            Console.WriteLine("Please enter an English word");
            string input = Console.ReadLine().ToLower();

            List<char> lst = new List<char>() { 'a', 'e', 'i', 'o', 'u'};
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (lst.Contains(input[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }


    }
}
