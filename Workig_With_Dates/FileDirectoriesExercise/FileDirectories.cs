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
            string path = @"D:\\fold\testing.txt";
            string results = File.ReadAllText(path);

            Console.WriteLine(results);

        }
    }
}
