using System;

namespace pcarillo_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // try catch to handle errors
            try
            {
                // get user input
                Console.WriteLine("Please enter your name:");
                string name = HelloName();

                // show message to user input
                Console.WriteLine("Hello " + name + "!");

            }
            catch
            {   // show message in case there is an error
                Console.WriteLine("There was an error. Please, try again. ");
            }
        }
        // create method
        private static string HelloName()
        {
            string name = Console.ReadLine(); // collect user input
            return name; // return input
        }
    }
}