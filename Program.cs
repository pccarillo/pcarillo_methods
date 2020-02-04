using System;

namespace pcarillo_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, what's your name?"); // display message asking for name
            string name = Console.ReadLine(); // collect user input and store it inside the variable name
            Console.WriteLine("Hello " + name + "!"); // print strings along with variable name
        }
    }
}