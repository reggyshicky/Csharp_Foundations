﻿namespace Opeators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            Console.WriteLine((float)a / (float)b);
            Console.WriteLine(a + b * c); //operators precedence
        }
    }
}