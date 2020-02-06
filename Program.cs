using System;

namespace pcarillo_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:"); // get user input
            string name = HelloName(); // call method and save it in a variable
            Console.WriteLine("Hello " + name + "!"); // show message to user input
        }
        // create method
        private static string HelloName()
        {
            string name = Console.ReadLine(); // collect user input
            return name; // return input
        }
    }
}