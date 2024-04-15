using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
