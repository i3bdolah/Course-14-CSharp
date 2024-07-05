using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Useful Escape Characters:\n");

            //Newline
            Console.WriteLine("Newline:");
            Console.WriteLine("Welcome to \nProgrammingAdvices\n");

            //Tab
            Console.WriteLine("Tab:");
            Console.WriteLine("Welcome to\tProgrammingAdvices\n");

            //Backspace
            Console.WriteLine("Backspace:");
            Console.WriteLine("Welcome to \bProgrammingAdvices\n");

            //Single quote
            Console.WriteLine("Single Quote:");
            Console.WriteLine("Welcome to \' ProgrammingAdvices\n");

            //Double quote
            Console.WriteLine("Double Quote:");
            Console.WriteLine("Welcome to \" ProgrammingAdvices\n");

            //Backslash
            Console.WriteLine("Backslash:");
            Console.WriteLine("Welcome to \\ ProgrammingAdvices\n");

            //Alert
            Console.WriteLine("Alert:");
            Console.WriteLine("\a");

        }
    }
}
