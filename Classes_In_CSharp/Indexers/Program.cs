﻿namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCooKie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);

        }
    }
}
