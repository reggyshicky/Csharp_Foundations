using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectoriesExercise
{
    public class FileDirectories
    {

        //1- Write a program that reads a text file and displays the number of words.
        public void readTextFile()
        {
            string path = @"D:\fold\testing.txt";
            string results = File.ReadAllText(path);

            Console.WriteLine(results);

        }

        //2- Write a program that reads a text file and displays the longest word in the file.

        public void execise2()
        {
            string path = @"D:\fold\testing.txt";
            string results = File.ReadAllText(path);

            string[] arr = results.Split(" ");
            List<string> lst = new List<string>();

            foreach(var item in arr)
            {
                lst.Add(item);
            }

            string longest = lst[0];

            for(int i = 0; i < lst.Count; i++)
            {
                if (lst[i].Length > longest.Length)
                {
                    longest = lst[i];
                }
            }

            Console.WriteLine(longest);
         
        }
        

    }
}
