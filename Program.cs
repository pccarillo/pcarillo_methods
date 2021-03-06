﻿using System;

namespace pcarillo_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:"); // get user input
            HelloName(); // call method and save it in a variable
        
            // create method
            void HelloName()
            {
                string name = Console.ReadLine(); // collect user input
                if (System.Text.RegularExpressions.Regex.IsMatch(name, "[a-zA-Z]" + " " + "[a-zA-Z]+$")) // test if user entered string or not
                {
                    // display message to user
                    Console.WriteLine("Hello" + " " + name + "!");
                    Console.WriteLine("Thank you for giving an acceptable input.");
                }
                else if (System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    // display message to user
                    Console.WriteLine("Hello" + " " + name + "!");
                    Console.WriteLine("Thank you for giving an acceptable input.");
                }
                else
                {
                    // display error message to user
                    Console.WriteLine("Please only enter alphabetical letters.");
                    Console.WriteLine("Please enter your name and try again.");
                }
            }
        }
    }
}