﻿using System;

namespace CoreHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name");
            var name = Console.ReadLine();
            Console.WriteLine(HelloUsernameParser.HelloUsernameParser.Parse(name));
            Console.ReadKey();
        }
    }
}
